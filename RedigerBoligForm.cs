using AdmItSystem.Logic;
using AdmItSystem.Models;

namespace AdmItSystem.WinForms
{
    /// <summary>
    /// Form til redigering af boliginfo.
    /// </summary>
    public partial class RedigerBoligForm : Form
    {
        private BoligInfo _boligInfo;
        private OversigtManager _oversigtManager;
        private bool _isNewBolig;

        public RedigerBoligForm(BoligInfo boligInfo)
        {
            InitializeComponent();
            _boligInfo = boligInfo; //BoligInfo objektet, der skal redigeres. Hvis det er null, så oprettes en ny bolig.
            _oversigtManager = new OversigtManager();
            _isNewBolig = boligInfo == null;
            FillComboBoxes(); //Fill comboboxes først for at kunne sette selected value
            FillKundeData();
        }

        /// <summary>
        /// Udfylder felterne med boliginfo.
        /// </summary>
        private void FillKundeData()
        {
            if (_boligInfo != null)
            {
                textBoxVejnavn.Text = _boligInfo.Vejnavn;
                textBoxNummer.Text = _boligInfo.Nummer;
                textBoxPostnummer.Text = _boligInfo.Postnummer.ToString();
                textBoxBynavn.Text = _boligInfo.Bynavn;
                textBoxAreal.Text = _boligInfo.Areal.ToString();
                textBoxHandelspris.Text = _boligInfo.Handelspris.ToString();
                dateTimePickerHandelsdato.ShowCheckBox = true;
                if (_boligInfo.Handelsdato.HasValue)
                {
                    dateTimePickerHandelsdato.Checked = true;
                    dateTimePickerHandelsdato.Value = _boligInfo.Handelsdato.Value;
                }
                else
                {
                    dateTimePickerHandelsdato.Checked = false;
                }
                checkBoxTilSalg.Checked = _boligInfo.TilSalg;
                checkBoxHus.Checked = _boligInfo.Boligtype == "Hus";
                checkBoxAndelsbolig.Checked = _boligInfo.Boligtype == "Andelsbolig";
                checkBoxLejlighed.Checked = _boligInfo.Boligtype == "Lejlighed";
                checkBoxRækkehus.Checked = _boligInfo.Boligtype == "Rækkehus";
                comboBoxSælger.SelectedValue = _boligInfo.SælgerId.GetValueOrDefault(-1);
                comboBoxKøber.SelectedValue = _boligInfo.KøberId.GetValueOrDefault(-1);
                comboBoxEjendomsmægler.SelectedValue = _boligInfo.EjendomsmæglerId.GetValueOrDefault(-1);
            }
            else
            {
                dateTimePickerHandelsdato.ShowCheckBox = true;
                dateTimePickerHandelsdato.Checked = false;
            }
        }

        /// <summary>
        /// Tilføjer data til comboboxes.
        /// </summary>
        private void FillComboBoxes()
        {
            // Henter og setter sælgerinfo
            object sælgerInfo = _oversigtManager.GetInfo("Sælger");
            comboBoxSælger.DataSource = sælgerInfo;
            comboBoxSælger.DisplayMember = "Navn";
            comboBoxSælger.ValueMember = "PersonId";
            comboBoxSælger.SelectedIndex = -1;

            // Henter og setter køberinfo
            object køberInfo = _oversigtManager.GetInfo("Køber");
            comboBoxKøber.DisplayMember = "Navn";
            comboBoxKøber.ValueMember = "PersonId";
            comboBoxKøber.DataSource = køberInfo;
            comboBoxKøber.SelectedIndex = -1;

            // Henter og setter ejendomsmæglerinfo
            object ejendomsmæglerInfo = _oversigtManager.GetInfo("Ejendomsmægler");
            comboBoxEjendomsmægler.DisplayMember = "Navn";
            comboBoxEjendomsmægler.ValueMember = "PersonId";
            comboBoxEjendomsmægler.DataSource = ejendomsmæglerInfo;
            comboBoxEjendomsmægler.SelectedIndex = -1;
        }

