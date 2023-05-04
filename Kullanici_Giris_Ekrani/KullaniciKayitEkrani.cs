using Kullanici_Giris_Ekrani.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanici_Giris_Ekrani
{
    public partial class KullaniciKayitEkrani : Form
    {
        public KullaniciKayitEkrani()
        {
            InitializeComponent();
        }
        KullaniciKayitDBContext kkDb = new KullaniciKayitDBContext();
        private void btnKaydol_Click(object sender, EventArgs e)
        {
            //27 ve 29.satırda doğru email formatının kontrolu icin Regex deseni kullanilmistir.. 
            KullaniciBilgileri kb = new KullaniciBilgileri();
            string email = txtEmailKayit.Text;
            string model = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string sifre = txtSifreKayit.Text;
            if (Regex.IsMatch(email, model))
            {
                if (!string.IsNullOrEmpty(sifre))
                {
                    // e-posta adresi doğru formatta ve şifre boş değil, işleme devam et
                    // kullanıcıyı kaydet vb.
                    if (sifre == txtSifreTekrarKayit.Text)
                    {
                        kb.KullaniciMail = email;
                        kb.KullaniciSifre = sifre;
                        kkDb.KullaniciBilgileris.Add(kb);
                        kkDb.SaveChanges();
                        MessageBox.Show("Kayıt başarılı","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle.ControlTemizle(this.Controls);
                        this.Close();                   
                    }
                    else
                    {
                        MessageBox.Show("Şifreler uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    // şifre boş, hata mesajı göster
                    MessageBox.Show("Lütfen bütün bilgileri giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // e-posta adresi doğru formatta değil, hata mesajı göster
                MessageBox.Show("Lütfen geçerli bir e-posta adresi girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
    }
}
