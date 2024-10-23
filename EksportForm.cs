using AdmItSystem.Logic;
using AdmItSystem.Models;

namespace AdmItSystem.WinForms
{
    /// <summary>
    /// Form til eksport af boliger.
    /// </summary>
    public partial class EksportForm : Form
    {
        private EksportManager _eksportManager;

        public EksportForm()
        {
            InitializeComponent();
            _eksportManager = new();
        }

        private void btnEksporterBoligerTilSalg_Click(object sender, EventArgs e)
        {
            // Få sorteret liste af boliger til salg
            if (_eksportManager.GetSortedBoligerTilSalg(out List<BoligInfo> sortedBoligerTilSalg))
            {
                // Vis dialog for at få stien til at gemme filen
                if (saveFileDialogPath.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialogPath.FileName;
                    // Eksporter til .csv fil
                    if (_eksportManager.EksporterCsv(sortedBoligerTilSalg, savePath))
                    {
                        MessageBox.Show($"Boliger til salg blev eksporteret til {savePath}");
                    }
                    else
                    {
                        MessageBox.Show($"Boliger til salg blev ikke eksporteret.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Kunne ikke trække sortet liste af boliger til salg fra databasen.");
            }

        }

        private void btnEksporterBoligerFraOmråde_Click(object sender, EventArgs e)
        {
            // Få område
            string område = textBoxOmråde.Text.Trim();
            if (!string.IsNullOrWhiteSpace(område))
            {
                // Find boliger
                if (_eksportManager.GetBoligerFraOmråde(område, out List<BoligInfo> boligerFraOmråde))
                {
                    if (saveFileDialogPath.ShowDialog() == DialogResult.OK)
                    {
                        string savePath = saveFileDialogPath.FileName;

                        // Eksporter
                        if (_eksportManager.EksporterCsv(boligerFraOmråde, savePath, true))
                        {
                            MessageBox.Show($"Boliger fra {område} blev eksporteret til {savePath}");
                        }
                        else
                        {
                            MessageBox.Show($"Boliger fra {område} blev ikke eksporteret.");
                        }

                    }
                }
                else
                {
                    MessageBox.Show($"Boliger fra {område} kunne ikke hentes.");
                }
            }
            else
            {
                MessageBox.Show("Indtast venligst et område.");
            }
        }
    }
}