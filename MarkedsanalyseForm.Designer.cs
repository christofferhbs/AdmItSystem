using AdmItSystem.Models;

namespace AdmItSystem.WinForms
{
    partial class MarkedsanalyseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param disposing="true">true if managed resources should be disposed; otherwise, false.</param>
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
            labelPostnummer = new Label();
            labelAreal = new Label();
            labelBoligtype = new Label();
            textBoxPostnummer = new TextBox();
            textBoxAreal = new TextBox();
            comboBoxBoligtype = new ComboBox();
            btnHentMarkedsanalyse = new Button();
            labelKvadratmeterpris = new Label();
            dataGridViewMarkedsanalyse = new DataGridView();
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
            sælgerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sælgernavnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            køberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            købernavnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ejendomsmæglerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ejendomsmæglernavnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            markedsanalyseBindingSource = new BindingSource(components);
            panelMarkedsanalyse = new Panel();
            panelControls = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarkedsanalyse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)markedsanalyseBindingSource).BeginInit();
            panelMarkedsanalyse.SuspendLayout();
            panelControls.SuspendLayout();
            SuspendLayout();
            // 
            // labelPostnummer
            // 
            labelPostnummer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPostnummer.AutoSize = true;
            labelPostnummer.ForeColor = SystemColors.Control;
            labelPostnummer.Location = new Point(256, 39);
            labelPostnummer.Name = "labelPostnummer";
            labelPostnummer.Size = new Size(129, 28);
            labelPostnummer.TabIndex = 0;
            labelPostnummer.Text = "Postnummer";
            // 
            // labelAreal
            // 
            labelAreal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAreal.AutoSize = true;
            labelAreal.ForeColor = SystemColors.Control;
            labelAreal.Location = new Point(468, 41);
            labelAreal.Name = "labelAreal";
            labelAreal.Size = new Size(58, 28);
            labelAreal.TabIndex = 1;
            labelAreal.Text = "Areal";
            // 
            // labelBoligtype
            // 
            labelBoligtype.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelBoligtype.AutoSize = true;
            labelBoligtype.ForeColor = SystemColors.Control;
            labelBoligtype.Location = new Point(684, 39);
            labelBoligtype.Name = "labelBoligtype";
            labelBoligtype.Size = new Size(98, 28);
            labelBoligtype.TabIndex = 2;
            labelBoligtype.Text = "Boligtype";
            // 
            // textBoxPostnummer
            // 
            textBoxPostnummer.Location = new Point(256, 71);
            textBoxPostnummer.Margin = new Padding(3, 4, 3, 4);
            textBoxPostnummer.Name = "textBoxPostnummer";
            textBoxPostnummer.Size = new Size(182, 34);
            textBoxPostnummer.TabIndex = 3;
            // 
            // textBoxAreal
            // 
            textBoxAreal.Location = new Point(468, 71);
            textBoxAreal.Margin = new Padding(3, 4, 3, 4);
            textBoxAreal.Name = "textBoxAreal";
            textBoxAreal.Size = new Size(182, 34);
            textBoxAreal.TabIndex = 4;
            // 
            // comboBoxBoligtype
            // 
            comboBoxBoligtype.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBoligtype.FormattingEnabled = true;
            comboBoxBoligtype.Items.AddRange(new object[] { "Hus", "Rækkehus", "Lejlighed", "Andelsbolig" });
            comboBoxBoligtype.Location = new Point(684, 69);
            comboBoxBoligtype.Margin = new Padding(3, 4, 3, 4);
            comboBoxBoligtype.Name = "comboBoxBoligtype";
            comboBoxBoligtype.Size = new Size(182, 36);
            comboBoxBoligtype.TabIndex = 5;
            // 
            // btnHentMarkedsanalyse
            // 
            btnHentMarkedsanalyse.FlatAppearance.BorderSize = 3;
            btnHentMarkedsanalyse.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 195, 21);
            btnHentMarkedsanalyse.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnHentMarkedsanalyse.FlatStyle = FlatStyle.Flat;
            btnHentMarkedsanalyse.ForeColor = SystemColors.Control;
            btnHentMarkedsanalyse.Location = new Point(910, 58);
            btnHentMarkedsanalyse.Margin = new Padding(3, 4, 3, 4);
            btnHentMarkedsanalyse.Name = "btnHentMarkedsanalyse";
            btnHentMarkedsanalyse.Size = new Size(184, 56);
            btnHentMarkedsanalyse.TabIndex = 6;
            btnHentMarkedsanalyse.Text = "Hent analyse";
            btnHentMarkedsanalyse.UseVisualStyleBackColor = true;
            btnHentMarkedsanalyse.Click += btnHentMarkedsanalyse_Click;
            // 
            // labelKvadratmeterpris
            // 
            labelKvadratmeterpris.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelKvadratmeterpris.AutoSize = true;
            labelKvadratmeterpris.ForeColor = SystemColors.Control;
            labelKvadratmeterpris.Location = new Point(1122, 72);
            labelKvadratmeterpris.Name = "labelKvadratmeterpris";
            labelKvadratmeterpris.Size = new Size(0, 28);
            labelKvadratmeterpris.TabIndex = 7;
            // 
            // dataGridViewMarkedsanalyse
            // 
            dataGridViewMarkedsanalyse.AllowUserToOrderColumns = true;
            dataGridViewMarkedsanalyse.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewMarkedsanalyse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMarkedsanalyse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMarkedsanalyse.AutoGenerateColumns = false;
            dataGridViewMarkedsanalyse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMarkedsanalyse.BackgroundColor = Color.FromArgb(229, 229, 229);
            dataGridViewMarkedsanalyse.BorderStyle = BorderStyle.None;
            dataGridViewMarkedsanalyse.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewMarkedsanalyse.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 69, 115);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(22, 69, 115);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewMarkedsanalyse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMarkedsanalyse.ColumnHeadersHeight = 50;
            dataGridViewMarkedsanalyse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMarkedsanalyse.Columns.AddRange(new DataGridViewColumn[] { boligIdDataGridViewTextBoxColumn, vejnavnDataGridViewTextBoxColumn, nummerDataGridViewTextBoxColumn, postnummerDataGridViewTextBoxColumn, bynavnDataGridViewTextBoxColumn, arealDataGridViewTextBoxColumn, handelsprisDataGridViewTextBoxColumn, handelsdatoDataGridViewTextBoxColumn, tilSalgDataGridViewCheckBoxColumn, boligtypeDataGridViewTextBoxColumn, sælgerDataGridViewTextBoxColumn, sælgernavnDataGridViewTextBoxColumn, køberDataGridViewTextBoxColumn, købernavnDataGridViewTextBoxColumn, ejendomsmæglerDataGridViewTextBoxColumn, ejendomsmæglernavnDataGridViewTextBoxColumn });
            dataGridViewMarkedsanalyse.DataSource = markedsanalyseBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(254, 195, 21);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewMarkedsanalyse.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMarkedsanalyse.EnableHeadersVisualStyles = false;
            dataGridViewMarkedsanalyse.GridColor = Color.FromArgb(22, 69, 115);
            dataGridViewMarkedsanalyse.Location = new Point(0, 0);
            dataGridViewMarkedsanalyse.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMarkedsanalyse.Name = "dataGridViewMarkedsanalyse";
            dataGridViewMarkedsanalyse.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewMarkedsanalyse.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewMarkedsanalyse.RowHeadersVisible = false;
            dataGridViewMarkedsanalyse.RowHeadersWidth = 62;
            dataGridViewMarkedsanalyse.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewMarkedsanalyse.RowTemplate.DividerHeight = 1;
            dataGridViewMarkedsanalyse.RowTemplate.Height = 50;
            dataGridViewMarkedsanalyse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMarkedsanalyse.ShowCellToolTips = false;
            dataGridViewMarkedsanalyse.ShowEditingIcon = false;
            dataGridViewMarkedsanalyse.Size = new Size(1566, 983);
            dataGridViewMarkedsanalyse.TabIndex = 8;
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
            // sælgerDataGridViewTextBoxColumn
            // 
            sælgerDataGridViewTextBoxColumn.DataPropertyName = "Sælger";
            sælgerDataGridViewTextBoxColumn.HeaderText = "Sælger";
            sælgerDataGridViewTextBoxColumn.MinimumWidth = 8;
            sælgerDataGridViewTextBoxColumn.Name = "sælgerDataGridViewTextBoxColumn";
            sælgerDataGridViewTextBoxColumn.ReadOnly = true;
            sælgerDataGridViewTextBoxColumn.Visible = false;
            // 
            // sælgernavnDataGridViewTextBoxColumn
            // 
            sælgernavnDataGridViewTextBoxColumn.DataPropertyName = "Sælgernavn";
            sælgernavnDataGridViewTextBoxColumn.HeaderText = "Sælger";
            sælgernavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            sælgernavnDataGridViewTextBoxColumn.Name = "sælgernavnDataGridViewTextBoxColumn";
            sælgernavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // køberDataGridViewTextBoxColumn
            // 
            køberDataGridViewTextBoxColumn.DataPropertyName = "Køber";
            køberDataGridViewTextBoxColumn.HeaderText = "Køber";
            køberDataGridViewTextBoxColumn.MinimumWidth = 8;
            køberDataGridViewTextBoxColumn.Name = "køberDataGridViewTextBoxColumn";
            køberDataGridViewTextBoxColumn.ReadOnly = true;
            køberDataGridViewTextBoxColumn.Visible = false;
            // 
            // købernavnDataGridViewTextBoxColumn
            // 
            købernavnDataGridViewTextBoxColumn.DataPropertyName = "Købernavn";
            købernavnDataGridViewTextBoxColumn.HeaderText = "Køber";
            købernavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            købernavnDataGridViewTextBoxColumn.Name = "købernavnDataGridViewTextBoxColumn";
            købernavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ejendomsmæglerDataGridViewTextBoxColumn
            // 
            ejendomsmæglerDataGridViewTextBoxColumn.DataPropertyName = "Ejendomsmægler";
            ejendomsmæglerDataGridViewTextBoxColumn.HeaderText = "Ejendomsmægler";
            ejendomsmæglerDataGridViewTextBoxColumn.MinimumWidth = 8;
            ejendomsmæglerDataGridViewTextBoxColumn.Name = "ejendomsmæglerDataGridViewTextBoxColumn";
            ejendomsmæglerDataGridViewTextBoxColumn.ReadOnly = true;
            ejendomsmæglerDataGridViewTextBoxColumn.Visible = false;
            // 
            // ejendomsmæglernavnDataGridViewTextBoxColumn
            // 
            ejendomsmæglernavnDataGridViewTextBoxColumn.DataPropertyName = "Ejendomsmæglernavn";
            ejendomsmæglernavnDataGridViewTextBoxColumn.HeaderText = "Mægler";
            ejendomsmæglernavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            ejendomsmæglernavnDataGridViewTextBoxColumn.Name = "ejendomsmæglernavnDataGridViewTextBoxColumn";
            ejendomsmæglernavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markedsanalyseBindingSource
            // 
            markedsanalyseBindingSource.DataSource = typeof(BoligInfo);
            // 
            // panelMarkedsanalyse
            // 
            panelMarkedsanalyse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMarkedsanalyse.BackColor = Color.FromArgb(22, 69, 115);
            panelMarkedsanalyse.Controls.Add(panelControls);
            panelMarkedsanalyse.Controls.Add(dataGridViewMarkedsanalyse);
            panelMarkedsanalyse.Location = new Point(0, 0);
            panelMarkedsanalyse.Name = "panelMarkedsanalyse";
            panelMarkedsanalyse.Size = new Size(1566, 1144);
            panelMarkedsanalyse.TabIndex = 9;
            // 
            // panelControls
            // 
            panelControls.Controls.Add(textBoxPostnummer);
            panelControls.Controls.Add(textBoxAreal);
            panelControls.Controls.Add(labelPostnummer);
            panelControls.Controls.Add(comboBoxBoligtype);
            panelControls.Controls.Add(labelKvadratmeterpris);
            panelControls.Controls.Add(labelBoligtype);
            panelControls.Controls.Add(labelAreal);
            panelControls.Controls.Add(btnHentMarkedsanalyse);
            panelControls.Dock = DockStyle.Bottom;
            panelControls.Location = new Point(0, 982);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(1566, 162);
            panelControls.TabIndex = 9;
            // 
            // MarkedsanalyseForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1566, 1144);
            Controls.Add(panelMarkedsanalyse);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MarkedsanalyseForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarkedsanalyse).EndInit();
            ((System.ComponentModel.ISupportInitialize)markedsanalyseBindingSource).EndInit();
            panelMarkedsanalyse.ResumeLayout(false);
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelPostnummer;
        private Label labelAreal;
        private Label labelBoligtype;
        private TextBox textBoxPostnummer;
        private TextBox textBoxAreal;
        private ComboBox comboBoxBoligtype;
        private Button btnHentMarkedsanalyse;
        private Label labelKvadratmeterpris;
        private DataGridView dataGridViewMarkedsanalyse;
        private Panel panelMarkedsanalyse;
        private BindingSource markedsanalyseBindingSource;
        private DataGridViewTextBoxColumn kvadratmeterprisDataGridViewTextBoxColumn;
        private Panel panelControls;
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
        private DataGridViewTextBoxColumn sælgerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sælgernavnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn køberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn købernavnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ejendomsmæglerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ejendomsmæglernavnDataGridViewTextBoxColumn;
    }
}
