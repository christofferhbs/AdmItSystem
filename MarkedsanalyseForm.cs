using AdmItSystem.Logic;
using AdmItSystem.Models;
using System.Diagnostics;

namespace AdmItSystem.WinForms
{
    /// <summary>
    /// Håndterer brugerinteraktionen og viser markededsanalyse.
    /// </summary>
    public partial class MarkedsanalyseForm : Form
    {
        private MarkedsanalyseManager _markedsanalyseManager;

        public MarkedsanalyseForm()
        {
            InitializeComponent();
            _markedsanalyseManager = new MarkedsanalyseManager();
        }

        // Valider input, hent markedsanalyse, og vis data
        private void btnHentMarkedsanalyse_Click(object sender, EventArgs e)
        {
            if (ValiderInput(out int postnummer, out double areal, out string boligtype))
            {
                try
                {
                    // Hent markedsanalyseinfo alt efter hvad, brugeren har inputtet.
                    MarkedsanalyseInfo markedsanalyseInfo = _markedsanalyseManager.GetMarkedsanalyse(postnummer, areal, boligtype);

                    // Hvis der er nogen sammenlignelige boliger i listen: vis gennemsnitsprisen, og bind info til view
                    if (markedsanalyseInfo.SammenligneligeBoliger.Any())
                    {
                        labelKvadratmeterpris.Text = $"Gennemsnitlig pris: {markedsanalyseInfo.Kvadratmeterpris} kr./m2";
                        markedsanalyseBindingSource.DataSource = markedsanalyseInfo.SammenligneligeBoliger;
                    }
                    else
                    {
                        labelKvadratmeterpris.Text = "Ingen sammenlignelige boliger fundet.";
                    }
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);
                    MessageBox.Show($"Markedsanalyse kunne ikke oprettes: {exception.Message}", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Validerer inputfelterne og konverterer dem til de korrekte typer. Fejlmeddelelse vises, hvis nogle af valideringerne fejler.
        /// </summary>
        /// <param name="postnummer">Outputter det validerede postnummer</param>
        /// <param name="areal">Outputter det validerede areal.</param>
        /// <param name="boligtype">Outputter den validerede boligtype</param>
        /// <returns>True hvis alle input er gyldige, ellers false</returns>
        private bool ValiderInput(out int postnummer, out double areal, out string boligtype)
        {
            postnummer = 0;
            areal = 0;
            boligtype = string.Empty;

            if (string.IsNullOrEmpty(textBoxPostnummer.Text) ||
                string.IsNullOrEmpty(textBoxAreal.Text) ||
                string.IsNullOrEmpty(comboBoxBoligtype.Text))
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(textBoxPostnummer.Text, out postnummer))
            {
                MessageBox.Show("Postnummer skal være et tal.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(textBoxAreal.Text, out areal))
            {
                MessageBox.Show("Areal skal være et tal.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            boligtype = comboBoxBoligtype.SelectedItem.ToString();
            return true;
        }
    }
}