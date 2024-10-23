using AdmItSystem.Logic;
using AdmItSystem.Models;

namespace AdmItSystem.WinForms
{
    /// <summary>
    /// Form til visning af afdelinger.
    /// </summary>
    public partial class AfdelingForm : Form
    {
        private AfdelingManager _afdelingManager;

        public AfdelingForm()
        {
            InitializeComponent();
            _afdelingManager = new();
        }

        private void AfdelingForm_Load(object sender, EventArgs e)
        {
            LoadAfdelinger();
        }

        /// <summary>
        /// Indlæser afdelinger i DataGridView
        /// </summary>
        private void LoadAfdelinger()
        {
            // Hent alle afdelinger fra AfdelingManager og bind dem til DataGridView
            List<Afdeling> afdelinger = _afdelingManager.GetAllAfdelinger();
            afdelingBindingSource.DataSource = afdelinger;
        }

        private void dataGridViewAfdeling_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tillad ikke redigering af cellen med navnet på kolonne.
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridViewAfdeling.BeginEdit(true);
            }
        }

        private void dataGridViewAfdeling_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Få den valgte celle og dens data
            DataGridViewRow row = dataGridViewAfdeling.Rows[e.RowIndex];
            Afdeling updatedAfdeling = row.DataBoundItem as Afdeling;

            if (updatedAfdeling != null)
            {
                if (updatedAfdeling.AfdelingId == 0)
                {
                    if (_afdelingManager.CreateAfdeling(updatedAfdeling))
                    {
                        MessageBox.Show("Ny afdeling oprettet.");
                        LoadAfdelinger();
                    }
                    else
                    {
                        MessageBox.Show("Afdeling kunne ikke oprettes.");
                    }
                }
                else
                {
                    if (_afdelingManager.UpdateAfdeling(updatedAfdeling))
                    {
                        MessageBox.Show("Afdeling blev opdateret.");
                    }
                    else
                    {
                        MessageBox.Show("Afdeling kunne ikke opdateres.");
                    }
                }
            }
        }

        private void afdelingDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // Tillad ikke sletning af cellen med navnet på kolonne.
            if (e.Row.Index >= 0)
            {
                // Få den valgte celle og dens data
                Afdeling selectedAfdeling = e.Row.DataBoundItem as Afdeling;
                if (selectedAfdeling != null)
                {
                    if (_afdelingManager.DeleteAfdeling(selectedAfdeling.AfdelingId))
                    {
                        MessageBox.Show("Afdeling blev slettet.");
                    }
                    else
                    {
                        e.Cancel = true;
                        MessageBox.Show("Afdeling kunne ikke slettes.");
                    }
                }
            }
        }

        private void dataGridViewAfdeling_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //Giv den nye række en anden farve
            if (dataGridViewAfdeling.Rows[e.RowIndex].IsNewRow)
            {
                dataGridViewAfdeling.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }
    }
}
