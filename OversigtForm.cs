using AdmItSystem.Logic;
using AdmItSystem.Models;

namespace AdmItSystem.WinForms
{
    /// <summary>
    /// Form til visning af oversigt over boliginfo.
    /// </summary>
    public partial class OversigtForm : Form
    {
        private OversigtManager _oversigtManager;
        int _selectedAfdelingId;

        public OversigtForm(int selectedAfdelingId)
        {
            InitializeComponent();
            _oversigtManager = new();
            _selectedAfdelingId = selectedAfdelingId;
        }

        private void OversigtForm_Load(object sender, EventArgs e)
        {
            LoadBoligInfo(_selectedAfdelingId); // Indlæs boliginfo

        }

        /// <summary>
        /// Indlæser boliginfo for den valgte afdeling.
        /// </summary>
        /// <param name="selectedAfdelingId">Den valgte afdelings ID.</param>
        private void LoadBoligInfo(int afdelingId)
        {
            oversigtBindingSource.DataSource = _oversigtManager.TilpasDataGridView(afdelingId); ; // Bind boliginfo til data source
        }

        private void dataGridViewOversigt_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            BoligInfo selectedBolig = e.Row.DataBoundItem as BoligInfo; // Få den valgte bolig
            if (selectedBolig != null)
            {
                if (_oversigtManager.DeleteBolig(selectedBolig.BoligId)) // Slet boligen
                {
                    MessageBox.Show("Bolig slettet."); // Vis succesbesked
                }
                else
                {
                    e.Cancel = true; // Annuller sletning
                    MessageBox.Show("Bolig blev ikke slettet."); // Vis fejlbesked
                }
            }
        }

        private void dataGridViewOversigt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewOversigt.Rows[e.RowIndex];
                BoligInfo selectedBolig = (BoligInfo)row.DataBoundItem;

                // Vis form til redigering af den valgte bolig
                using (RedigerBoligForm redigerBoligForm = new(selectedBolig))
                {
                    redigerBoligForm.ShowDialog();
                }
                //Genindlæs
                dataGridViewOversigt.EndEdit();
                dataGridViewOversigt.CurrentCell = null;
                LoadBoligInfo(_selectedAfdelingId); // Opdater boliginfo efter redigering
            }
        }

        private void dataGridViewOversigt_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridViewOversigt.Rows[e.RowIndex].IsNewRow) // Den nye række
            {
                dataGridViewOversigt.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow; // Skift baggrundsfarven på den nye række
            }
        }

        private void buttonFaldende_Click(object sender, EventArgs e)
        {
            List<BoligInfo> sortedList = _oversigtManager.GetSortedBoligInfo("Handelspris", false);
            oversigtBindingSource.DataSource = sortedList;
        }

        private void btnStigende_Click(object sender, EventArgs e)
        {
            List<BoligInfo> sortedList = _oversigtManager.GetSortedBoligInfo("Handelspris", true);
            oversigtBindingSource.DataSource = sortedList;
        }

        private void buttonAnvend_Click(object sender, EventArgs e)
        {
            bool tilSalg = true;
            if (checkBoxTilSalg.Checked)
            {
                tilSalg = true;
            }
            else if (checkBoxSolgt.Checked)
            {
                tilSalg = false;
            }
            double? minPris = string.IsNullOrWhiteSpace(textBoxMin.Text) ? null : double.Parse(textBoxMin.Text);
            double? maxPris = string.IsNullOrWhiteSpace(textBoxMax.Text) ? null : double.Parse(textBoxMax.Text);

            List<BoligInfo> filterList = _oversigtManager.GetFilteredBoligInfo(tilSalg, minPris, maxPris);
            oversigtBindingSource.DataSource = filterList;
        }

        private void buttonFjern_Click(object sender, EventArgs e)
        {
            LoadBoligInfo(_selectedAfdelingId); // Genindlæs boliginfo uden filtre
        }
    }
}
