using AdmItSystem.Models;

namespace AdmItSystem.WinForms
{
    partial class MedarbejderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewMedarbejder = new DataGridView();
            medarbejderBindingSource = new BindingSource(components);
            medarbejderPanel = new Panel();
            personIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fornavnDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            efternavnDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            telefonIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonnummerDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            emailIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailadresseDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            afdelingIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolleDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            afdelingsnavnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedarbejder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)medarbejderBindingSource).BeginInit();
            medarbejderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMedarbejder
            // 
            dataGridViewMedarbejder.AllowUserToOrderColumns = true;
            dataGridViewMedarbejder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewMedarbejder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMedarbejder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMedarbejder.AutoGenerateColumns = false;
            dataGridViewMedarbejder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMedarbejder.BackgroundColor = Color.FromArgb(229, 229, 229);
            dataGridViewMedarbejder.BorderStyle = BorderStyle.None;
            dataGridViewMedarbejder.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewMedarbejder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 69, 115);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(22, 69, 115);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewMedarbejder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMedarbejder.ColumnHeadersHeight = 50;
            dataGridViewMedarbejder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMedarbejder.Columns.AddRange(new DataGridViewColumn[] { personIdDataGridViewTextBoxColumn1, fornavnDataGridViewTextBoxColumn1, efternavnDataGridViewTextBoxColumn1, telefonIdDataGridViewTextBoxColumn, telefonnummerDataGridViewTextBoxColumn1, emailIdDataGridViewTextBoxColumn, emailadresseDataGridViewTextBoxColumn1, afdelingIdDataGridViewTextBoxColumn, rolleDataGridViewTextBoxColumn1, afdelingsnavnDataGridViewTextBoxColumn });
            dataGridViewMedarbejder.DataSource = medarbejderBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(254, 195, 21);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewMedarbejder.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMedarbejder.EnableHeadersVisualStyles = false;
            dataGridViewMedarbejder.GridColor = Color.FromArgb(22, 69, 115);
            dataGridViewMedarbejder.Location = new Point(0, 0);
            dataGridViewMedarbejder.Name = "dataGridViewMedarbejder";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewMedarbejder.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewMedarbejder.RowHeadersVisible = false;
            dataGridViewMedarbejder.RowHeadersWidth = 62;
            dataGridViewMedarbejder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewMedarbejder.RowTemplate.DividerHeight = 1;
            dataGridViewMedarbejder.RowTemplate.Height = 50;
            dataGridViewMedarbejder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMedarbejder.ShowCellToolTips = false;
            dataGridViewMedarbejder.ShowEditingIcon = false;
            dataGridViewMedarbejder.Size = new Size(1024, 729);
            dataGridViewMedarbejder.TabIndex = 2;
            dataGridViewMedarbejder.CellDoubleClick += dataGridViewMedarbejdere_CellDoubleClick;
            dataGridViewMedarbejder.RowPrePaint += dataGridViewMedarbejdere_RowPrePaint;
            dataGridViewMedarbejder.UserDeletingRow += dataGridViewMedarbejdere_UserDeletingRow;
            // 
            // medarbejderBindingSource
            // 
            medarbejderBindingSource.DataSource = typeof(MedarbejderInfo);
            // 
            // medarbejderPanel
            // 
            medarbejderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            medarbejderPanel.Controls.Add(dataGridViewMedarbejder);
            medarbejderPanel.Location = new Point(0, 0);
            medarbejderPanel.Name = "medarbejderPanel";
            medarbejderPanel.Size = new Size(1024, 729);
            medarbejderPanel.TabIndex = 4;
            // 
            // personIdDataGridViewTextBoxColumn1
            // 
            personIdDataGridViewTextBoxColumn1.DataPropertyName = "PersonId";
            personIdDataGridViewTextBoxColumn1.HeaderText = "PersonId";
            personIdDataGridViewTextBoxColumn1.MinimumWidth = 8;
            personIdDataGridViewTextBoxColumn1.Name = "personIdDataGridViewTextBoxColumn1";
            personIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // fornavnDataGridViewTextBoxColumn1
            // 
            fornavnDataGridViewTextBoxColumn1.DataPropertyName = "Fornavn";
            fornavnDataGridViewTextBoxColumn1.HeaderText = "Fornavn";
            fornavnDataGridViewTextBoxColumn1.MinimumWidth = 8;
            fornavnDataGridViewTextBoxColumn1.Name = "fornavnDataGridViewTextBoxColumn1";
            // 
            // efternavnDataGridViewTextBoxColumn1
            // 
            efternavnDataGridViewTextBoxColumn1.DataPropertyName = "Efternavn";
            efternavnDataGridViewTextBoxColumn1.HeaderText = "Efternavn";
            efternavnDataGridViewTextBoxColumn1.MinimumWidth = 8;
            efternavnDataGridViewTextBoxColumn1.Name = "efternavnDataGridViewTextBoxColumn1";
            // 
            // telefonIdDataGridViewTextBoxColumn
            // 
            telefonIdDataGridViewTextBoxColumn.DataPropertyName = "TelefonId";
            telefonIdDataGridViewTextBoxColumn.HeaderText = "TelefonId";
            telefonIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            telefonIdDataGridViewTextBoxColumn.Name = "telefonIdDataGridViewTextBoxColumn";
            telefonIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefonnummerDataGridViewTextBoxColumn1
            // 
            telefonnummerDataGridViewTextBoxColumn1.DataPropertyName = "Telefonnummer";
            telefonnummerDataGridViewTextBoxColumn1.HeaderText = "Telefonnummer";
            telefonnummerDataGridViewTextBoxColumn1.MinimumWidth = 8;
            telefonnummerDataGridViewTextBoxColumn1.Name = "telefonnummerDataGridViewTextBoxColumn1";
            // 
            // emailIdDataGridViewTextBoxColumn
            // 
            emailIdDataGridViewTextBoxColumn.DataPropertyName = "EmailId";
            emailIdDataGridViewTextBoxColumn.HeaderText = "EmailId";
            emailIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            emailIdDataGridViewTextBoxColumn.Name = "emailIdDataGridViewTextBoxColumn";
            emailIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailadresseDataGridViewTextBoxColumn1
            // 
            emailadresseDataGridViewTextBoxColumn1.DataPropertyName = "Emailadresse";
            emailadresseDataGridViewTextBoxColumn1.HeaderText = "Emailadresse";
            emailadresseDataGridViewTextBoxColumn1.MinimumWidth = 8;
            emailadresseDataGridViewTextBoxColumn1.Name = "emailadresseDataGridViewTextBoxColumn1";
            // 
            // afdelingIdDataGridViewTextBoxColumn
            // 
            afdelingIdDataGridViewTextBoxColumn.DataPropertyName = "AfdelingId";
            afdelingIdDataGridViewTextBoxColumn.HeaderText = "AfdelingId";
            afdelingIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            afdelingIdDataGridViewTextBoxColumn.Name = "afdelingIdDataGridViewTextBoxColumn";
            afdelingIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // rolleDataGridViewTextBoxColumn1
            // 
            rolleDataGridViewTextBoxColumn1.DataPropertyName = "Rolle";
            rolleDataGridViewTextBoxColumn1.HeaderText = "Rolle";
            rolleDataGridViewTextBoxColumn1.MinimumWidth = 8;
            rolleDataGridViewTextBoxColumn1.Name = "rolleDataGridViewTextBoxColumn1";
            // 
            // afdelingsnavnDataGridViewTextBoxColumn
            // 
            afdelingsnavnDataGridViewTextBoxColumn.DataPropertyName = "Afdelingsnavn";
            afdelingsnavnDataGridViewTextBoxColumn.HeaderText = "Afdelingsnavn";
            afdelingsnavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            afdelingsnavnDataGridViewTextBoxColumn.Name = "afdelingsnavnDataGridViewTextBoxColumn";
            // 
            // MedarbejderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(1024, 729);
            Controls.Add(medarbejderPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MedarbejderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MedarbejderForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedarbejder).EndInit();
            ((System.ComponentModel.ISupportInitialize)medarbejderBindingSource).EndInit();
            medarbejderPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel medarbejderPanel;
        private System.Windows.Forms.DataGridView dataGridViewMedarbejder;
        private System.Windows.Forms.BindingSource medarbejderBindingSource;
        private DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fornavnDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn efternavnDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn telefonIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonnummerDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn emailIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailadresseDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn afdelingIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolleDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn afdelingsnavnDataGridViewTextBoxColumn;
    }
}
