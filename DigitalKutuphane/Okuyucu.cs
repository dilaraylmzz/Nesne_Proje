using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKutuphane
{
    internal class Okuyucu : Kullanici
    {
        private int okunanKitapSayisi;  // Kapsülleme (encapsulation)

        public Okuyucu(string adSoyad, string eposta) : base(adSoyad, eposta) // Kalıtım
        {
            okunanKitapSayisi = 0;
        }

        public void KitapSayisiniArttir()
        {
            okunanKitapSayisi++;
        }

        public int OkunanKitapSayisi
        {
            get { return okunanKitapSayisi; }
        }

        // Polimorfizm (override)
        public override string BilgiGetir()
        {
            return $"Okuyucu: {AdSoyad}, E-Posta: {Eposta}, Okunan Kitap Sayısı: {okunanKitapSayisi}";
        }
    }
}
