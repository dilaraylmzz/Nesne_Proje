using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKutuphane
{
    internal abstract class Kullanici
    {
        public string AdSoyad { get; set; }
        public string Eposta { get; set; }

        public Kullanici(string adSoyad, string eposta)
        {
            AdSoyad = adSoyad;
            Eposta = eposta;
        }

        public abstract string BilgiGetir();
    }
}
