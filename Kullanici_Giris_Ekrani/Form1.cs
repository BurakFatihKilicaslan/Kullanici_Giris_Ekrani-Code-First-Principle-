using Kullanici_Giris_Ekrani.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Kullanici_Giris_Ekrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KullaniciKayitDBContext kkDb = new KullaniciKayitDBContext();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            var kullanici = kkDb.KullaniciBilgileris.FirstOrDefault(k => k.KullaniciMail == txtMail.Text);

            if (kullanici != null)
            {
                if (kullanici.KullaniciSifre == txtSifre.Text)
                {
                    MessageBox.Show("Giriş Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle.ControlTemizle(this.Controls);
                }
                else
                {
                    MessageBox.Show("Şifre yanlış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mail adresiniz yanlış veya kayıtlı değilsiniz. Kaydolmak için lütfen aşağıdaki linke tıklayınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void lnkKaydol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciKayitEkrani kayit = new KullaniciKayitEkrani();
            kayit.ShowDialog();
        }
    }
}