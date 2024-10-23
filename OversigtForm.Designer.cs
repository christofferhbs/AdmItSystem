using AdmItSystem.Models;

namespace AdmItSystem.WinForms
{
    partial class OversigtForm
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
            dataGridViewOversigt = new DataGridView();
            oversigtBindingSource = new BindingSource(components);
            oversigtPanel = new Panel();
            controlPanel = new Panel();
            checkBoxSolgt = new CheckBox();
            labelMax = new Label();
            labelMin = new Label();
            buttonFjern = new Button();
            buttonAnvend = new Button();
            textBoxMax = new TextBox();
            textBoxMin = new TextBox();
            labelHandelsprisMinMax = new Label();
            checkBoxTilSalg = new CheckBox();
            buttonFaldende = new Button();
            labelHandelspris = new Label();
            btnStigende = new Button();
            boligIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vejnavnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nummerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            postnummerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bynavnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            arealDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            handelsprisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            handelsdatoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tilSalgDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            boligtypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sælgernavnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            købernavnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ejendomsmæglernavnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Afdelingsnavn = new DataGridViewTextBoxColumn();
            AfdelingId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOversigt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oversigtBindingSource).BeginInit();
            oversigtPanel.SuspendLayout();
            controlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewOversigt
            // 
            dataGridViewOversigt.AllowUserToOrderColumns = true;
            dataGridViewOversigt.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewOversigt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOversigt.AutoGenerateColumns = false;
            dataGridViewOversigt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOversigt.BackgroundColor = Color.FromArgb(229, 229, 229);
            dataGridViewOversigt.BorderStyle = BorderStyle.None;
            dataGridViewOversigt.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewOversigt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 69, 115);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(22, 69, 115);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewOversigt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOversigt.ColumnHeadersHeight = 50;
            dataGridViewOversigt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewOversigt.Columns.AddRange(new DataGridViewColumn[] { boligIdDataGridViewTextBoxColumn, vejnavnDataGridViewTextBoxColumn, nummerDataGridViewTextBoxColumn, postnummerDataGridViewTextBoxColumn, bynavnDataGridViewTextBoxColumn, arealDataGridViewTextBoxColumn, handelsprisDataGridViewTextBoxColumn, handelsdatoDataGridViewTextBoxColumn, tilSalgDataGridViewCheckBoxColumn, boligtypeDataGridViewTextBoxColumn, sælgernavnDataGridViewTextBoxColumn, købernavnDataGridViewTextBoxColumn, ejendomsmæglernavnDataGridViewTextBoxColumn, Afdelingsnavn, AfdelingId });
            dataGridViewOversigt.DataSource = oversigtBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(254, 195, 21);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewOversigt.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewOversigt.Dock = DockStyle.Fill;
            dataGridViewOversigt.EnableHeadersVisualStyles = false;
            dataGridViewOversigt.GridColor = Color.FromArgb(22, 69, 115);
            dataGridViewOversigt.Location = new Point(0, 0);
            dataGridViewOversigt.Name = "dataGridViewOversigt";
            dataGridViewOversigt.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewOversigt.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewOversigt.RowHeadersVisible = false;
            dataGridViewOversigt.RowHeadersWidth = 62;
            dataGridViewOversigt.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewOversigt.RowTemplate.DividerHeight = 1;
            dataGridViewOversigt.RowTemplate.Height = 50;
            dataGridViewOversigt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOversigt.ShowCellToolTips = false;
            dataGridViewOversigt.ShowEditingIcon = false;
            dataGridViewOversigt.Size = new Size(1566, 1011);
            dataGridViewOversigt.TabIndex = 2;
            dataGridViewOversigt.CellDoubleClick += dataGridViewOversigt_CellDoubleClick;
            dataGridViewOversigt.RowPrePaint += dataGridViewOversigt_RowPrePaint;
            dataGridViewOversigt.UserDeletingRow += dataGridViewOversigt_UserDeletingRow;
            // 
            // oversigtBindingSource
            // 
            oversigtBindingSource.DataSource = typeof(BoligInfo);
            // 
            // oversigtPanel
            // 
            oversigtPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            oversigtPanel.Controls.Add(dataGridViewOversigt);
            oversigtPanel.Location = new Point(0, 0);
            oversigtPanel.Name = "oversigtPanel";
            oversigtPanel.Size = new Size(1566, 1011);
            oversigtPanel.TabIndex = 4;
            // 
            // controlPanel
            // 
            controlPanel.BackColor = Color.FromArgb(22, 69, 115);
            controlPanel.Controls.Add(checkBoxSolgt);
            controlPanel.Controls.Add(labelMax);
            controlPanel.Controls.Add(labelMin);
            controlPanel.Controls.Add(buttonFjern);
            controlPanel.Controls.Add(buttonAnvend);
            controlPanel.Controls.Add(textBoxMax);
            controlPanel.Controls.Add(textBoxMin);
            controlPanel.Controls.Add(labelHandelsprisMinMax);
            controlPanel.Controls.Add(checkBoxTilSalg);
            controlPanel.Controls.Add(buttonFaldende);
            controlPanel.Controls.Add(labelHandelspris);
            controlPanel.Controls.Add(btnStigende);
            controlPanel.Dock = DockStyle.Bottom;
            controlPanel.Location = new Point(0, 961);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(1566, 183);
            controlPanel.TabIndex = 3;
            // 
            // checkBoxSolgt
            // 
            checkBoxSolgt.AutoSize = true;
            checkBoxSolgt.Checked = true;
            checkBoxSolgt.CheckState = CheckState.Checked;
            checkBoxSolgt.ForeColor = Color.White;
            checkBoxSolgt.Location = new Point(1034, 90);
            checkBoxSolgt.Name = "checkBoxSolgt";
            checkBoxSolgt.Size = new Size(176, 29);
            checkBoxSolgt.TabIndex = 11;
            checkBoxSolgt.Text = "Vis solgte boliger";
            checkBoxSolgt.UseVisualStyleBackColor = true;
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.ForeColor = Color.White;
            labelMax.Location = new Point(807, 92);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(45, 25);
            labelMax.TabIndex = 10;
            labelMax.Text = "Max";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.ForeColor = Color.White;
            labelMin.Location = new Point(810, 54);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(42, 25);
            labelMin.TabIndex = 9;
            labelMin.Text = "Min";
            // 
            // buttonFjern
            // 
            buttonFjern.Location = new Point(1034, 137);
            buttonFjern.Name = "buttonFjern";
            buttonFjern.Size = new Size(82, 34);
            buttonFjern.TabIndex = 8;
            buttonFjern.Text = "Fjern";
            buttonFjern.UseVisualStyleBackColor = true;
            buttonFjern.Click += buttonFjern_Click;
            // 
            // buttonAnvend
            // 
            buttonAnvend.Location = new Point(1130, 137);
            buttonAnvend.Name = "buttonAnvend";
            buttonAnvend.Size = new Size(82, 34);
            buttonAnvend.TabIndex = 7;
            buttonAnvend.Text = "Anvend";
            buttonAnvend.UseVisualStyleBackColor = true;
            buttonAnvend.Click += buttonAnvend_Click;
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new Point(858, 90);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(150, 31);
            textBoxMax.TabIndex = 6;
            // 
            // textBoxMin
            // 
            textBoxMin.Location = new Point(858, 50);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(150, 31);
            textBoxMin.TabIndex = 5;
            // 
            // labelHandelsprisMinMax
            // 
            labelHandelsprisMinMax.AutoSize = true;
            labelHandelsprisMinMax.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHandelsprisMinMax.ForeColor = Color.White;
            labelHandelsprisMinMax.Location = new Point(856, 17);
            labelHandelsprisMinMax.Name = "labelHandelsprisMinMax";
            labelHandelsprisMinMax.Size = new Size(152, 25);
            labelHandelsprisMinMax.TabIndex = 4;
            labelHandelsprisMinMax.Text = "Filtrer handelspris";
            // 
            // checkBoxTilSalg
            // 
            checkBoxTilSalg.AutoSize = true;
            checkBoxTilSalg.Checked = true;
            checkBoxTilSalg.CheckState = CheckState.Checked;
            checkBoxTilSalg.ForeColor = Color.White;
            checkBoxTilSalg.Location = new Point(1032, 50);
            checkBoxTilSalg.Name = "checkBoxTilSalg";
            checkBoxTilSalg.Size = new Size(178, 29);
            checkBoxTilSalg.TabIndex = 3;
            checkBoxTilSalg.Text = "Vis boliger til salg";
            checkBoxTilSalg.UseVisualStyleBackColor = true;
            // 
            // buttonFaldende
            // 
            buttonFaldende.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 195, 21);
            buttonFaldende.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            buttonFaldende.FlatStyle = FlatStyle.Flat;
            buttonFaldende.ForeColor = Color.White;
            buttonFaldende.Location = new Point(465, 85);
            buttonFaldende.Name = "buttonFaldende";
            buttonFaldende.Size = new Size(156, 34);
            buttonFaldende.TabIndex = 2;
            buttonFaldende.Text = "Faldende";
            buttonFaldende.UseVisualStyleBackColor = true;
            buttonFaldende.Click += buttonFaldende_Click;
            // 
            // labelHandelspris
            // 
            labelHandelspris.AutoSize = true;
            labelHandelspris.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHandelspris.ForeColor = Color.White;
            labelHandelspris.Location = new Point(465, 13);
            labelHandelspris.Name = "labelHandelspris";
            labelHandelspris.Size = new Size(152, 25);
            labelHandelspris.TabIndex = 1;
            labelHandelspris.Text = "Sorter handelspris";
            // 
            // btnStigende
            // 
            btnStigende.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 195, 21);
            btnStigende.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnStigende.FlatStyle = FlatStyle.Flat;
            btnStigende.ForeColor = Color.White;
            btnStigende.Location = new Point(465, 41);
            btnStigende.Name = "btnStigende";
            btnStigende.Size = new Size(156, 34);
            btnStigende.TabIndex = 0;
            btnStigende.Text = "Stigende";
            btnStigende.UseVisualStyleBackColor = true;
            btnStigende.Click += btnStigende_Click;
            // 
            // boligIdDataGridViewTextBoxColumn
            // 
            boligIdDataGridViewTextBoxColumn.DataPropertyName = "BoligId";
            boligIdDataGridViewTextBoxColumn.HeaderText = "BoligId";
            boligIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligIdDataGridViewTextBoxColumn.Name = "boligIdDataGridViewTextBoxColumn";
            boligIdDataGridViewTextBoxColumn.ReadOnly = true;
            boligIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // vejnavnDataGridViewTextBoxColumn
            // 
            vejnavnDataGridViewTextBoxColumn.DataPropertyName = "Vejnavn";
            vejnavnDataGridViewTextBoxColumn.HeaderText = "Vej";
            vejnavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            vejnavnDataGridViewTextBoxColumn.Name = "vejnavnDataGridViewTextBoxColumn";
            vejnavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nummerDataGridViewTextBoxColumn
            // 
            nummerDataGridViewTextBoxColumn.DataPropertyName = "Nummer";
            nummerDataGridViewTextBoxColumn.HeaderText = "Nr.";
            nummerDataGridViewTextBoxColumn.MinimumWidth = 8;
            nummerDataGridViewTextBoxColumn.Name = "nummerDataGridViewTextBoxColumn";
            nummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postnummerDataGridViewTextBoxColumn
            // 
            postnummerDataGridViewTextBoxColumn.DataPropertyName = "Postnummer";
            postnummerDataGridViewTextBoxColumn.HeaderText = "Postnr.";
            postnummerDataGridViewTextBoxColumn.MinimumWidth = 8;
            postnummerDataGridViewTextBoxColumn.Name = "postnummerDataGridViewTextBoxColumn";
            postnummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bynavnDataGridViewTextBoxColumn
            // 
            bynavnDataGridViewTextBoxColumn.DataPropertyName = "Bynavn";
            bynavnDataGridViewTextBoxColumn.HeaderText = "By";
            bynavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            bynavnDataGridViewTextBoxColumn.Name = "bynavnDataGridViewTextBoxColumn";
            bynavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arealDataGridViewTextBoxColumn
            // 
            arealDataGridViewTextBoxColumn.DataPropertyName = "Areal";
            arealDataGridViewTextBoxColumn.HeaderText = "Areal";
            arealDataGridViewTextBoxColumn.MinimumWidth = 8;
            arealDataGridViewTextBoxColumn.Name = "arealDataGridViewTextBoxColumn";
            arealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // handelsprisDataGridViewTextBoxColumn
            // 
            handelsprisDataGridViewTextBoxColumn.DataPropertyName = "Handelspris";
            handelsprisDataGridViewTextBoxColumn.HeaderText = "Handelspris";
            handelsprisDataGridViewTextBoxColumn.MinimumWidth = 8;
            handelsprisDataGridViewTextBoxColumn.Name = "handelsprisDataGridViewTextBoxColumn";
            handelsprisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // handelsdatoDataGridViewTextBoxColumn
            // 
            handelsdatoDataGridViewTextBoxColumn.DataPropertyName = "Handelsdato";
            handelsdatoDataGridViewTextBoxColumn.HeaderText = "Handelsdato";
            handelsdatoDataGridViewTextBoxColumn.MinimumWidth = 8;
            handelsdatoDataGridViewTextBoxColumn.Name = "handelsdatoDataGridViewTextBoxColumn";
            handelsdatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tilSalgDataGridViewCheckBoxColumn
            // 
            tilSalgDataGridViewCheckBoxColumn.DataPropertyName = "TilSalg";
            tilSalgDataGridViewCheckBoxColumn.HeaderText = "Til salg";
            tilSalgDataGridViewCheckBoxColumn.MinimumWidth = 8;
            tilSalgDataGridViewCheckBoxColumn.Name = "tilSalgDataGridViewCheckBoxColumn";
            tilSalgDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // boligtypeDataGridViewTextBoxColumn
            // 
            boligtypeDataGridViewTextBoxColumn.DataPropertyName = "Boligtype";
            boligtypeDataGridViewTextBoxColumn.HeaderText = "Type";
            boligtypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligtypeDataGridViewTextBoxColumn.Name = "boligtypeDataGridViewTextBoxColumn";
            boligtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sælgernavnDataGridViewTextBoxColumn
            // 
            sælgernavnDataGridViewTextBoxColumn.DataPropertyName = "Sælgernavn";
            sælgernavnDataGridViewTextBoxColumn.HeaderText = "Sælger";
            sælgernavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            sælgernavnDataGridViewTextBoxColumn.Name = "sælgernavnDataGridViewTextBoxColumn";
            sælgernavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // købernavnDataGridViewTextBoxColumn
            // 
            købernavnDataGridViewTextBoxColumn.DataPropertyName = "Købernavn";
            købernavnDataGridViewTextBoxColumn.HeaderText = "Køber";
            købernavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            købernavnDataGridViewTextBoxColumn.Name = "købernavnDataGridViewTextBoxColumn";
            købernavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ejendomsmæglernavnDataGridViewTextBoxColumn
            // 
            ejendomsmæglernavnDataGridViewTextBoxColumn.DataPropertyName = "Ejendomsmæglernavn";
            ejendomsmæglernavnDataGridViewTextBoxColumn.HeaderText = "Mægler";
            ejendomsmæglernavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            ejendomsmæglernavnDataGridViewTextBoxColumn.Name = "ejendomsmæglernavnDataGridViewTextBoxColumn";
            ejendomsmæglernavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Afdelingsnavn
            // 
            Afdelingsnavn.DataPropertyName = "Afdelingsnavn";
            Afdelingsnavn.HeaderText = "Afdeling";
            Afdelingsnavn.MinimumWidth = 8;
            Afdelingsnavn.Name = "Afdelingsnavn";
            Afdelingsnavn.ReadOnly = true;
            // 
            // AfdelingId
            // 
            AfdelingId.DataPropertyName = "AfdelingId";
            AfdelingId.HeaderText = "AfdelingId";
            AfdelingId.MinimumWidth = 8;
            AfdelingId.Name = "AfdelingId";
            AfdelingId.ReadOnly = true;
            AfdelingId.Visible = false;
            // 
            // OversigtForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(1566, 1144);
            Controls.Add(controlPanel);
            Controls.Add(oversigtPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "OversigtForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += OversigtForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOversigt).EndInit();
            ((System.ComponentModel.ISupportInitialize)oversigtBindingSource).EndInit();
            oversigtPanel.ResumeLayout(false);
            controlPanel.ResumeLayout(false);
            controlPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewOversigt;
        private Panel oversigtPanel;
        private BindingSource oversigtBindingSource;
        private DataGridViewTextBoxColumn sælgerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn køberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ejendomsmæglerDataGridViewTextBoxColumn;
        private Panel controlPanel;
        private Button buttonFaldende;
        private Label labelHandelspris;
        private Button btnStigende;
        private CheckBox checkBoxTilSalg;
        private Label labelHandelsprisMinMax;
        private TextBox textBoxMax;
        private TextBox textBoxMin;
        private Button buttonAnvend;
        private Button buttonFjern;
        private Label labelMax;
        private Label labelMin;
        private CheckBox checkBoxSolgt;
        private DataGridViewTextBoxColumn boligIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vejnavnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nummerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postnummerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bynavnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn arealDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn handelsprisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn handelsdatoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn tilSalgDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn boligtypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sælgernavnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn købernavnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ejendomsmæglernavnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Afdelingsnavn;
        private DataGridViewTextBoxColumn AfdelingId;
    }
}