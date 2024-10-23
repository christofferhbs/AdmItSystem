using AdmItSystem.Logic;
using AdmItSystem.Models;

namespace AdmItSystem.WinForms
{
    /// <summary>
    /// Form til visning af medarbejdere.
    /// </summary>
    public partial class MedarbejderForm : Form
    {
        private MedarbejderManager _medarbejderManager;
        private int _afdelingId;

        public MedarbejderForm(int afdelingId)
        {
            InitializeComponent();
            _medarbejderManager = new(); // Opret instans
            _afdelingId = afdelingId;
        }

        private void MedarbejderForm_Load(object sender, EventArgs e)
        {
            LoadMedarbejderInfo();
        }

        /// <summary>
        /// Indlæser medarbejderinfo og binder dem til data source
        /// </summary>
        /// <returns>True hvis ny række oprettet, false hvis ikke</returns>
        private bool LoadMedarbejderInfo()
        {
            // Gem det nuværende antal rækker før dataindlæsning
            int currentRowCount = dataGridViewMedarbejder.Rows.Count;

            // Hent medarbejderinformationer
            List<MedarbejderInfo> medarbejder = _medarbejderManager.GetMedarbejderInfo(_afdelingId);

            // Bind medarbejderinformationerne til data source
            medarbejderBindingSource.DataSource = medarbejder;

            // Kontroller om antallet af rækker er steget efter indlæsningen
            return dataGridViewMedarbejder.Rows.Count > currentRowCount;

        }

        private void dataGridViewMedarbejdere_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            MedarbejderInfo selectedMedarbejder = e.Row.DataBoundItem as MedarbejderInfo; // Få den valgte medarbejder
            if (selectedMedarbejder != null)
            {
                if (_medarbejderManager.DeletePerson(selectedMedarbejder.PersonId)) // Slet personen
                {
                    MessageBox.Show("Medarbejder slettet."); // Vis succesbesked
                }
                else
                {
                    e.Cancel = true; // Annuller sletning
                    MessageBox.Show("Medarbejder blev ikke slettet."); // Vis fejlbesked
                }
            }
        }

        private void dataGridViewMedarbejdere_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMedarbejder.Rows[e.RowIndex]; // Få den valgte række
                MedarbejderInfo selectedMedarbejder = (MedarbejderInfo)row.DataBoundItem; // Få den valgte medarbejder

                using (RedigerMedarbejderForm redigerMedarbejderForm = new(selectedMedarbejder)) // Opret og vis redigeringsform for medarbejder
                {
                    redigerMedarbejderForm.ShowDialog();
                }

                //Genindlæs
                dataGridViewMedarbejder.EndEdit();
                dataGridViewMedarbejder.CurrentCell = null;
                LoadMedarbejderInfo();
            }
        }

        private void dataGridViewMedarbejdere_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridViewMedarbejder.Rows[e.RowIndex].IsNewRow) // Den nye række
            {
                dataGridViewMedarbejder.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow; // Skift baggrundsfarven på den nye række
            }
        }
    }
}
