using System;
using System.Collections.Generic;

namespace Kullanici_Giris_Ekrani.Models
{
    public partial class KullaniciBilgileri
    {
        public int KullaniciId { get; set; }
        public string KullaniciMail { get; set; } = null!;
        public string KullaniciSifre { get; set; } = null!;
    }
}
