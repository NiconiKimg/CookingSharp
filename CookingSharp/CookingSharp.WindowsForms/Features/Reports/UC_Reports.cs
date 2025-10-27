using CookingSharp.Clients;
using System;
using System.IO;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms.Features.Reports
{
    /// <summary>
    /// User Control que actúa como panel principal para la sección de generación de reportes.
    /// </summary>
    public partial class UC_Reports : UserControl
    {
        private readonly ReportApiClient _reportApiClient;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UC_Reports"/>.
        /// </summary>
        /// <param name="reportApiClient">El cliente API para generar los reportes.</param>
        public UC_Reports(ReportApiClient reportApiClient)
        {
            InitializeComponent();
            _reportApiClient = reportApiClient;
        }

        /// <summary>
        /// Maneja el evento Click del botón para generar el reporte de popularidad de recetas.
        /// </summary>
        private async void btnGeneratePopularityReport_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string originalText = button.Text;
            button.Enabled = false;
            button.Text = "Generando...";

            try
            {
                byte[]? pdfBytes = await _reportApiClient.GetPopularityReportAsync();

                if (pdfBytes == null || pdfBytes.Length == 0)
                {
                    MessageBox.Show("No se pudo generar el reporte. Puede que no haya suficientes datos (se requiere un mínimo de recetas con valoraciones).",
                                    "Datos Insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SavePdf(pdfBytes, "Reporte_Popularidad_Recetas");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error de conexión al generar el reporte: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                button.Enabled = true;
                button.Text = originalText;
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón para generar el reporte de contribución de chefs.
        /// </summary>
        private async void btnGenerateContributionReport_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string originalText = button.Text;
            button.Enabled = false;
            button.Text = "Generando...";

            try
            {
                byte[]? pdfBytes = await _reportApiClient.GetChefContributionReportAsync();

                if (pdfBytes == null || pdfBytes.Length == 0)
                {
                    MessageBox.Show("No se pudo generar el reporte. Asegúrese de que existan usuarios con el rol de 'Chef' y que hayan publicado recetas.",
                                    "Datos Insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SavePdf(pdfBytes, "Reporte_Contribucion_Chefs");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error de conexión al generar el reporte: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                button.Enabled = true;
                button.Text = originalText;
            }
        }

        /// <summary>
        /// Abre un diálogo para guardar el archivo PDF.
        /// </summary>
        /// <param name="pdfBytes">Los bytes del archivo PDF.</param>
        /// <param name="reportName">El nombre base para el archivo.</param>
        private void SavePdf(byte[] pdfBytes, string reportName)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = $"Guardar {reportName}";
                saveFileDialog.FileName = $"{reportName}_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, pdfBytes);
                    MessageBox.Show($"Reporte guardado exitosamente en:\n{saveFileDialog.FileName}",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}