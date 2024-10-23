namespace AdmItSystem.WinForms
{
    partial class RedigerMedarbejderForm
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
            labelRedigerMedarbejder = new Label();
            labelFornavn = new Label();
            labelEfternavn = new Label();
            labelTlfNr = new Label();
            labelEmail = new Label();
            textBoxFornavn = new TextBox();
            textBoxEfternavn = new TextBox();
            textBoxTlfNr = new TextBox();
            textBoxEmail = new TextBox();
            btnGem = new Button();
            checkBoxEjendomsmægler = new CheckBox();
            labelAfdeling = new Label();
            comboBoxAfdeling = new ComboBox();
            SuspendLayout();
            // 
            // labelRedigerMedarbejder
            // 
            labelRedigerMedarbejder.AutoSize = true;
            labelRedigerMedarbejder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRedigerMedarbejder.Location = new Point(46, 35);
            labelRedigerMedarbejder.Name = "labelRedigerMedarbejder";
            labelRedigerMedarbejder.Size = new Size(255, 32);
            labelRedigerMedarbejder.TabIndex = 0;
            labelRedigerMedarbejder.Text = "Rediger medarbejder";
            // 
            // labelFornavn
            // 
            labelFornavn.AutoSize = true;
            labelFornavn.Location = new Point(46, 145);
            labelFornavn.Name = "labelFornavn";
            labelFornavn.Size = new Size(85, 28);
            labelFornavn.TabIndex = 2;
            labelFornavn.Text = "Fornavn";
            // 
            // labelEfternavn
            // 
            labelEfternavn.AutoSize = true;
            labelEfternavn.Location = new Point(46, 200);
            labelEfternavn.Name = "labelEfternavn";
            labelEfternavn.Size = new Size(98, 28);
            labelEfternavn.TabIndex = 3;
            labelEfternavn.Text = "Efternavn";
            // 
            // labelTlfNr
            // 
            labelTlfNr.AutoSize = true;
            labelTlfNr.Location = new Point(46, 254);
            labelTlfNr.Name = "labelTlfNr";
            labelTlfNr.Size = new Size(61, 28);
            labelTlfNr.TabIndex = 4;
            labelTlfNr.Text = "Tlf.nr.";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(46, 309);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(60, 28);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // textBoxFornavn
            // 
            textBoxFornavn.Location = new Point(179, 145);
            textBoxFornavn.Name = "textBoxFornavn";
            textBoxFornavn.Size = new Size(232, 34);
            textBoxFornavn.TabIndex = 6;
            // 
            // textBoxEfternavn
            // 
            textBoxEfternavn.Location = new Point(179, 200);
            textBoxEfternavn.Name = "textBoxEfternavn";
            textBoxEfternavn.Size = new Size(232, 34);
            textBoxEfternavn.TabIndex = 7;
            // 
            // textBoxTlfNr
            // 
            textBoxTlfNr.Location = new Point(179, 254);
            textBoxTlfNr.Name = "textBoxTlfNr";
            textBoxTlfNr.Size = new Size(232, 34);
            textBoxTlfNr.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(179, 309);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(232, 34);
            textBoxEmail.TabIndex = 9;
            // 
            // btnGem
            // 
            btnGem.FlatAppearance.BorderSize = 3;
            btnGem.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 195, 21);
            btnGem.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnGem.FlatStyle = FlatStyle.Flat;
            btnGem.Location = new Point(275, 428);
            btnGem.Name = "btnGem";
            btnGem.Size = new Size(136, 45);
            btnGem.TabIndex = 10;
            btnGem.Text = "Gem";
            btnGem.TextAlign = ContentAlignment.TopCenter;
            btnGem.UseVisualStyleBackColor = true;
            btnGem.Click += btnGem_Click;
            // 
            // checkBoxEjendomsmægler
            // 
            checkBoxEjendomsmægler.AutoSize = true;
            checkBoxEjendomsmægler.Checked = true;
            checkBoxEjendomsmægler.CheckState = CheckState.Checked;
            checkBoxEjendomsmægler.Location = new Point(46, 90);
            checkBoxEjendomsmægler.Name = "checkBoxEjendomsmægler";
            checkBoxEjendomsmægler.Size = new Size(197, 32);
            checkBoxEjendomsmægler.TabIndex = 14;
            checkBoxEjendomsmægler.Text = "Ejendomsmægler";
            checkBoxEjendomsmægler.UseVisualStyleBackColor = true;
            // 
            // labelAfdeling
            // 
            labelAfdeling.AutoSize = true;
            labelAfdeling.Location = new Point(47, 366);
            labelAfdeling.Name = "labelAfdeling";
            labelAfdeling.Size = new Size(89, 28);
            labelAfdeling.TabIndex = 15;
            labelAfdeling.Text = "Afdeling";
            // 
            // comboBoxAfdeling
            // 
            comboBoxAfdeling.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxAfdeling.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxAfdeling.FormattingEnabled = true;
            comboBoxAfdeling.Location = new Point(179, 363);
            comboBoxAfdeling.Name = "comboBoxAfdeling";
            comboBoxAfdeling.Size = new Size(232, 36);
            comboBoxAfdeling.TabIndex = 16;
            // 
            // RedigerMedarbejderForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 69, 115);
            ClientSize = new Size(492, 504);
            Controls.Add(comboBoxAfdeling);
            Controls.Add(labelAfdeling);
            Controls.Add(checkBoxEjendomsmægler);
            Controls.Add(btnGem);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTlfNr);
            Controls.Add(textBoxEfternavn);
            Controls.Add(textBoxFornavn);
            Controls.Add(labelEmail);
            Controls.Add(labelTlfNr);
            Controls.Add(labelEfternavn);
            Controls.Add(labelFornavn);
            Controls.Add(labelRedigerMedarbejder);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RedigerMedarbejderForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rediger medarbejder - Administrativt IT-system";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRedigerMedarbejder;
        private Label labelFornavn;
        private Label labelEfternavn;
        private Label labelTlfNr;
        private Label labelEmail;
        private TextBox textBoxFornavn;
        private TextBox textBoxEfternavn;
        private TextBox textBoxTlfNr;
        private TextBox textBoxEmail;
        private Button btnGem;
        private CheckBox checkBoxEjendomsmægler;
        private Label labelAfdeling;
        private ComboBox comboBoxAfdeling;
    }
}