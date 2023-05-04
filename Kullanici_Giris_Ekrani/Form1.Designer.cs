namespace Kullanici_Giris_Ekrani
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
            txtMail = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lnkKaydol = new LinkLabel();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Location = new Point(100, 61);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "forexample@gmail.com";
            txtMail.Size = new Size(159, 23);
            txtMail.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(100, 109);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(159, 23);
            txtSifre.TabIndex = 0;
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Location = new Point(100, 158);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(159, 30);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(91, 18);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 4;
            label1.Text = "Hoş Geldiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 61);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 109);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 6;
            label3.Text = "Şifre:";
            // 
            // lnkKaydol
            // 
            lnkKaydol.AutoSize = true;
            lnkKaydol.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lnkKaydol.Location = new Point(199, 216);
            lnkKaydol.Name = "lnkKaydol";
            lnkKaydol.Size = new Size(65, 23);
            lnkKaydol.TabIndex = 3;
            lnkKaydol.TabStop = true;
            lnkKaydol.Text = "Kaydol";
            lnkKaydol.LinkClicked += lnkKaydol_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 265);
            Controls.Add(lnkKaydol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtMail);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private TextBox txtSifre;
        private Button btnGiris;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel lnkKaydol;
    }
}