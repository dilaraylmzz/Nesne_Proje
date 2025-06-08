namespace DigitalKutuphane
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtAlinti = new System.Windows.Forms.TextBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnAlintiEkle = new System.Windows.Forms.Button();
            this.listBoxKitaplar = new System.Windows.Forms.ListBox();
            this.listBoxAlintilar = new System.Windows.Forms.ListBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.labelYazar = new System.Windows.Forms.Label();
            this.labelAlinti = new System.Windows.Forms.Label();
            this.labelSayfa = new System.Windows.Forms.Label();
            this.labelTur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOkuyucuBilgi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBaslik
            // 
            this.txtBaslik.BackColor = System.Drawing.Color.LightCyan;
            this.txtBaslik.Location = new System.Drawing.Point(116, 37);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(100, 22);
            this.txtBaslik.TabIndex = 0;
            this.txtBaslik.TextChanged += new System.EventHandler(this.txtBaslik_TextChanged);
            // 
            // txtYazar
            // 
            this.txtYazar.BackColor = System.Drawing.Color.LightCyan;
            this.txtYazar.Location = new System.Drawing.Point(116, 84);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(100, 22);
            this.txtYazar.TabIndex = 1;
            this.txtYazar.TextChanged += new System.EventHandler(this.txtYazar_TextChanged);
            // 
            // txtAlinti
            // 
            this.txtAlinti.BackColor = System.Drawing.Color.LightCyan;
            this.txtAlinti.Location = new System.Drawing.Point(901, 34);
            this.txtAlinti.Name = "txtAlinti";
            this.txtAlinti.Size = new System.Drawing.Size(267, 22);
            this.txtAlinti.TabIndex = 2;
            this.txtAlinti.TextChanged += new System.EventHandler(this.txtAlinti_TextChanged);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKitapEkle.Location = new System.Drawing.Point(40, 220);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(153, 56);
            this.btnKitapEkle.TabIndex = 3;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = false;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnAlintiEkle
            // 
            this.btnAlintiEkle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAlintiEkle.Location = new System.Drawing.Point(851, 73);
            this.btnAlintiEkle.Name = "btnAlintiEkle";
            this.btnAlintiEkle.Size = new System.Drawing.Size(156, 54);
            this.btnAlintiEkle.TabIndex = 4;
            this.btnAlintiEkle.Text = "Alıntı Ekle";
            this.btnAlintiEkle.UseVisualStyleBackColor = false;
            this.btnAlintiEkle.Click += new System.EventHandler(this.btnAlintiEkle_Click);
            // 
            // listBoxKitaplar
            // 
            this.listBoxKitaplar.BackColor = System.Drawing.Color.White;
            this.listBoxKitaplar.FormattingEnabled = true;
            this.listBoxKitaplar.ItemHeight = 16;
            this.listBoxKitaplar.Location = new System.Drawing.Point(40, 282);
            this.listBoxKitaplar.Name = "listBoxKitaplar";
            this.listBoxKitaplar.Size = new System.Drawing.Size(165, 148);
            this.listBoxKitaplar.TabIndex = 5;
            this.listBoxKitaplar.SelectedIndexChanged += new System.EventHandler(this.listBoxKitaplar_SelectedIndexChanged);
            // 
            // listBoxAlintilar
            // 
            this.listBoxAlintilar.FormattingEnabled = true;
            this.listBoxAlintilar.ItemHeight = 16;
            this.listBoxAlintilar.Location = new System.Drawing.Point(851, 145);
            this.listBoxAlintilar.Name = "listBoxAlintilar";
            this.listBoxAlintilar.Size = new System.Drawing.Size(326, 244);
            this.listBoxAlintilar.TabIndex = 6;
            this.listBoxAlintilar.SelectedIndexChanged += new System.EventHandler(this.listBoxAlintilar_SelectedIndexChanged);
            // 
            // cmbTur
            // 
            this.cmbTur.BackColor = System.Drawing.Color.LightCyan;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(116, 170);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 24);
            this.cmbTur.TabIndex = 7;
            this.cmbTur.SelectedIndexChanged += new System.EventHandler(this.cmbTur_SelectedIndexChanged);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(473, 35);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(218, 22);
            this.dtpBaslangic.TabIndex = 8;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(473, 81);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(218, 22);
            this.dtpBitis.TabIndex = 9;
            // 
            // txtSayfa
            // 
            this.txtSayfa.BackColor = System.Drawing.Color.LightCyan;
            this.txtSayfa.Location = new System.Drawing.Point(116, 125);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(100, 22);
            this.txtSayfa.TabIndex = 10;
            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.Location = new System.Drawing.Point(12, 37);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(60, 16);
            this.labelBaslik.TabIndex = 11;
            this.labelBaslik.Text = "Kitap Adı";
            this.labelBaslik.Click += new System.EventHandler(this.labelBaslik_Click);
            // 
            // labelYazar
            // 
            this.labelYazar.AutoSize = true;
            this.labelYazar.Location = new System.Drawing.Point(12, 87);
            this.labelYazar.Name = "labelYazar";
            this.labelYazar.Size = new System.Drawing.Size(78, 16);
            this.labelYazar.TabIndex = 12;
            this.labelYazar.Text = "Kitap Yazarı";
            this.labelYazar.Click += new System.EventHandler(this.labelYazar_Click);
            // 
            // labelAlinti
            // 
            this.labelAlinti.AutoSize = true;
            this.labelAlinti.Location = new System.Drawing.Point(813, 35);
            this.labelAlinti.Name = "labelAlinti";
            this.labelAlinti.Size = new System.Drawing.Size(70, 16);
            this.labelAlinti.TabIndex = 13;
            this.labelAlinti.Text = "Alıntı Metni";
            // 
            // labelSayfa
            // 
            this.labelSayfa.AutoSize = true;
            this.labelSayfa.Location = new System.Drawing.Point(12, 131);
            this.labelSayfa.Name = "labelSayfa";
            this.labelSayfa.Size = new System.Drawing.Size(82, 16);
            this.labelSayfa.TabIndex = 14;
            this.labelSayfa.Text = "Sayfa Sayısı";
            this.labelSayfa.Click += new System.EventHandler(this.labelSayfa_Click);
            // 
            // labelTur
            // 
            this.labelTur.AutoSize = true;
            this.labelTur.Location = new System.Drawing.Point(15, 170);
            this.labelTur.Name = "labelTur";
            this.labelTur.Size = new System.Drawing.Size(67, 16);
            this.labelTur.TabIndex = 15;
            this.labelTur.Text = "Kitap Türü";
            this.labelTur.Click += new System.EventHandler(this.labelTur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kitap Başlangıç  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kitap Bitiş";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOkuyucuBilgi
            // 
            this.lblOkuyucuBilgi.AutoSize = true;
            this.lblOkuyucuBilgi.Location = new System.Drawing.Point(367, 371);
            this.lblOkuyucuBilgi.Name = "lblOkuyucuBilgi";
            this.lblOkuyucuBilgi.Size = new System.Drawing.Size(44, 16);
            this.lblOkuyucuBilgi.TabIndex = 18;
            this.lblOkuyucuBilgi.Text = "label3";
            this.lblOkuyucuBilgi.Click += new System.EventHandler(this.lblOkuyucuBilgi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1189, 439);
            this.Controls.Add(this.lblOkuyucuBilgi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTur);
            this.Controls.Add(this.labelSayfa);
            this.Controls.Add(this.labelAlinti);
            this.Controls.Add(this.labelYazar);
            this.Controls.Add(this.labelBaslik);
            this.Controls.Add(this.txtSayfa);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.listBoxAlintilar);
            this.Controls.Add(this.listBoxKitaplar);
            this.Controls.Add(this.btnAlintiEkle);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.txtAlinti);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtBaslik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtAlinti;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnAlintiEkle;
        private System.Windows.Forms.ListBox listBoxKitaplar;
        private System.Windows.Forms.ListBox listBoxAlintilar;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.Label labelYazar;
        private System.Windows.Forms.Label labelAlinti;
        private System.Windows.Forms.Label labelSayfa;
        private System.Windows.Forms.Label labelTur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOkuyucuBilgi;
    }
}

