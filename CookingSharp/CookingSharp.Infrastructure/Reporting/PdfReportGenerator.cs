using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CookingSharp.Infrastructure.Reporting
{
    /// <summary>
    /// Implementación del generador de reportes PDF utilizando la biblioteca QuestPDF.
    /// </summary>
    public class PdfReportGenerator : IPdfReportGenerator
    {
        public PdfReportGenerator()
        {
            QuestPDF.Settings.License = LicenseType.Community;
        }

        #region Popularity Report

        /// <summary>
        /// Genera el reporte de popularidad de recetas.
        /// </summary>
        public byte[] GeneratePopularityReport(IEnumerable<RecipePopularityReportDto> data)
        {
            var dataList = data.ToList();
            if (!dataList.Any())
            {
                return GenerateEmptyReport("Reporte de Popularidad de Recetas", "No hay suficientes datos para generar el reporte.");
            }

            var top5ForChart = dataList.Take(5).OrderBy(d => d.Rank).ToList();
            byte[] chartBytes = GeneratePopularityBarChart(top5ForChart);

            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.Header().Element(c => Header(c, "Reporte de Popularidad de Recetas"));
                    page.Content().Element(content => PopularityContent(content, dataList, chartBytes));
                    page.Footer().Element(Footer);
                });
            }).GeneratePdf();
        }

        private void PopularityContent(IContainer container, List<RecipePopularityReportDto> data, byte[] chartImage)
        {
            container.PaddingVertical(1, Unit.Centimetre).Column(column =>
            {
                column.Item().Text("Top 5 Recetas Mejor Valoradas").Bold().FontSize(16);
                column.Item().PaddingTop(10).Image(chartImage, ImageScaling.FitWidth);
                column.Item().PaddingVertical(20);
                column.Item().Text("Ranking Detallado").Bold().FontSize(16);
                column.Item().PaddingTop(10).Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(30);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(2);
                        columns.RelativeColumn(1.5f);
                        columns.RelativeColumn(1);
                    });
                    table.Header(header =>
                    {
                        header.Cell().Text("#");
                        header.Cell().Text("Título");
                        header.Cell().Text("Autor");
                        header.Cell().Text("Puntaje Pond.");
                        header.Cell().Text("Votos");
                    });
                    foreach (var item in data)
                    {
                        table.Cell().Text(item.Rank.ToString());
                        table.Cell().Text(item.Title);
                        table.Cell().Text(item.Author);
                        table.Cell().Text(item.WeightedScore.ToString("N2"));
                        table.Cell().Text(item.VoteCount.ToString());
                    }
                });
            });
        }

        private byte[] GeneratePopularityBarChart(List<RecipePopularityReportDto> data)
        {
            var plot = new Plot();
            plot.Title("Top 5 Recetas por Puntuación Ponderada");

            var scores = data.Select(d => d.WeightedScore).ToArray();
            var labels = data.Select(d => d.Title).ToArray();

            System.Array.Reverse(scores);
            System.Array.Reverse(labels);

            var barPlot = plot.Add.Bars(scores);
            barPlot.Horizontal = true;

            barPlot.ValueLabelStyle.IsVisible = true;

            var ticks = labels.Select((label, index) => new Tick(index, label)).ToArray();
            plot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            plot.Axes.Left.MajorTickStyle.Length = 0;

            plot.Grid.IsVisible = false;

            return plot.GetImageBytes(600, 400);
        }

        #endregion

        #region Chef Contribution Report

        /// <summary>
        /// Genera el reporte de contribución por chef.
        /// </summary>
        public byte[] GenerateChefContributionReport(IEnumerable<ChefContributionReportDto> data)
        {
            var dataList = data.ToList();
            if (!dataList.Any())
            {
                return GenerateEmptyReport("Reporte de Contribución por Chef", "No hay chefs o no han publicado recetas.");
            }

            var top5ForChart = dataList.Take(5).OrderByDescending(d => d.PublishedRecipesCount).ToList();
            byte[] chartBytes = GenerateContributionBarChart(top5ForChart);

            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.Header().Element(c => Header(c, "Reporte de Contribución por Chef"));
                    page.Content().Element(content => ContributionContent(content, dataList, chartBytes));
                    page.Footer().Element(Footer);
                });
            }).GeneratePdf();
        }

        private void ContributionContent(IContainer container, List<ChefContributionReportDto> data, byte[] chartImage)
        {
            container.PaddingVertical(1, Unit.Centimetre).Column(column =>
            {
                column.Item().Text("Top 5 Chefs por Recetas Publicadas").Bold().FontSize(16);
                column.Item().PaddingTop(10).Image(chartImage, ImageScaling.FitWidth);
                column.Item().PaddingVertical(20);
                column.Item().Text("Listado Completo de Contribuciones").Bold().FontSize(16);
                column.Item().PaddingTop(10).Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(40);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(2);
                    });
                    table.Header(header =>
                    {
                        header.Cell().Text("#");
                        header.Cell().Text("Nombre del Chef");
                        header.Cell().Text("Recetas Publicadas");
                    });
                    foreach (var item in data)
                    {
                        table.Cell().Text(item.Rank.ToString());
                        table.Cell().Text(item.ChefName);
                        table.Cell().Text(item.PublishedRecipesCount.ToString());
                    }
                });
            });
        }

        private byte[] GenerateContributionBarChart(List<ChefContributionReportDto> data)
        {
            var plot = new Plot();
            plot.Title("Top 5 Chefs por Recetas Publicadas");

            double[] counts = data.Select(d => (double)d.PublishedRecipesCount).ToArray();
            string[] labels = data.Select(d => d.ChefName).ToArray();

            System.Array.Reverse(counts);
            System.Array.Reverse(labels);

            var barPlot = plot.Add.Bars(counts);
            barPlot.Horizontal = true;
            barPlot.ValueLabelStyle.IsVisible = true;

            var ticks = labels.Select((label, index) => new Tick(index, label)).ToArray();
            plot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            plot.Axes.Left.MajorTickStyle.Length = 0;
            plot.Grid.IsVisible = false;

            return plot.GetImageBytes(600, 400);
        }

        #endregion

        #region Shared PDF Elements

        private void Header(IContainer container, string title)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item().Text(title).SemiBold().FontSize(20).FontColor(QuestPDF.Helpers.Colors.Blue.Medium);
                    column.Item().Text($"Fecha de generación: {DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(9);
                });
            });
        }

        private void Footer(IContainer container)
        {
            container.AlignCenter().Text(text =>
            {
                text.Span("Página ");
                text.CurrentPageNumber();
                text.Span(" de ");
                text.TotalPages();
            });
        }

        private byte[] GenerateEmptyReport(string title, string message)
        {
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.Header().Element(c => Header(c, title));
                    page.Content().AlignCenter().AlignMiddle().Text(message).FontSize(14);
                    page.Footer().Element(Footer);
                });
            }).GeneratePdf();
        }

        #endregion
    }
}