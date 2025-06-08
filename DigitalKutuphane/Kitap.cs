using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKutuphane
{
    internal class Kitap
    {
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public string Tur { get; set; }
        public int SayfaSayisi { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

        private List<Alinti> alintilar = new List<Alinti>();

        public Kitap(string baslik, string yazar, string tur, int sayfaSayisi, DateTime baslangic, DateTime bitis)
        {
            Baslik = baslik;
            Yazar = yazar;
            Tur = tur;
            SayfaSayisi = sayfaSayisi;
            BaslangicTarihi = baslangic;
            BitisTarihi = bitis;
        }

        public void AlintiEkle(Alinti alinti)
        {
            alintilar.Add(alinti);
        }

        public List<Alinti> AlintilariGetir()
        {
            return alintilar;
        }

        public override string ToString()
        {
            return $"{Baslik} - {Yazar}";
        }
    }
}
