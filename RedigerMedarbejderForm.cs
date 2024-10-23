using AdmItSystem.Logic;
using AdmItSystem.Models;

namespace AdmItSystem.WinForms
{
    /// <summary>
    /// Form til redigering af medarbejderinfo
    /// </summary>
    public partial class RedigerMedarbejderForm : Form
    {
        private MedarbejderInfo _medarbejderInfo;
        private MedarbejderManager _medarbejderManager;
        private bool _isNewMedarbejder;

        public RedigerMedarbejderForm(MedarbejderInfo medarbejderInfo)
        {
            InitializeComponent();
            _medarbejderInfo = medarbejderInfo; //MedarbejderInfo objektet, der skal redigeres. Hvis det er null, så oprettes en ny medarbejder.
            _medarbejderManager = new MedarbejderManager();
            _isNewMedarbejder = medarbejderInfo == null;
            FillComboBox();
            FillMedarbejderData();
        }

        /// <summary>
        /// Udfylder felterne med medarbejderinfo.
        /// </summary>
        private void FillMedarbejderData()
        {
            if (_medarbejderInfo != null)
            {
                // Udfyld tekstfelterne med eksisterende medarbejderinfo
                textBoxFornavn.Text = _medarbejderInfo.Fornavn;
                textBoxEfternavn.Text = _medarbejderInfo.Efternavn;
                textBoxTlfNr.Text = _medarbejderInfo.Telefonnummer;
                textBoxEmail.Text = _medarbejderInfo.Emailadresse;
                comboBoxAfdeling.Text = _medarbejderInfo.Afdelingsnavn;

                checkBoxEjendomsmægler.Checked = _medarbejderInfo.Rolle == "Ejendomsmægler";
            }
        }

        /// <summary>
        /// Udfylder comboboxAfdeling med alle afdelinger.
        /// </summary>
        private void FillComboBox()
        {
            List<Afdeling> afdelinger = _medarbejderManager.GetAllAfdelinger();
            comboBoxAfdeling.DisplayMember = "Afdelingsnavn";
            comboBoxAfdeling.ValueMember = "AfdelingId";
            comboBoxAfdeling.DataSource = afdelinger;
        }

        private void btnGem_Click(object sender, EventArgs e)
        {
            // Kontroller om de krævede felter er udfyldt
            if (string.IsNullOrWhiteSpace(textBoxFornavn.Text) ||
                string.IsNullOrWhiteSpace(textBoxEfternavn.Text) ||
                (!checkBoxEjendomsmægler.Checked))
            {
                MessageBox.Show("Fornavn, efternavn, rolle og afdeling er påkrævet.", "Fejl", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Opret et nyt MedarbejderInfo objekt med værdierne fra felterne
            MedarbejderInfo medarbejderInfo = new()
            {
                Fornavn = textBoxFornavn.Text,
                Efternavn = textBoxEfternavn.Text,
                Telefonnummer = textBoxTlfNr.Text,
                Emailadresse = textBoxEmail.Text,
                Rolle = checkBoxEjendomsmægler.Checked ? "Ejendomsmægler" : "",
                AfdelingId = (int)comboBoxAfdeling.SelectedValue
            };

            // Hvis det ikke er en ny medarbejder: set PersonId til det allerede eksisterende id
            if (!_isNewMedarbejder)
            {
                medarbejderInfo.PersonId = this._medarbejderInfo.PersonId;
            }

            // Gem medarbejderinfo vha MedarbejderManager
            if (_medarbejderManager.SaveMedarbejder(medarbejderInfo, _isNewMedarbejder))
            {
                MessageBox.Show(_isNewMedarbejder ? "Ny medarbejder oprettet." : "Medarbejder opdateret.");
                Close();
            }
            else
            {
                MessageBox.Show(_isNewMedarbejder ? "Medarbejder blev ikke oprettet." : "Medarbejder blev ikke opdateret.");
            }
        }
    }
}
