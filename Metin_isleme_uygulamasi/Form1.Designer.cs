namespace Metin_isleme_uygulamasi
{
    partial class Form1
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
            txtMetin = new TextBox();
            txtYardimci = new TextBox();
            btnArama = new Button();
            btnBirlestirme = new Button();
            btnDegiştirme = new Button();
            btnSilme = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtMetin
            // 
            txtMetin.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            txtMetin.Location = new Point(149, 91);
            txtMetin.Multiline = true;
            txtMetin.Name = "txtMetin";
            txtMetin.Size = new Size(211, 30);
            txtMetin.TabIndex = 1;
            // 
            // txtYardimci
            // 
            txtYardimci.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            txtYardimci.Location = new Point(605, 91);
            txtYardimci.Multiline = true;
            txtYardimci.Name = "txtYardimci";
            txtYardimci.Size = new Size(199, 30);
            txtYardimci.TabIndex = 2;
            // 
            // btnArama
            // 
            btnArama.BackColor = Color.FromArgb(255, 255, 192);
            btnArama.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            btnArama.Location = new Point(70, 225);
            btnArama.Name = "btnArama";
            btnArama.Size = new Size(130, 47);
            btnArama.TabIndex = 2;
            btnArama.Text = "Arama";
            btnArama.UseVisualStyleBackColor = false;
            btnArama.Click += btnArama_Click;
            // 
            // btnBirlestirme
            // 
            btnBirlestirme.BackColor = Color.FromArgb(255, 255, 192);
            btnBirlestirme.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            btnBirlestirme.Location = new Point(278, 225);
            btnBirlestirme.Name = "btnBirlestirme";
            btnBirlestirme.Size = new Size(130, 47);
            btnBirlestirme.TabIndex = 3;
            btnBirlestirme.Text = "Birleştirme";
            btnBirlestirme.UseVisualStyleBackColor = false;
            btnBirlestirme.Click += btnBirlestirme_Click;
            // 
            // btnDegiştirme
            // 
            btnDegiştirme.BackColor = Color.FromArgb(255, 255, 192);
            btnDegiştirme.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            btnDegiştirme.Location = new Point(469, 225);
            btnDegiştirme.Name = "btnDegiştirme";
            btnDegiştirme.Size = new Size(130, 47);
            btnDegiştirme.TabIndex = 4;
            btnDegiştirme.Text = "Değiştirme";
            btnDegiştirme.UseVisualStyleBackColor = false;
            btnDegiştirme.Click += btnDegiştirme_Click;
            // 
            // btnSilme
            // 
            btnSilme.BackColor = Color.FromArgb(255, 255, 192);
            btnSilme.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            btnSilme.Location = new Point(683, 225);
            btnSilme.Name = "btnSilme";
            btnSilme.Size = new Size(130, 47);
            btnSilme.TabIndex = 5;
            btnSilme.Text = "Silme";
            btnSilme.UseVisualStyleBackColor = false;
            btnSilme.Click += btnSilme_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label1.Location = new Point(30, 97);
            label1.Name = "label1";
            label1.Size = new Size(113, 24);
            label1.TabIndex = 6;
            label1.Text = "Metin Girin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Bold);
            label2.Location = new Point(400, 97);
            label2.Name = "label2";
            label2.Size = new Size(199, 24);
            label2.TabIndex = 7;
            label2.Text = "Yardimici metin Girin:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(909, 457);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSilme);
            Controls.Add(btnDegiştirme);
            Controls.Add(btnBirlestirme);
            Controls.Add(btnArama);
            Controls.Add(txtYardimci);
            Controls.Add(txtMetin);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Metin İşleme Uygulaması";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMetin;
        private TextBox txtYardimci;
        private Button btnArama;
        private Button btnBirlestirme;
        private Button btnDegiştirme;
        private Button btnSilme;
        private Label label1;
        private Label label2;
    }
}
