using AdmItSystem.Logic;
using AdmItSystem.Models;

namespace AdmItSystem.WinForms
{
    /// <summary>
    /// Form til håndtering af visningen på dashboardet.
    /// </summary>
    public partial class DashboardForm : Form
    {
        private DashboardManager _dashboardManager;
        private Form _oversigtForm;
        private Form _afdelingForm;
        private Form _medarbejderForm;
        private Form _eksportForm;
        private Form _markedsanalyseForm;
        private Form _kundeForm;


        public DashboardForm()
        {
            InitializeComponent();
            _dashboardManager = new();
            _afdelingForm = new AfdelingForm() { TopLevel = false, TopMost = true };
            _eksportForm = new EksportForm() { TopLevel = false, TopMost = true };
            _markedsanalyseForm = new MarkedsanalyseForm() { TopLevel = false, TopMost = true };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillComboBoxAfdeling();
        }

        //Håndter ændring af valgt værdi i comboBoxAfdeling.
        private void comboBoxAfdeling_SelectedValueChanged(object sender, EventArgs e)
        {
            var value = comboBoxAfdeling.SelectedValue as int?; // ValueMember værdien er af typen Afdeling - type cast til nullable int
            if (value != null)
            {
                int selectedAfdelingId = value.Value;
                LoadFormsWithAfdeling(selectedAfdelingId);
            }
        }

        /// <summary>
        /// Tilføjer alle forms, der skal være på dashboard, til panel
        /// </summary>
        private void LoadDashboardForms()
        {
            dashboardPanel.Controls.Add(_oversigtForm);
            _oversigtForm.Dock = DockStyle.Fill;

            dashboardPanel.Controls.Add(_markedsanalyseForm);
            _markedsanalyseForm.Dock = DockStyle.Fill;

            dashboardPanel.Controls.Add(_eksportForm);
            _eksportForm.Dock = DockStyle.Fill;

            dashboardPanel.Controls.Add(_afdelingForm);
            _afdelingForm.Dock = DockStyle.Fill;

            dashboardPanel.Controls.Add(_medarbejderForm);
            _medarbejderForm.Dock = DockStyle.Fill;

            dashboardPanel.Controls.Add(_kundeForm);
            _kundeForm.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Fylder <see cref="comboBoxAfdeling"/> med de eksisterende afdelingsnavne, og tildeler ValueMember property AfdelingId som værdi.
        /// </summary>
        private void FillComboBoxAfdeling()
        {
            List<Afdeling> afdelinger = _dashboardManager.GetAfdelinger();
            comboBoxAfdeling.DataSource = afdelinger;
            comboBoxAfdeling.DisplayMember = "Afdelingsnavn";
            comboBoxAfdeling.ValueMember = "AfdelingId";
        }

        /// <summary>
        /// Opretter instans af forms med den valgte afdeling.
        /// </summary>
        private void LoadFormsWithAfdeling(int afdelingId)
        {
            _oversigtForm = new OversigtForm(afdelingId) { TopLevel = false, TopMost = true };
            _medarbejderForm = new MedarbejderForm(afdelingId) { TopLevel = false, TopMost = true };
            _kundeForm = new KundeForm(afdelingId) { TopLevel = false, TopMost = true };

            dashboardPanel.Controls.Clear(); // Ryd dashboardpanelet, så nytildelte forms kan vises

            // Skift knappernes farver i navigationspanelet
            List<Button> btns = navPanel.Controls.OfType<Button>().ToList();
            btns.ForEach(button => button.BackColor = Color.FromArgb(22, 69, 115)); //blå
            btns.ForEach(button => button.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255));
            LoadDashboardForms();
        }

        /// <summary>
        /// Setter farverne på knapperne i navigationspanelet.
        /// </summary>
        private void SetBtnColors(Button activeBtn)
        {
            activeBtn.BackColor = Color.FromArgb(254, 195, 21); //gul
            activeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 195, 21); //gul
            List<Button> inactiveBtns = navPanel.Controls.OfType<Button>().ToList();
            inactiveBtns.Remove(activeBtn);
            inactiveBtns.ForEach(button => button.BackColor = Color.FromArgb(22, 69, 115)); //blå
            inactiveBtns.ForEach(button => button.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255)); //lyseblå
        }

        /// <summary>
        /// Setter synligheden af formularerne i dashboardet.
        /// </summary>
        private void SetFormVisibility(Form activeForm)
        {
            List<Form> inactiveForms = dashboardPanel.Controls.OfType<Form>().ToList();
            inactiveForms.ForEach(form => form.Hide());
            activeForm.Show();
        }

        private void btnOversigt_Click(object sender, EventArgs e)
        {
            SetFormVisibility(_oversigtForm);
            SetBtnColors(btnOversigt);
        }

        private void btnMarkedsanalyse_Click(object sender, EventArgs e)
        {
            SetFormVisibility(_markedsanalyseForm);
            SetBtnColors(btnMarkedsanalyse);
        }

        private void btnEksport_Click(object sender, EventArgs e)
        {
            SetFormVisibility(_eksportForm);
            SetBtnColors(btnEksport);
        }

        private void btnAfdelinger_Click(object sender, EventArgs e)
        {
            SetFormVisibility(_afdelingForm);
            SetBtnColors(btnAfdelinger);
        }

        private void btnMedarbejdere_Click(object sender, EventArgs e)
        {
            SetFormVisibility(_medarbejderForm);
            SetBtnColors(btnMedarbejdere);
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            SetFormVisibility(_kundeForm);
            SetBtnColors(btnKunder);
        }
    }
}
