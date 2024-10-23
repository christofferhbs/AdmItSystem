using AdmItSystem.Models;

namespace AdmItSystem.WinForms
{
    partial class KundeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewKunde = new DataGridView();
            personIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fornavnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            efternavnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonnummerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailadresseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kundeBindingSource = new BindingSource(components);
            kundePanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKunde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kundeBindingSource).BeginInit();
            kundePanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewKunde
            // 
            dataGridViewKunde.AllowUserToOrderColumns = true;
            dataGridViewKunde.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewKunde.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewKunde.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewKunde.AutoGenerateColumns = false;
            dataGridViewKunde.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKunde.BackgroundColor = Color.FromArgb(229, 229, 229);
            dataGridViewKunde.BorderStyle = BorderStyle.None;
            dataGridViewKunde.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewKunde.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 69, 115);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(22, 69, 115);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewKunde.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewKunde.ColumnHeadersHeight = 50;
            dataGridViewKunde.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewKunde.Columns.AddRange(new DataGridViewColumn[] { personIdDataGridViewTextBoxColumn, fornavnDataGridViewTextBoxColumn, efternavnDataGridViewTextBoxColumn, telefonnummerDataGridViewTextBoxColumn, emailadresseDataGridViewTextBoxColumn, rolleDataGridViewTextBoxColumn });
            dataGridViewKunde.DataSource = kundeBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(254, 195, 21);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewKunde.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewKunde.EnableHeadersVisualStyles = false;
            dataGridViewKunde.GridColor = Color.FromArgb(22, 69, 115);
            dataGridViewKunde.Location = new Point(0, 0);
            dataGridViewKunde.Name = "dataGridViewKunde";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewKunde.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewKunde.RowHeadersVisible = false;
            dataGridViewKunde.RowHeadersWidth = 62;
            dataGridViewKunde.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewKunde.RowTemplate.DividerHeight = 1;
            dataGridViewKunde.RowTemplate.Height = 50;
            dataGridViewKunde.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKunde.ShowCellToolTips = false;
            dataGridViewKunde.ShowEditingIcon = false;
            dataGridViewKunde.Size = new Size(1024, 729);
            dataGridViewKunde.TabIndex = 2;
            dataGridViewKunde.CellDoubleClick += kundeDataGridView_CellDoubleClick;
            dataGridViewKunde.RowPrePaint += kundeDataGridView_RowPrePaint;
            dataGridViewKunde.UserDeletingRow += kundeDataGridView_UserDeletingRow;
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            personIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            personIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // fornavnDataGridViewTextBoxColumn
            // 
            fornavnDataGridViewTextBoxColumn.DataPropertyName = "Fornavn";
            fornavnDataGridViewTextBoxColumn.HeaderText = "Fornavn";
            fornavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            fornavnDataGridViewTextBoxColumn.Name = "fornavnDataGridViewTextBoxColumn";
            // 
            // efternavnDataGridViewTextBoxColumn
            // 
            efternavnDataGridViewTextBoxColumn.DataPropertyName = "Efternavn";
            efternavnDataGridViewTextBoxColumn.HeaderText = "Efternavn";
            efternavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            efternavnDataGridViewTextBoxColumn.Name = "efternavnDataGridViewTextBoxColumn";
            // 
            // telefonnummerDataGridViewTextBoxColumn
            // 
            telefonnummerDataGridViewTextBoxColumn.DataPropertyName = "Telefonnummer";
            telefonnummerDataGridViewTextBoxColumn.HeaderText = "Telefonnummer";
            telefonnummerDataGridViewTextBoxColumn.MinimumWidth = 8;
            telefonnummerDataGridViewTextBoxColumn.Name = "telefonnummerDataGridViewTextBoxColumn";
            // 
            // emailadresseDataGridViewTextBoxColumn
            // 
            emailadresseDataGridViewTextBoxColumn.DataPropertyName = "Emailadresse";
            emailadresseDataGridViewTextBoxColumn.HeaderText = "Emailadresse";
            emailadresseDataGridViewTextBoxColumn.MinimumWidth = 8;
            emailadresseDataGridViewTextBoxColumn.Name = "emailadresseDataGridViewTextBoxColumn";
            // 
            // rolleDataGridViewTextBoxColumn
            // 
            rolleDataGridViewTextBoxColumn.DataPropertyName = "Rolle";
            rolleDataGridViewTextBoxColumn.HeaderText = "Rolle";
            rolleDataGridViewTextBoxColumn.MinimumWidth = 8;
            rolleDataGridViewTextBoxColumn.Name = "rolleDataGridViewTextBoxColumn";
            // 
            // kundeBindingSource
            // 
            kundeBindingSource.DataSource = typeof(KundeInfo);
            // 
            // kundePanel
            // 
            kundePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kundePanel.Controls.Add(dataGridViewKunde);
            kundePanel.Location = new Point(0, 0);
            kundePanel.Name = "kundePanel";
            kundePanel.Size = new Size(1024, 729);
            kundePanel.TabIndex = 4;
            // 
            // KundeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(1024, 729);
            Controls.Add(kundePanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "KundeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += KundeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewKunde).EndInit();
            ((System.ComponentModel.ISupportInitialize)kundeBindingSource).EndInit();
            kundePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewKunde;
        private Panel kundePanel;
        private BindingSource kundeBindingSource;
        private DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fornavnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn efternavnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonnummerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailadresseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolleDataGridViewTextBoxColumn;
    }
}
