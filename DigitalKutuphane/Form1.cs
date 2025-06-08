using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalKutuphane
{
    public partial class Form1 : Form
    {
        private List<Kitap> kitaplar = new List<Kitap>();
        private Okuyucu aktifOkuyucu = new Okuyucu("Ali Veli", "ali@example.com");

        public Form1()
        {
            InitializeComponent();
            aktifOkuyucu = new Okuyucu("Ali Veli", "ali@example.com");
            lblOkuyucuBilgi.Text = aktifOkuyucu.BilgiGetir(); // Label'a yazdır

            cmbTur.Items.AddRange(new string[]
            { "Roman",
              "Tarih",
              "Bilim",
              "Felsefe",
              "Fantastik",
              "Biyografi"
            });
            cmbTur.SelectedIndex = -1;

            

        }

        private void txtBaslik_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYazar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlinti_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            string baslik = txtBaslik.Text;
            string yazar = txtYazar.Text;
            string tur = cmbTur.SelectedItem?.ToString() ?? "Bilinmiyor";
            int sayfa;
            if (!int.TryParse(txtSayfa.Text, out sayfa))
            {
                MessageBox.Show("Sayfa sayısı geçerli bir sayı olmalıdır.");
                return;
            }

            DateTime baslangic = dtpBaslangic.Value;
            DateTime bitis = dtpBitis.Value;

            Kitap yeniKitap = new Kitap(baslik, yazar, tur, sayfa, baslangic, bitis);
            kitaplar.Add(yeniKitap);
            listBoxKitaplar.Items.Add(yeniKitap);

            aktifOkuyucu.KitapSayisiniArttir();
            MessageBox.Show("Kitap başarıyla eklendi.");
        }

        private void btnAlintiEkle_Click(object sender, EventArgs e)
        {
            if (listBoxKitaplar.SelectedItem is Kitap seciliKitap)
            {
                string metin = txtAlinti.Text.Trim();
                if (string.IsNullOrEmpty(metin))
                {
                    MessageBox.Show("Alıntı boş olamaz.");
                    return;
                }

                Alinti yeniAlinti = new Alinti(metin);
                seciliKitap.AlintiEkle(yeniAlinti);

                listBoxAlintilar.Items.Clear();
                foreach (var alinti in seciliKitap.AlintilariGetir())
                {
                    listBoxAlintilar.Items.Add(alinti);
                }

                txtAlinti.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen önce bir kitap seçin.");
            }
        }

        private void listBoxKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxKitaplar.SelectedItem is Kitap seciliKitap)
            {
                listBoxAlintilar.Items.Clear();
                foreach (var alinti in seciliKitap.AlintilariGetir())
                {
                    listBoxAlintilar.Items.Add(alinti);
                }
            }
        }

        private void listBoxAlintilar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelBaslik_Click(object sender, EventArgs e)
        {

        }

        private void labelYazar_Click(object sender, EventArgs e)
        {

        }

        private void labelTur_Click(object sender, EventArgs e)
        {

        }

        private void labelSayfa_Click(object sender, EventArgs e)
        {

        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblOkuyucuBilgi_Click(object sender, EventArgs e)
        {

        }
    }
}
