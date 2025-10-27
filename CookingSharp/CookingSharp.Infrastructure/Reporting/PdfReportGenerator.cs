using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CookingSharp.Infrastructure.Reporting
{
    /// <summary>
    /// Implementación del generador de reportes PDF utilizando la biblioteca QuestPDF.
    /// Esta versión se enfoca en reportes tabulares limpios, sin gráficos.
    /// </summary>
    public class PdfReportGenerator : IPdfReportGenerator
    {
        public PdfReportGenerator()
        {
            QuestPDF.Settings.License = LicenseType.Community;
        }

        #region Popularity Report

        public byte[] GeneratePopularityReport(IEnumerable<RecipePopularityReportDto> data)
        {
            var dataList = data.ToList();
            if (!dataList.Any())
            {
                return GenerateEmptyReport("Reporte de Popularidad de Recetas", "No hay suficientes datos para generar el reporte.");
            }

            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.Header().Element(c => Header(c, "Reporte de Popularidad de Recetas"));
                    page.Content().Element(content => PopularityContent(content, dataList));
                    page.Footer().Element(Footer);
                });
            }).GeneratePdf();
        }

        private void PopularityContent(IContainer container, List<RecipePopularityReportDto> data)
        {
            container.PaddingVertical(1, Unit.Centimetre).Column(column =>
            {
                column.Item().Text("Ranking Detallado de Recetas por Popularidad").Bold().FontSize(16);
                column.Item().PaddingTop(20).Table(table =>
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
                        header.Cell().Element(HeaderStyle).Text("#");
                        header.Cell().Element(HeaderStyle).Text("Título");
                        header.Cell().Element(HeaderStyle).Text("Autor");
                        header.Cell().Element(HeaderStyle).Text("Puntaje Pond.");
                        header.Cell().Element(HeaderStyle).Text("Votos");
                    });

                    foreach (var item in data)
                    {
                        table.Cell().Element(CellStyle).Text(item.Rank.ToString());
                        table.Cell().Element(CellStyle).Text(item.Title);
                        table.Cell().Element(CellStyle).Text(item.Author);
                        table.Cell().Element(CellStyle).Text(item.WeightedScore.ToString("N2"));
                        table.Cell().Element(CellStyle).Text(item.VoteCount.ToString());
                    }
                });
            });
        }

        #endregion

        #region Chef Contribution Report

        public byte[] GenerateChefContributionReport(IEnumerable<ChefContributionReportDto> data)
        {
            var dataList = data.ToList();
            if (!dataList.Any())
            {
                return GenerateEmptyReport("Reporte de Contribución por Chef", "No hay chefs o no han publicado recetas.");
            }

            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.Header().Element(c => Header(c, "Reporte de Contribución por Chef"));
                    page.Content().Element(content => ContributionContent(content, dataList));
                    page.Footer().Element(Footer);
                });
            }).GeneratePdf();
        }

        private void ContributionContent(IContainer container, List<ChefContributionReportDto> data)
        {
            container.PaddingVertical(1, Unit.Centimetre).Column(column =>
            {
                column.Item().Text("Listado de Contribuciones por Chef").Bold().FontSize(16);
                column.Item().PaddingTop(20).Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(40);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(2);
                    });

                    table.Header(header =>
                    {
                        header.Cell().Element(HeaderStyle).Text("#");
                        header.Cell().Element(HeaderStyle).Text("Nombre del Chef");
                        header.Cell().Element(HeaderStyle).Text("Recetas Publicadas");
                    });

                    foreach (var item in data)
                    {
                        table.Cell().Element(CellStyle).Text(item.Rank.ToString());
                        table.Cell().Element(CellStyle).Text(item.ChefName);
                        table.Cell().Element(CellStyle).Text(item.PublishedRecipesCount.ToString());
                    }
                });
            });
        }

        #endregion

        #region Recipe Engagement Report

        public byte[] GenerateRecipeEngagementReport(IEnumerable<RecipeEngagementReportDto> data)
        {
            var dataList = data.ToList();
            if (!dataList.Any())
            {
                return GenerateEmptyReport("Análisis de Recetas: Complejidad vs. Engagement", "No hay recetas publicadas con suficientes datos para analizar.");
            }

            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.Header().Element(c => Header(c, "Análisis de Recetas: Complejidad vs. Engagement"));
                    page.Content().Element(content => EngagementContent(content, dataList));
                    page.Footer().Element(Footer);
                });
            }).GeneratePdf();
        }

        private void EngagementContent(IContainer container, List<RecipeEngagementReportDto> data)
        {
            container.PaddingVertical(1, Unit.Centimetre).Column(column =>
            {
                column.Item().Text("Datos Detallados de Recetas Analizadas").Bold().FontSize(16);
                column.Item().PaddingTop(20).Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(4);
                        columns.RelativeColumn(3);
                        columns.ConstantColumn(50);
                        columns.ConstantColumn(60);
                        columns.ConstantColumn(70);
                    });

                    table.Header(header =>
                    {
                        header.Cell().Element(HeaderStyle).Text("Receta");
                        header.Cell().Element(HeaderStyle).Text("Autor");
                        header.Cell().Element(HeaderStyle).AlignRight().Text("Pasos");
                        header.Cell().Element(HeaderStyle).AlignRight().Text("Comentarios");
                        header.Cell().Element(HeaderStyle).AlignRight().Text("Rating Pond.");
                    });

                    foreach (var item in data.OrderByDescending(x => x.WeightedAverageRating).ThenByDescending(x => x.CommentCount))
                    {
                        table.Cell().Element(CellStyle).Text(item.RecipeName);
                        table.Cell().Element(CellStyle).Text(item.AuthorName);
                        table.Cell().Element(CellStyle).AlignRight().Text(item.StepCount.ToString());
                        table.Cell().Element(CellStyle).AlignRight().Text(item.CommentCount.ToString());
                        table.Cell().Element(CellStyle).AlignRight().Text(item.WeightedAverageRating.ToString("N2"));
                    }
                });
            });
        }

        #endregion

        #region Category Performance Report

        public byte[] GenerateCategoryPerformanceReport(IEnumerable<CategoryPerformanceDto> data)
        {
            var dataList = data.ToList();
            if (!dataList.Any(d => d.RecipeCount > 0))
            {
                return GenerateEmptyReport("Reporte de Rendimiento por Categoría", "No hay datos suficientes para generar el reporte.");
            }

            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.Header().Element(c => Header(c, "Reporte de Rendimiento por Categoría"));
                    page.Content().Element(content => CategoryPerformanceContent(content, dataList));
                    page.Footer().Element(Footer);
                });
            }).GeneratePdf();
        }

        private void CategoryPerformanceContent(IContainer container, List<CategoryPerformanceDto> data)
        {
            container.PaddingVertical(1, Unit.Centimetre).Column(column =>
            {
                column.Item().Text("Métricas Detalladas por Categoría").Bold().FontSize(16);
                column.Item().PaddingTop(20).Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(3);
                        columns.RelativeColumn(1.5f);
                        columns.RelativeColumn(1.5f);
                        columns.RelativeColumn(1.5f);
                        columns.RelativeColumn(1.5f);
                    });

                    table.Header(header =>
                    {
                        header.Cell().Element(HeaderStyle).Text("Categoría");
                        header.Cell().Element(HeaderStyle).AlignRight().Text("Nº Recetas");
                        header.Cell().Element(HeaderStyle).AlignRight().Text("Rating Medio");
                        header.Cell().Element(HeaderStyle).AlignRight().Text("Total Votos");
                        header.Cell().Element(HeaderStyle).AlignRight().Text("Total Coment.");
                    });

                    foreach (var item in data.OrderByDescending(d => d.RecipeCount))
                    {
                        table.Cell().Element(CellStyle).Text(item.CategoryName);
                        table.Cell().Element(CellStyle).AlignRight().Text(item.RecipeCount.ToString());
                        table.Cell().Element(CellStyle).AlignRight().Text(item.AverageRating.ToString("N2"));
                        table.Cell().Element(CellStyle).AlignRight().Text(item.TotalRatings.ToString());
                        table.Cell().Element(CellStyle).AlignRight().Text(item.TotalComments.ToString());
                    }
                });
            });
        }

        #endregion

        #region Shared PDF Elements

        private static IContainer HeaderStyle(IContainer container)
        {
            return container.BorderBottom(1).BorderColor(Colors.Grey.Medium).Padding(5);
        }

        private static IContainer CellStyle(IContainer container)
        {
            // CORRECCIÓN FINAL: La sintaxis correcta es encadenar los métodos.
            return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).Padding(5);
        }

        private void Header(IContainer container, string title)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item().Text(title).SemiBold().FontSize(20).FontColor(Colors.Blue.Medium);
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