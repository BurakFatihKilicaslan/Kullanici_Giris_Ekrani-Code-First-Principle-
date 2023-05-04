namespace Kullanici_Giris_Ekrani
{
    partial class KullaniciKayitEkrani
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnKaydol = new Button();
            txtSifreKayit = new TextBox();
            txtEmailKayit = new TextBox();
            label4 = new Label();
            txtSifreTekrarKayit = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 114);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 6;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 66);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(86, 23);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 4;
            label1.Text = "Hoş Geldiniz";
            // 
            // btnKaydol
            // 
            btnKaydol.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydol.Location = new Point(141, 207);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(159, 30);
            btnKaydol.TabIndex = 3;
            btnKaydol.Text = "Kaydol";
            btnKaydol.UseVisualStyleBackColor = true;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // txtSifreKayit
            // 
            txtSifreKayit.Location = new Point(141, 114);
            txtSifreKayit.Name = "txtSifreKayit";
            txtSifreKayit.Size = new Size(159, 23);
            txtSifreKayit.TabIndex = 0;
            // 
            // txtEmailKayit
            // 
            txtEmailKayit.Location = new Point(141, 66);
            txtEmailKayit.Name = "txtEmailKayit";
            txtEmailKayit.PlaceholderText = "forexample@gmail.com";
            txtEmailKayit.Size = new Size(159, 23);
            txtEmailKayit.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 159);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 7;
            label4.Text = "Şifre Tekrar:";
            // 
            // txtSifreTekrarKayit
            // 
            txtSifreTekrarKayit.Location = new Point(141, 159);
            txtSifreTekrarKayit.Name = "txtSifreTekrarKayit";
            txtSifreTekrarKayit.Size = new Size(159, 23);
            txtSifreTekrarKayit.TabIndex = 2;
            // 
            // KullaniciKayitEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 290);
            Controls.Add(label4);
            Controls.Add(txtSifreTekrarKayit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydol);
            Controls.Add(txtSifreKayit);
            Controls.Add(txtEmailKayit);
            Name = "KullaniciKayitEkrani";
            Text = "Kullanıcı Kayıt Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnKaydol;
        private TextBox txtSifreKayit;
        private TextBox txtEmailKayit;
        private Label label4;
        private TextBox txtSifreTekrarKayit;
    }
}