namespace AdmItSystem.WinForms
{
    partial class RedigerBoligForm
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
            labelRedigerBolig = new Label();
            checkBoxHus = new CheckBox();
            labelVejnavn = new Label();
            labelNummer = new Label();
            labelPostnummer = new Label();
            labelBynavn = new Label();
            textBoxVejnavn = new TextBox();
            textBoxNummer = new TextBox();
            textBoxPostnummer = new TextBox();
            textBoxBynavn = new TextBox();
            btnGem = new Button();
            checkBoxRækkehus = new CheckBox();
            checkBoxLejlighed = new CheckBox();
            checkBoxAndelsbolig = new CheckBox();
            labelAreal = new Label();
            labelHandelspris = new Label();
            labelHandelsdato = new Label();
            labelTilSalg = new Label();
            labelSælger = new Label();
            labelKøber = new Label();
            labelEjendomsmægler = new Label();
            textBoxAreal = new TextBox();
            textBoxHandelspris = new TextBox();
            dateTimePickerHandelsdato = new DateTimePicker();
            checkBoxTilSalg = new CheckBox();
            comboBoxSælger = new ComboBox();
            comboBoxKøber = new ComboBox();
            comboBoxEjendomsmægler = new ComboBox();
            SuspendLayout();
            // 
            // labelRedigerBolig
            // 
            labelRedigerBolig.AutoSize = true;
            labelRedigerBolig.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRedigerBolig.ForeColor = Color.White;
            labelRedigerBolig.Location = new Point(27, 33);
            labelRedigerBolig.Name = "labelRedigerBolig";
            labelRedigerBolig.Size = new Size(192, 38);
            labelRedigerBolig.TabIndex = 0;
            labelRedigerBolig.Text = "Rediger bolig";
            // 
            // checkBoxHus
            // 
            checkBoxHus.AutoSize = true;
            checkBoxHus.Location = new Point(36, 99);
            checkBoxHus.Margin = new Padding(3, 4, 3, 4);
            checkBoxHus.Name = "checkBoxHus";
            checkBoxHus.Size = new Size(74, 32);
            checkBoxHus.TabIndex = 1;
            checkBoxHus.Text = "Hus";
            checkBoxHus.UseVisualStyleBackColor = true;
            checkBoxHus.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // labelVejnavn
            // 
            labelVejnavn.AutoSize = true;
            labelVejnavn.Location = new Point(36, 168);
            labelVejnavn.Name = "labelVejnavn";
            labelVejnavn.Size = new Size(84, 28);
            labelVejnavn.TabIndex = 5;
            labelVejnavn.Text = "Vejnavn";
            // 
            // labelNummer
            // 
            labelNummer.AutoSize = true;
            labelNummer.Location = new Point(36, 237);
            labelNummer.Name = "labelNummer";
            labelNummer.Size = new Size(93, 28);
            labelNummer.TabIndex = 7;
            labelNummer.Text = "Nummer";
            // 
            // labelPostnummer
            // 
            labelPostnummer.AutoSize = true;
            labelPostnummer.Location = new Point(36, 308);
            labelPostnummer.Name = "labelPostnummer";
            labelPostnummer.Size = new Size(129, 28);
            labelPostnummer.TabIndex = 9;
            labelPostnummer.Text = "Postnummer";
            // 
            // labelBynavn
            // 
            labelBynavn.AutoSize = true;
            labelBynavn.Location = new Point(36, 379);
            labelBynavn.Name = "labelBynavn";
            labelBynavn.Size = new Size(78, 28);
            labelBynavn.TabIndex = 11;
            labelBynavn.Text = "Bynavn";
            // 
            // textBoxVejnavn
            // 
            textBoxVejnavn.Location = new Point(244, 168);
            textBoxVejnavn.Margin = new Padding(3, 4, 3, 4);
            textBoxVejnavn.Name = "textBoxVejnavn";
            textBoxVejnavn.Size = new Size(304, 34);
            textBoxVejnavn.TabIndex = 6;
            // 
            // textBoxNummer
            // 
            textBoxNummer.Location = new Point(244, 237);
            textBoxNummer.Margin = new Padding(3, 4, 3, 4);
            textBoxNummer.Name = "textBoxNummer";
            textBoxNummer.Size = new Size(304, 34);
            textBoxNummer.TabIndex = 8;
            // 
            // textBoxPostnummer
            // 
            textBoxPostnummer.Location = new Point(244, 308);
            textBoxPostnummer.Margin = new Padding(3, 4, 3, 4);
            textBoxPostnummer.Name = "textBoxPostnummer";
            textBoxPostnummer.Size = new Size(304, 34);
            textBoxPostnummer.TabIndex = 10;
            // 
            // textBoxBynavn
            // 
            textBoxBynavn.Location = new Point(244, 379);
            textBoxBynavn.Margin = new Padding(3, 4, 3, 4);
            textBoxBynavn.Name = "textBoxBynavn";
            textBoxBynavn.Size = new Size(304, 34);
            textBoxBynavn.TabIndex = 12;
            // 
            // btnGem
            // 
            btnGem.FlatAppearance.BorderSize = 3;
            btnGem.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 195, 21);
            btnGem.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnGem.FlatStyle = FlatStyle.Flat;
            btnGem.Location = new Point(244, 952);
            btnGem.Margin = new Padding(3, 4, 3, 4);
            btnGem.Name = "btnGem";
            btnGem.Size = new Size(122, 56);
            btnGem.TabIndex = 27;
            btnGem.Text = "Gem";
            btnGem.UseVisualStyleBackColor = true;
            btnGem.Click += btnGem_Click;
            // 
            // checkBoxRækkehus
            // 
            checkBoxRækkehus.AutoSize = true;
            checkBoxRækkehus.Location = new Point(134, 99);
            checkBoxRækkehus.Margin = new Padding(3, 4, 3, 4);
            checkBoxRækkehus.Name = "checkBoxRækkehus";
            checkBoxRækkehus.Size = new Size(133, 32);
            checkBoxRækkehus.TabIndex = 2;
            checkBoxRækkehus.Text = "Rækkehus";
            checkBoxRækkehus.UseVisualStyleBackColor = true;
            checkBoxRækkehus.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // checkBoxLejlighed
            // 
            checkBoxLejlighed.AutoSize = true;
            checkBoxLejlighed.Location = new Point(294, 99);
            checkBoxLejlighed.Margin = new Padding(3, 4, 3, 4);
            checkBoxLejlighed.Name = "checkBoxLejlighed";
            checkBoxLejlighed.Size = new Size(121, 32);
            checkBoxLejlighed.TabIndex = 3;
            checkBoxLejlighed.Text = "Lejlighed";
            checkBoxLejlighed.UseVisualStyleBackColor = true;
            checkBoxLejlighed.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // checkBoxAndelsbolig
            // 
            checkBoxAndelsbolig.AutoSize = true;
            checkBoxAndelsbolig.Location = new Point(440, 99);
            checkBoxAndelsbolig.Margin = new Padding(3, 4, 3, 4);
            checkBoxAndelsbolig.Name = "checkBoxAndelsbolig";
            checkBoxAndelsbolig.Size = new Size(146, 32);
            checkBoxAndelsbolig.TabIndex = 4;
            checkBoxAndelsbolig.Text = "Andelsbolig";
            checkBoxAndelsbolig.UseVisualStyleBackColor = true;
            checkBoxAndelsbolig.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // labelAreal
            // 
            labelAreal.AutoSize = true;
            labelAreal.Location = new Point(36, 448);
            labelAreal.Name = "labelAreal";
            labelAreal.Size = new Size(58, 28);
            labelAreal.TabIndex = 13;
            labelAreal.Text = "Areal";
            // 
            // labelHandelspris
            // 
            labelHandelspris.AutoSize = true;
            labelHandelspris.Location = new Point(36, 517);
            labelHandelspris.Name = "labelHandelspris";
            labelHandelspris.Size = new Size(119, 28);
            labelHandelspris.TabIndex = 15;
            labelHandelspris.Text = "Handelspris";
            // 
            // labelHandelsdato
            // 
            labelHandelsdato.AutoSize = true;
            labelHandelsdato.Location = new Point(36, 588);
            labelHandelsdato.Name = "labelHandelsdato";
            labelHandelsdato.Size = new Size(127, 28);
            labelHandelsdato.TabIndex = 17;
            labelHandelsdato.Text = "Handelsdato";
            // 
            // labelTilSalg
            // 
            labelTilSalg.AutoSize = true;
            labelTilSalg.Location = new Point(36, 659);
            labelTilSalg.Name = "labelTilSalg";
            labelTilSalg.Size = new Size(75, 28);
            labelTilSalg.TabIndex = 19;
            labelTilSalg.Text = "Til salg";
            // 
            // labelSælger
            // 
            labelSælger.AutoSize = true;
            labelSælger.Location = new Point(36, 728);
            labelSælger.Name = "labelSælger";
            labelSælger.Size = new Size(75, 28);
            labelSælger.TabIndex = 21;
            labelSælger.Text = "Sælger";
            // 
            // labelKøber
            // 
            labelKøber.AutoSize = true;
            labelKøber.Location = new Point(36, 797);
            labelKøber.Name = "labelKøber";
            labelKøber.Size = new Size(66, 28);
            labelKøber.TabIndex = 23;
            labelKøber.Text = "Køber";
            // 
            // labelEjendomsmægler
            // 
            labelEjendomsmægler.AutoSize = true;
            labelEjendomsmægler.Location = new Point(36, 868);
            labelEjendomsmægler.Name = "labelEjendomsmægler";
            labelEjendomsmægler.Size = new Size(171, 28);
            labelEjendomsmægler.TabIndex = 25;
            labelEjendomsmægler.Text = "Ejendomsmægler";
            // 
            // textBoxAreal
            // 
            textBoxAreal.Location = new Point(244, 448);
            textBoxAreal.Margin = new Padding(3, 4, 3, 4);
            textBoxAreal.Name = "textBoxAreal";
            textBoxAreal.Size = new Size(304, 34);
            textBoxAreal.TabIndex = 14;
            // 
            // textBoxHandelspris
            // 
            textBoxHandelspris.Location = new Point(244, 517);
            textBoxHandelspris.Margin = new Padding(3, 4, 3, 4);
            textBoxHandelspris.Name = "textBoxHandelspris";
            textBoxHandelspris.Size = new Size(304, 34);
            textBoxHandelspris.TabIndex = 16;
            // 
            // dateTimePickerHandelsdato
            // 
            dateTimePickerHandelsdato.Location = new Point(244, 588);
            dateTimePickerHandelsdato.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerHandelsdato.Name = "dateTimePickerHandelsdato";
            dateTimePickerHandelsdato.Size = new Size(304, 34);
            dateTimePickerHandelsdato.TabIndex = 18;
            // 
            // checkBoxTilSalg
            // 
            checkBoxTilSalg.AutoSize = true;
            checkBoxTilSalg.Location = new Point(244, 666);
            checkBoxTilSalg.Margin = new Padding(3, 4, 3, 4);
            checkBoxTilSalg.Name = "checkBoxTilSalg";
            checkBoxTilSalg.Size = new Size(22, 21);
            checkBoxTilSalg.TabIndex = 20;
            checkBoxTilSalg.UseVisualStyleBackColor = true;
            // 
            // comboBoxSælger
            // 
            comboBoxSælger.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSælger.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxSælger.FormattingEnabled = true;
            comboBoxSælger.Location = new Point(244, 728);
            comboBoxSælger.Margin = new Padding(3, 4, 3, 4);
            comboBoxSælger.Name = "comboBoxSælger";
            comboBoxSælger.Size = new Size(304, 36);
            comboBoxSælger.TabIndex = 22;
            // 
            // comboBoxKøber
            // 
            comboBoxKøber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxKøber.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxKøber.FormattingEnabled = true;
            comboBoxKøber.Location = new Point(244, 797);
            comboBoxKøber.Margin = new Padding(3, 4, 3, 4);
            comboBoxKøber.Name = "comboBoxKøber";
            comboBoxKøber.Size = new Size(304, 36);
            comboBoxKøber.TabIndex = 24;
            // 
            // comboBoxEjendomsmægler
            // 
            comboBoxEjendomsmægler.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxEjendomsmægler.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxEjendomsmægler.FormattingEnabled = true;
            comboBoxEjendomsmægler.Location = new Point(244, 868);
            comboBoxEjendomsmægler.Margin = new Padding(3, 4, 3, 4);
            comboBoxEjendomsmægler.Name = "comboBoxEjendomsmægler";
            comboBoxEjendomsmægler.Size = new Size(304, 36);
            comboBoxEjendomsmægler.TabIndex = 26;
            // 
            // RedigerBoligForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 69, 115);
            ClientSize = new Size(612, 1051);
            Controls.Add(btnGem);
            Controls.Add(comboBoxEjendomsmægler);
            Controls.Add(comboBoxKøber);
            Controls.Add(comboBoxSælger);
            Controls.Add(checkBoxTilSalg);
            Controls.Add(dateTimePickerHandelsdato);
            Controls.Add(textBoxHandelspris);
            Controls.Add(textBoxAreal);
            Controls.Add(labelEjendomsmægler);
            Controls.Add(labelKøber);
            Controls.Add(labelSælger);
            Controls.Add(labelTilSalg);
            Controls.Add(labelHandelsdato);
            Controls.Add(labelHandelspris);
            Controls.Add(labelAreal);
            Controls.Add(labelBynavn);
            Controls.Add(textBoxBynavn);
            Controls.Add(labelPostnummer);
            Controls.Add(textBoxPostnummer);
            Controls.Add(labelNummer);
            Controls.Add(textBoxNummer);
            Controls.Add(labelVejnavn);
            Controls.Add(textBoxVejnavn);
            Controls.Add(checkBoxAndelsbolig);
            Controls.Add(checkBoxLejlighed);
            Controls.Add(checkBoxRækkehus);
            Controls.Add(checkBoxHus);
            Controls.Add(labelRedigerBolig);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RedigerBoligForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rediger bolig - Administrativt IT-system";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRedigerBolig;
        private CheckBox checkBoxHus;
        private Label labelVejnavn;
        private Label labelNummer;
        private Label labelPostnummer;
        private Label labelBynavn;
        private TextBox textBoxVejnavn;
        private TextBox textBoxNummer;
        private TextBox textBoxPostnummer;
        private TextBox textBoxBynavn;
        private Button btnGem;
        private CheckBox checkBoxRækkehus;
        private CheckBox checkBoxLejlighed;
        private CheckBox checkBoxAndelsbolig;
        private Label labelAreal;
        private Label labelHandelspris;
        private Label labelHandelsdato;
        private Label labelTilSalg;
        private Label labelSælger;
        private Label labelKøber;
        private Label labelEjendomsmægler;
        private TextBox textBoxAreal;
        private TextBox textBoxHandelspris;
        private DateTimePicker dateTimePickerHandelsdato;
        private CheckBox checkBoxTilSalg;
        private ComboBox comboBoxSælger;
        private ComboBox comboBoxKøber;
        private ComboBox comboBoxEjendomsmægler;
    }
}