        private void btnGem_Click(object sender, EventArgs e)
        {
            // Valider om krævede felter er udfyldt
            if (string.IsNullOrWhiteSpace(textBoxVejnavn.Text) ||
                string.IsNullOrWhiteSpace(textBoxNummer.Text) ||
                string.IsNullOrWhiteSpace(textBoxPostnummer.Text) ||
                string.IsNullOrWhiteSpace(textBoxBynavn.Text) ||
                string.IsNullOrWhiteSpace(textBoxAreal.Text) ||
                (!checkBoxAndelsbolig.Checked && !checkBoxHus.Checked
                && !checkBoxLejlighed.Checked && !checkBoxRækkehus.Checked) ||
                string.IsNullOrEmpty(comboBoxSælger.Text) ||
                string.IsNullOrEmpty(comboBoxEjendomsmægler.Text))
            {
                MessageBox.Show("Vej, nr., postnr., by, areal, type, sælger, og ejendomsmægler er påkrævet.", "Fejl", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //TODO: Validering af felter!
            //Fill BoligInfo objekt med data fra felterne
            BoligInfo boligInfo = new()
            {
                Vejnavn = textBoxVejnavn.Text,
                Nummer = textBoxNummer.Text,
                Postnummer = int.TryParse(textBoxPostnummer.Text, out int postnummer) ? postnummer : 0,
                Bynavn = textBoxBynavn.Text,
                Areal = double.TryParse(textBoxAreal.Text, out double areal) ? areal : 0,
                Handelspris = double.TryParse(textBoxHandelspris.Text, out double handelspris) ? handelspris : (double?)null,
                Handelsdato = dateTimePickerHandelsdato.Checked ? dateTimePickerHandelsdato.Value : (DateTime?)null,
                TilSalg = checkBoxTilSalg.Checked,
                Boligtype = checkBoxHus.Checked ? "Hus" :
                    checkBoxLejlighed.Checked ? "Lejlighed" :
                    checkBoxRækkehus.Checked ? "Rækkehus" :
                    checkBoxAndelsbolig.Checked ? "Andelsbolig" : "",
                SælgerId = (int?)comboBoxSælger.SelectedValue,
                KøberId = (int?)comboBoxKøber.SelectedValue,
                EjendomsmæglerId = (int?)comboBoxEjendomsmægler.SelectedValue
            };

            // Hvis det ikke er en ny bolig, set eksisterende id
            if (!_isNewBolig)
            {
                boligInfo.BoligId = _boligInfo.BoligId;
            }

            // Gem boliginfo vha OversigtManager
            if (_oversigtManager.SaveBolig(boligInfo, _isNewBolig))
            {
                MessageBox.Show(_isNewBolig ? "Ny bolig oprettet." : "Bolig opdateret.");
                Close();
            }
            else
            {
                MessageBox.Show(_isNewBolig ? "Bolig blev ikke oprettet." : "Bolig blev ikke opdateret.");
            }
        }

        //Håndter ændring af checkboxe til valg af boligtype.
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == checkBoxHus && checkBoxHus.Checked)
            {
                checkBoxAndelsbolig.Checked = false;
                checkBoxLejlighed.Checked = false;
                checkBoxRækkehus.Checked = false;
            }

            if (sender == checkBoxAndelsbolig && checkBoxAndelsbolig.Checked)
            {
                checkBoxHus.Checked = false;
                checkBoxLejlighed.Checked = false;
                checkBoxRækkehus.Checked = false;
            }

            if (sender == checkBoxLejlighed && checkBoxLejlighed.Checked)
            {
                checkBoxHus.Checked = false;
                checkBoxAndelsbolig.Checked = false;
                checkBoxRækkehus.Checked = false;
            }

            if (sender == checkBoxRækkehus && checkBoxRækkehus.Checked)
            {
                checkBoxHus.Checked = false;
                checkBoxAndelsbolig.Checked = false;
                checkBoxLejlighed.Checked = false;
            }
        }
    }
}