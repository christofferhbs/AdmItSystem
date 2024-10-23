namespace AdmItSystem.WinForms
{
    partial class RedigerKundeForm
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
            labelRedigerKunde = new Label();
            checkBoxSælger = new CheckBox();
            labelFornavn = new Label();
            labelEfternavn = new Label();
            labelTlfNr = new Label();
            labelEmail = new Label();
            textBoxFornavn = new TextBox();
            textBoxEfternavn = new TextBox();
            textBoxTlfNr = new TextBox();
            textBoxEmail = new TextBox();
            btnGem = new Button();
            checkBoxKøber = new CheckBox();
            SuspendLayout();
            // 
            // labelRedigerKunde
            // 
            labelRedigerKunde.AutoSize = true;
            labelRedigerKunde.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRedigerKunde.Location = new Point(46, 35);
            labelRedigerKunde.Name = "labelRedigerKunde";
            labelRedigerKunde.Size = new Size(180, 32);
            labelRedigerKunde.TabIndex = 0;
            labelRedigerKunde.Text = "Rediger kunde";
            // 
            // checkBoxSælger
            // 
            checkBoxSælger.AutoSize = true;
            checkBoxSælger.Location = new Point(46, 90);
            checkBoxSælger.Name = "checkBoxSælger";
            checkBoxSælger.Size = new Size(101, 32);
            checkBoxSælger.TabIndex = 1;
            checkBoxSælger.Text = "Sælger";
            checkBoxSælger.UseVisualStyleBackColor = true;
            checkBoxSælger.CheckedChanged += checkBoxSælger_CheckedChanged;
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
            btnGem.Location = new Point(275, 373);
            btnGem.Name = "btnGem";
            btnGem.Size = new Size(136, 45);
            btnGem.TabIndex = 10;
            btnGem.Text = "Gem";
            btnGem.TextAlign = ContentAlignment.TopCenter;
            btnGem.UseVisualStyleBackColor = true;
            btnGem.Click += btnGem_Click;
            // 
            // checkBoxKøber
            // 
            checkBoxKøber.AutoSize = true;
            checkBoxKøber.Location = new Point(153, 90);
            checkBoxKøber.Name = "checkBoxKøber";
            checkBoxKøber.Size = new Size(92, 32);
            checkBoxKøber.TabIndex = 14;
            checkBoxKøber.Text = "Køber";
            checkBoxKøber.UseVisualStyleBackColor = true;
            checkBoxKøber.CheckedChanged += checkBoxKøber_CheckedChanged;
            // 
            // RedigerKundeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 69, 115);
            ClientSize = new Size(492, 443);
            Controls.Add(checkBoxKøber);
            Controls.Add(btnGem);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTlfNr);
            Controls.Add(textBoxEfternavn);
            Controls.Add(textBoxFornavn);
            Controls.Add(labelEmail);
            Controls.Add(labelTlfNr);
            Controls.Add(labelEfternavn);
            Controls.Add(labelFornavn);
            Controls.Add(checkBoxSælger);
            Controls.Add(labelRedigerKunde);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RedigerKundeForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rediger kunde - Administrativt IT-system";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRedigerKunde;
        private CheckBox checkBoxSælger;
        private Label labelFornavn;
        private Label labelEfternavn;
        private Label labelTlfNr;
        private Label labelEmail;
        private TextBox textBoxFornavn;
        private TextBox textBoxEfternavn;
        private TextBox textBoxTlfNr;
        private TextBox textBoxEmail;
        private Button btnGem;
        private CheckBox checkBoxKøber;
    }
}