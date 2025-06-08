using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKutuphane
{
    internal class Alinti
    {
        public string Metin { get; set; }
        public DateTime EklenmeTarihi { get; set; }

        public Alinti(string metin)
        {
            Metin = metin;
            EklenmeTarihi = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Metin} ({EklenmeTarihi.ToShortDateString()})";
        }
    }

}
