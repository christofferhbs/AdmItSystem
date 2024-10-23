namespace AdmItSystem.WinForms
{
    partial class EksportForm
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

        private void InitializeComponent()
        {
            btnEksporterHuseTilSalg = new Button();
            btnEksporterHuseFraOmråde = new Button();
            textBoxOmråde = new TextBox();
            labelOmråde = new Label();
            folderBrowserDialogPath = new FolderBrowserDialog();
            panel1 = new Panel();
            saveFileDialogPath = new SaveFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEksporterHuseTilSalg
            // 
            btnEksporterHuseTilSalg.FlatAppearance.BorderSize = 3;
            btnEksporterHuseTilSalg.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 195, 21);
            btnEksporterHuseTilSalg.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnEksporterHuseTilSalg.FlatStyle = FlatStyle.Flat;
            btnEksporterHuseTilSalg.Location = new Point(277, 288);
            btnEksporterHuseTilSalg.Margin = new Padding(3, 4, 3, 4);
            btnEksporterHuseTilSalg.Name = "btnEksporterHuseTilSalg";
            btnEksporterHuseTilSalg.Size = new Size(333, 62);
            btnEksporterHuseTilSalg.TabIndex = 0;
            btnEksporterHuseTilSalg.Text = "Eksporter alle boliger til salg";
            btnEksporterHuseTilSalg.UseVisualStyleBackColor = true;
            btnEksporterHuseTilSalg.Click += btnEksporterBoligerTilSalg_Click;
            // 
            // btnEksporterHuseFraOmråde
            // 
            btnEksporterHuseFraOmråde.FlatAppearance.BorderSize = 3;
            btnEksporterHuseFraOmråde.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 195, 21);
            btnEksporterHuseFraOmråde.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnEksporterHuseFraOmråde.FlatStyle = FlatStyle.Flat;
            btnEksporterHuseFraOmråde.Location = new Point(714, 288);
            btnEksporterHuseFraOmråde.Margin = new Padding(3, 4, 3, 4);
            btnEksporterHuseFraOmråde.Name = "btnEksporterHuseFraOmråde";
            btnEksporterHuseFraOmråde.Size = new Size(333, 62);
            btnEksporterHuseFraOmråde.TabIndex = 1;
            btnEksporterHuseFraOmråde.Text = "Eksporter boliger fra område";
            btnEksporterHuseFraOmråde.UseVisualStyleBackColor = true;
            btnEksporterHuseFraOmråde.Click += btnEksporterBoligerFraOmråde_Click;
            // 
            // textBoxOmråde
            // 
            textBoxOmråde.Location = new Point(714, 416);
            textBoxOmråde.Margin = new Padding(3, 4, 3, 4);
            textBoxOmråde.Name = "textBoxOmråde";
            textBoxOmråde.Size = new Size(333, 34);
            textBoxOmråde.TabIndex = 2;
            // 
            // labelOmråde
            // 
            labelOmråde.AutoSize = true;
            labelOmråde.Location = new Point(714, 378);
            labelOmråde.Name = "labelOmråde";
            labelOmråde.Size = new Size(85, 28);
            labelOmråde.TabIndex = 3;
            labelOmråde.Text = "Område";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 69, 115);
            panel1.Controls.Add(btnEksporterHuseFraOmråde);
            panel1.Controls.Add(labelOmråde);
            panel1.Controls.Add(btnEksporterHuseTilSalg);
            panel1.Controls.Add(textBoxOmråde);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1566, 1011);
            panel1.TabIndex = 4;
            // 
            // saveFileDialogPath
            // 
            saveFileDialogPath.FileName = "boliger_til_salg.csv";
            saveFileDialogPath.Title = "Gem fil - Administrativt IT-system";
            // 
            // EksportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1566, 1011);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EksportForm";
            Text = "Eksport Data";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnEksporterHuseTilSalg;
        private System.Windows.Forms.Button btnEksporterHuseFraOmråde;
        private System.Windows.Forms.TextBox textBoxOmråde;
        private System.Windows.Forms.Label labelOmråde;
        private FolderBrowserDialog folderBrowserDialogPath;
        private Panel panel1;
        private SaveFileDialog saveFileDialogPath;
    }
}
