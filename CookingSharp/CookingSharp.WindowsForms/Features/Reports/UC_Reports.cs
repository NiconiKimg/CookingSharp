using CookingSharp.Clients;
using System;
using System.IO;
using System.Threading.Tasks;
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

        private async void btnGeneratePopularityReport_Click(object sender, EventArgs e)
        {
            await GenerateReport(async () => await _reportApiClient.GetPopularityReportAsync(),
                                 "Reporte_Popularidad_Recetas",
                                 (Button)sender);
        }

        private async void btnGenerateContributionReport_Click(object sender, EventArgs e)
        {
            await GenerateReport(async () => await _reportApiClient.GetChefContributionReportAsync(),
                                 "Reporte_Contribucion_Chefs",
                                 (Button)sender);
        }

        private async void btnGenerateEngagementReport_Click(object sender, EventArgs e)
        {
            await GenerateReport(async () => await _reportApiClient.GetRecipeEngagementReportAsync(),
                                 "Reporte_Analisis_Engagement",
                                 (Button)sender);
        }

        /// <summary>
        /// Lógica genérica para generar y guardar un reporte, manejando el estado del botón.
        /// </summary>
        private async Task GenerateReport(Func<Task<byte[]?>> apiCall, string reportName, Button button)
        {
            string originalText = button.Text;
            button.Enabled = false;
            button.Text = "Generando...";

            try
            {
                byte[]? pdfBytes = await apiCall();

                if (pdfBytes == null || pdfBytes.Length == 0)
                {
                    MessageBox.Show("No se pudo generar el reporte. Puede que no haya suficientes datos para el análisis.",
                                    "Datos Insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SavePdf(pdfBytes, reportName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error de conexión al generar el reporte: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (!button.IsDisposed)
                {
                    button.Enabled = true;
                    button.Text = originalText;
                }
            }
        }

        /// <summary>
        /// Abre un diálogo para guardar el archivo PDF.
        /// </summary>
        private void SavePdf(byte[] pdfBytes, string reportName)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = $"Guardar {reportName}";
                saveFileDialog.FileName = $"{reportName}_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, pdfBytes);
                        MessageBox.Show($"Reporte guardado exitosamente en:\n{saveFileDialog.FileName}",
                                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"No se pudo guardar el archivo: {ex.Message}",
                                        "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}