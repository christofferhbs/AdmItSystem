namespace AdmItSystem.WinForms
{
    partial class AfdelingForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dataGridViewAfdeling = new DataGridView();
            afdelingsnavnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            afdelingBindingSource = new BindingSource(components);
            afdelingPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAfdeling).BeginInit();
            ((System.ComponentModel.ISupportInitialize)afdelingBindingSource).BeginInit();
            afdelingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAfdeling
            // 
            dataGridViewAfdeling.AllowUserToOrderColumns = true;
            dataGridViewAfdeling.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewAfdeling.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewAfdeling.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAfdeling.AutoGenerateColumns = false;
            dataGridViewAfdeling.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAfdeling.BackgroundColor = Color.FromArgb(229, 229, 229);
            dataGridViewAfdeling.BorderStyle = BorderStyle.None;
            dataGridViewAfdeling.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewAfdeling.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(22, 69, 115);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(22, 69, 115);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewAfdeling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewAfdeling.ColumnHeadersHeight = 50;
            dataGridViewAfdeling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewAfdeling.Columns.AddRange(new DataGridViewColumn[] { afdelingsnavnDataGridViewTextBoxColumn });
            dataGridViewAfdeling.DataSource = afdelingBindingSource;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(254, 195, 21);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewAfdeling.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewAfdeling.EnableHeadersVisualStyles = false;
            dataGridViewAfdeling.GridColor = Color.FromArgb(22, 69, 115);
            dataGridViewAfdeling.Location = new Point(0, 0);
            dataGridViewAfdeling.Name = "dataGridViewAfdeling";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewAfdeling.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewAfdeling.RowHeadersVisible = false;
            dataGridViewAfdeling.RowHeadersWidth = 62;
            dataGridViewAfdeling.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewAfdeling.RowTemplate.DividerHeight = 1;
            dataGridViewAfdeling.RowTemplate.Height = 50;
            dataGridViewAfdeling.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAfdeling.ShowCellToolTips = false;
            dataGridViewAfdeling.ShowEditingIcon = false;
            dataGridViewAfdeling.Size = new Size(1024, 729);
            dataGridViewAfdeling.TabIndex = 2;
            dataGridViewAfdeling.CellDoubleClick += dataGridViewAfdeling_CellDoubleClick;
            dataGridViewAfdeling.CellEndEdit += dataGridViewAfdeling_CellEndEdit;
            dataGridViewAfdeling.RowPrePaint += dataGridViewAfdeling_RowPrePaint;
            dataGridViewAfdeling.UserDeletingRow += afdelingDataGridView_UserDeletingRow;
            // 
            // afdelingsnavnDataGridViewTextBoxColumn
            // 
            afdelingsnavnDataGridViewTextBoxColumn.DataPropertyName = "Afdelingsnavn";
            afdelingsnavnDataGridViewTextBoxColumn.HeaderText = "Afdelingsnavn";
            afdelingsnavnDataGridViewTextBoxColumn.MinimumWidth = 6;
            afdelingsnavnDataGridViewTextBoxColumn.Name = "afdelingsnavnDataGridViewTextBoxColumn";
            // 
            // afdelingBindingSource
            // 
            afdelingBindingSource.DataSource = typeof(Models.Afdeling);
            // 
            // afdelingPanel
            // 
            afdelingPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            afdelingPanel.Controls.Add(dataGridViewAfdeling);
            afdelingPanel.Location = new Point(0, 0);
            afdelingPanel.Name = "afdelingPanel";
            afdelingPanel.Size = new Size(1024, 729);
            afdelingPanel.TabIndex = 4;
            // 
            // AfdelingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(1024, 729);
            Controls.Add(afdelingPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AfdelingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AfdelingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAfdeling).EndInit();
            ((System.ComponentModel.ISupportInitialize)afdelingBindingSource).EndInit();
            afdelingPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewAfdeling;
        private Panel afdelingPanel;
        private DataGridViewTextBoxColumn afdelingsnavnDataGridViewTextBoxColumn;
        private BindingSource afdelingBindingSource;
    }
}
