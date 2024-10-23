using AdmItSystem.Logic;
using AdmItSystem.Models;

namespace AdmItSystem.WinForms
{
    /// <summary>
    /// Form til visning af kunder.
    /// </summary>
    public partial class KundeForm : Form
    {
        private KundeManager _kundeManager;
        private int _afdelingId;

        public KundeForm(int afdelingId)
        {
            InitializeComponent();
            _kundeManager = new KundeManager(); // Opret instans
            _afdelingId = afdelingId;
        }

        private void KundeForm_Load(object sender, EventArgs e)
        {
            LoadKundeInfo();
        }

        private void LoadKundeInfo()
        {
            List<KundeInfo> kunder = _kundeManager.GetKundeInfo(_afdelingId); // Hent kundeinformationer
            kundeBindingSource.DataSource = kunder; // Bind kundeinformationerne til data source
        }

        private void kundeDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            KundeInfo selectedKunde = e.Row.DataBoundItem as KundeInfo; // Få den valgte kunde
            if (selectedKunde != null)
            {
                if (_kundeManager.DeletePerson(selectedKunde.PersonId)) // Slet personen
                {
                    MessageBox.Show("Kunde slettet."); // Vis succesbesked
                }
                else
                {
                    e.Cancel = true; // Annuller sletning
                    MessageBox.Show("Kunde blev ikke slettet."); // Vis fejlbesked
                }
            }
        }

        private void kundeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewKunde.Rows[e.RowIndex];
            KundeInfo selectedKunde = (KundeInfo)row.DataBoundItem;

            using (RedigerKundeForm redigerKundeForm = new(selectedKunde))
            {
                redigerKundeForm.ShowDialog();
            }

            //Genindlæs
            dataGridViewKunde.EndEdit();
            dataGridViewKunde.CurrentCell = null;
            LoadKundeInfo();
        }

        private void kundeDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridViewKunde.Rows[e.RowIndex].IsNewRow) // Den nye række
            {
                dataGridViewKunde.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow; // Skift baggrundsfarven på den nye række
            }
        }
    }
}
