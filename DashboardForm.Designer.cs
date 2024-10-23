namespace AdmItSystem.WinForms
{
    partial class DashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            navPanel = new Panel();
            btnKunder = new Button();
            btnMedarbejdere = new Button();
            btnAfdelinger = new Button();
            btnEksport = new Button();
            btnMarkedsanalyse = new Button();
            btnOversigt = new Button();
            edcPanel = new Panel();
            comboBoxAfdeling = new ComboBox();
            edcPictureBox = new PictureBox();
            dashboardPanel = new Panel();
            navPanel.SuspendLayout();
            edcPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edcPictureBox).BeginInit();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(22, 69, 115);
            navPanel.Controls.Add(btnKunder);
            navPanel.Controls.Add(btnMedarbejdere);
            navPanel.Controls.Add(btnAfdelinger);
            navPanel.Controls.Add(btnEksport);
            navPanel.Controls.Add(btnMarkedsanalyse);
            navPanel.Controls.Add(btnOversigt);
            navPanel.Controls.Add(edcPanel);
            navPanel.Dock = DockStyle.Left;
            navPanel.Location = new Point(0, 0);
            navPanel.Margin = new Padding(4, 5, 4, 5);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(312, 1144);
            navPanel.TabIndex = 0;
            // 
            // btnKunder
            // 
            btnKunder.BackColor = Color.FromArgb(22, 69, 115);
            btnKunder.Dock = DockStyle.Top;
            btnKunder.FlatAppearance.BorderColor = Color.FromArgb(22, 69, 115);
            btnKunder.FlatAppearance.BorderSize = 0;
            btnKunder.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 195, 21);
            btnKunder.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnKunder.FlatStyle = FlatStyle.Flat;
            btnKunder.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKunder.ForeColor = Color.White;
            btnKunder.Location = new Point(0, 624);
            btnKunder.Margin = new Padding(6, 16, 6, 0);
            btnKunder.Name = "btnKunder";
            btnKunder.Padding = new Padding(12, 16, 12, 16);
            btnKunder.Size = new Size(312, 78);
            btnKunder.TabIndex = 8;
            btnKunder.Text = "Kunder";
            btnKunder.UseVisualStyleBackColor = false;
            btnKunder.Click += btnKunder_Click;
            // 
            // btnMedarbejdere
            // 
            btnMedarbejdere.BackColor = Color.FromArgb(22, 69, 115);
            btnMedarbejdere.Dock = DockStyle.Top;
            btnMedarbejdere.FlatAppearance.BorderColor = Color.FromArgb(22, 69, 115);
            btnMedarbejdere.FlatAppearance.BorderSize = 0;
            btnMedarbejdere.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 195, 21);
            btnMedarbejdere.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnMedarbejdere.FlatStyle = FlatStyle.Flat;
            btnMedarbejdere.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMedarbejdere.ForeColor = Color.White;
            btnMedarbejdere.Location = new Point(0, 546);
            btnMedarbejdere.Margin = new Padding(6, 16, 6, 0);
            btnMedarbejdere.Name = "btnMedarbejdere";
            btnMedarbejdere.Padding = new Padding(12, 16, 12, 16);
            btnMedarbejdere.Size = new Size(312, 78);
            btnMedarbejdere.TabIndex = 7;
            btnMedarbejdere.Text = "Medarbejdere";
            btnMedarbejdere.UseVisualStyleBackColor = false;
            btnMedarbejdere.Click += btnMedarbejdere_Click;
            // 
            // btnAfdelinger
            // 
            btnAfdelinger.BackColor = Color.FromArgb(22, 69, 115);
            btnAfdelinger.Dock = DockStyle.Top;
            btnAfdelinger.FlatAppearance.BorderColor = Color.FromArgb(22, 69, 115);
            btnAfdelinger.FlatAppearance.BorderSize = 0;
            btnAfdelinger.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 195, 21);
            btnAfdelinger.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnAfdelinger.FlatStyle = FlatStyle.Flat;
            btnAfdelinger.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAfdelinger.ForeColor = Color.White;
            btnAfdelinger.Location = new Point(0, 468);
            btnAfdelinger.Margin = new Padding(6, 16, 6, 0);
            btnAfdelinger.Name = "btnAfdelinger";
            btnAfdelinger.Padding = new Padding(12, 16, 12, 16);
            btnAfdelinger.Size = new Size(312, 78);
            btnAfdelinger.TabIndex = 6;
            btnAfdelinger.Text = "Afdelinger";
            btnAfdelinger.UseVisualStyleBackColor = false;
            btnAfdelinger.Click += btnAfdelinger_Click;
            // 
            // btnEksport
            // 
            btnEksport.BackColor = Color.FromArgb(22, 69, 115);
            btnEksport.Dock = DockStyle.Top;
            btnEksport.FlatAppearance.BorderColor = Color.FromArgb(22, 69, 115);
            btnEksport.FlatAppearance.BorderSize = 0;
            btnEksport.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 195, 21);
            btnEksport.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnEksport.FlatStyle = FlatStyle.Flat;
            btnEksport.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEksport.ForeColor = Color.White;
            btnEksport.Location = new Point(0, 390);
            btnEksport.Margin = new Padding(6, 16, 6, 0);
            btnEksport.Name = "btnEksport";
            btnEksport.Padding = new Padding(12, 16, 12, 16);
            btnEksport.Size = new Size(312, 78);
            btnEksport.TabIndex = 5;
            btnEksport.Text = "Eksport";
            btnEksport.UseVisualStyleBackColor = false;
            btnEksport.Click += btnEksport_Click;
            // 
            // btnMarkedsanalyse
            // 
            btnMarkedsanalyse.BackColor = Color.FromArgb(22, 69, 115);
            btnMarkedsanalyse.Dock = DockStyle.Top;
            btnMarkedsanalyse.FlatAppearance.BorderColor = Color.FromArgb(22, 69, 115);
            btnMarkedsanalyse.FlatAppearance.BorderSize = 0;
            btnMarkedsanalyse.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 195, 21);
            btnMarkedsanalyse.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnMarkedsanalyse.FlatStyle = FlatStyle.Flat;
            btnMarkedsanalyse.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMarkedsanalyse.ForeColor = Color.White;
            btnMarkedsanalyse.Location = new Point(0, 312);
            btnMarkedsanalyse.Margin = new Padding(6, 16, 6, 0);
            btnMarkedsanalyse.Name = "btnMarkedsanalyse";
            btnMarkedsanalyse.Padding = new Padding(12, 16, 12, 16);
            btnMarkedsanalyse.Size = new Size(312, 78);
            btnMarkedsanalyse.TabIndex = 4;
            btnMarkedsanalyse.Text = "Markedsanalyse";
            btnMarkedsanalyse.UseVisualStyleBackColor = false;
            btnMarkedsanalyse.Click += btnMarkedsanalyse_Click;
            // 
            // btnOversigt
            // 
            btnOversigt.BackColor = Color.FromArgb(22, 69, 115);
            btnOversigt.Dock = DockStyle.Top;
            btnOversigt.FlatAppearance.BorderColor = Color.FromArgb(22, 69, 115);
            btnOversigt.FlatAppearance.BorderSize = 0;
            btnOversigt.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 195, 21);
            btnOversigt.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnOversigt.FlatStyle = FlatStyle.Flat;
            btnOversigt.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOversigt.ForeColor = Color.White;
            btnOversigt.Location = new Point(0, 234);
            btnOversigt.Margin = new Padding(6, 16, 6, 0);
            btnOversigt.Name = "btnOversigt";
            btnOversigt.Padding = new Padding(12, 16, 12, 16);
            btnOversigt.Size = new Size(312, 78);
            btnOversigt.TabIndex = 3;
            btnOversigt.Text = "Oversigt";
            btnOversigt.UseVisualStyleBackColor = false;
            btnOversigt.Click += btnOversigt_Click;
            // 
            // edcPanel
            // 
            edcPanel.Controls.Add(comboBoxAfdeling);
            edcPanel.Controls.Add(edcPictureBox);
            edcPanel.Dock = DockStyle.Top;
            edcPanel.Location = new Point(0, 0);
            edcPanel.Margin = new Padding(4, 5, 4, 5);
            edcPanel.Name = "edcPanel";
            edcPanel.Size = new Size(312, 234);
            edcPanel.TabIndex = 0;
            // 
            // comboBoxAfdeling
            // 
            comboBoxAfdeling.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxAfdeling.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxAfdeling.FormattingEnabled = true;
            comboBoxAfdeling.Location = new Point(15, 156);
            comboBoxAfdeling.Margin = new Padding(4, 5, 4, 5);
            comboBoxAfdeling.Name = "comboBoxAfdeling";
            comboBoxAfdeling.Size = new Size(282, 33);
            comboBoxAfdeling.TabIndex = 1;
            comboBoxAfdeling.Text = "Vælg afdeling";
            comboBoxAfdeling.SelectedValueChanged += comboBoxAfdeling_SelectedValueChanged;
            // 
            // edcPictureBox
            // 
            edcPictureBox.Image = Properties.Resources.cropped_EDC_PEB_Logo_Payoff_RGB_002_11;
            edcPictureBox.Location = new Point(94, 16);
            edcPictureBox.Margin = new Padding(4, 5, 4, 5);
            edcPictureBox.Name = "edcPictureBox";
            edcPictureBox.Size = new Size(125, 125);
            edcPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            edcPictureBox.TabIndex = 0;
            edcPictureBox.TabStop = false;
            // 
            // dashboardPanel
            // 
            dashboardPanel.Dock = DockStyle.Fill;
            dashboardPanel.Location = new Point(312, 0);
            dashboardPanel.Margin = new Padding(5, 8, 5, 8);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(1566, 1144);
            dashboardPanel.TabIndex = 1;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(1878, 1144);
            Controls.Add(dashboardPanel);
            Controls.Add(navPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DashboardForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrativt IT-system";
            Load += MainForm_Load;
            navPanel.ResumeLayout(false);
            edcPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)edcPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Panel edcPanel;
        private PictureBox edcPictureBox;
        private ComboBox comboBoxAfdeling;
        private Button btnOversigt;
        private Button btnKunder;
        private Button btnMedarbejdere;
        private Button btnAfdelinger;
        private Button btnEksport;
        private Button btnMarkedsanalyse;
        private Panel dashboardPanel;
    }
}
