using AdmItSystem.Logic;
using AdmItSystem.Models;

namespace AdmItSystem.WinForms
{
    public partial class RedigerKundeForm : Form
    {
        private KundeInfo _kundeInfo;
        private KundeManager _kundeManager;
        private bool _isNewKunde;

        /// <summary>
        /// Form til redigering af kundeinfo
        /// </summary>
        public RedigerKundeForm(KundeInfo kundeInfo)
        {
            InitializeComponent();
            _kundeInfo = kundeInfo; //KundeInfo objektet, der skal redigeres. Hvis det er null, så oprettes en ny kunde.
            _kundeManager = new KundeManager();
            _isNewKunde = kundeInfo == null;
            FillKundeData();
        }

        /// <summary>
        /// Udfylder check-, og textboxene med kundeinfo
        /// </summary>
        private void FillKundeData()
        {
            if (_kundeInfo != null)
            {
                textBoxFornavn.Text = _kundeInfo.Fornavn;
                textBoxEfternavn.Text = _kundeInfo.Efternavn;
                textBoxTlfNr.Text = _kundeInfo.Telefonnummer;
                textBoxEmail.Text = _kundeInfo.Emailadresse;

                checkBoxKøber.Checked = _kundeInfo.Rolle == "Køber";
                checkBoxSælger.Checked = _kundeInfo.Rolle == "Sælger";
            }
        }

        private void btnGem_Click(object sender, EventArgs e)
        {
            // Kontroller om krævede felter er udfyldt
            if (string.IsNullOrWhiteSpace(textBoxFornavn.Text) ||
                string.IsNullOrWhiteSpace(textBoxEfternavn.Text) ||
                (!checkBoxKøber.Checked && !checkBoxSælger.Checked))
            {
                MessageBox.Show("Fornavn, efternavn og rolle er påkrævet.", "Fejl", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Opret eller opdater kundeinfo
            KundeInfo kundeInfo = new()
            {
                Fornavn = textBoxFornavn.Text,
                Efternavn = textBoxEfternavn.Text,
                Telefonnummer = textBoxTlfNr.Text,
                Emailadresse = textBoxEmail.Text,
                Rolle = checkBoxKøber.Checked ? "Køber" : "Sælger"
            };

            // Hvis det ikke er en ny bolig, set eksisterende id
            if (!_isNewKunde)
            {
                kundeInfo.PersonId = _kundeInfo.PersonId;
            }

            // Gem boliginfo vha KundeManager
            if (_kundeManager.SaveKunde(kundeInfo, _isNewKunde))
            {
                MessageBox.Show(_isNewKunde ? "Ny kunde oprettet." : "Kunde opdateret.");
                Close();
            }
            else
            {
                MessageBox.Show(_isNewKunde ? "Kunde blev ikke oprettet." : "Kunde blev ikke opdateret.");
            }
        }

        //Håndter ændring af checkboxe til valg af kundetype. Kan kun være en af delene.
        private void checkBoxKøber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKøber.Checked)
            {
                checkBoxSælger.Checked = false;
            }
        }

        private void checkBoxSælger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSælger.Checked)
            {
                checkBoxKøber.Checked = false;
            }
        }
    }
}
