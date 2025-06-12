using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;


namespace Kütüphane_Takip_Sistemi
{

    public partial class Form1 : Form
    {
        List<Kitap> kitaplar = new List<Kitap>();
        string dosyaYolu = "kitaplar.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KitaplariYukle();
            //dgvKitaplar.AutoGenerateColumns = true;

            // Sadece ödünçte olmayanları göster
            cmbKitaplar.DataSource = kitaplar.Where(k => !k.OduncDurumu).ToList();
            cmbKitaplar.DisplayMember = "Ad";
            dgvKitaplar.AutoGenerateColumns = true;

            cmbOduncler.DataSource = kitaplar.Where(k => k.OduncDurumu).ToList();
            cmbOduncler.DisplayMember = "Ad";

        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitap yeniKitap = new Kitap
            {
                ISBN = txtISBN.Text,
                Ad = txtAd.Text,
                Yazar = txtYazar.Text,
                OduncDurumu = false

            };

            kitaplar.Add(yeniKitap);
            MessageBox.Show("Kitap başarıyla eklendi.");

            txtISBN.Clear();
            txtAd.Clear();
            txtYazar.Clear();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvKitaplar.DataSource = null;
            dgvKitaplar.DataSource = kitaplar;

        }
        // 🟫 Listeyi JSON dosyasına yazar
        private void KitaplariKaydet()
        {
            try
            {
                string json = JsonSerializer.Serialize(kitaplar, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(dosyaYolu, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message);
            }
        }
        private void KitaplariYukle()
        {
            try
            {
                if (File.Exists(dosyaYolu))
                {
                    string json = File.ReadAllText(dosyaYolu);
                    kitaplar = JsonSerializer.Deserialize<List<Kitap>>(json) ?? new List<Kitap>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yükleme sırasında hata oluştu: " + ex.Message);
            }
        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            Kitap secilen = cmbKitaplar.SelectedItem as Kitap;
            if (secilen != null)
            {
                secilen.OduncDurumu = true;
                secilen.IadeTarihi = dtpIadeTarihi.Value;

                KitaplariKaydet();
                MessageBox.Show("Kitap ödünç verildi.");

                cmbKitaplar.DataSource = kitaplar.Where(k => !k.OduncDurumu).ToList();
                cmbOduncler.DataSource = kitaplar.Where(k => k.OduncDurumu).ToList();

                dgvKitaplar.DataSource = null;
                dgvKitaplar.DataSource = kitaplar;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap secilen = cmbOduncler.SelectedItem as Kitap;
            if (secilen != null)
            {
                secilen.OduncDurumu = false;

                // Gerekirse IadeTarihi'ni güncelle
                // (Iade tarihi tutuluyorsa: DateTime.Now)

                KitaplariKaydet();
                MessageBox.Show("Kitap başarıyla iade edildi.");

                // Arayüzü yenile
                cmbOduncler.DataSource = kitaplar.Where(k => k.OduncDurumu).ToList();
                cmbKitaplar.DataSource = kitaplar.Where(k => !k.OduncDurumu).ToList();

                dgvKitaplar.DataSource = null;
                dgvKitaplar.DataSource = kitaplar;
            }

        }

        private void btnGecikenleriListele_Click(object sender, EventArgs e)
        {
            /*var gecikenler = kitaplar
                .Where(k => k.OduncDurumu && k.IadeTarihi.HasValue && k.IadeTarihi.Value < DateTime.Now)
                .Select(k => new
                {
                    k.ISBN,
                    k.Ad,
                    k.Yazar,
                    IadeTarihi = k.IadeTarihi.Value.ToShortDateString()
                })
                .ToList();

            dgvGecikenler.DataSource = null;
            dgvGecikenler.DataSource = gecikenler;*/
        }

        private void btnGecikenleriListele_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // GecikenleriListele();
        }

        private void btnGecikenleriListele_Click_2(object sender, EventArgs e)
        {
            var gecikenler = kitaplar
        .Where(k => k.OduncDurumu && k.IadeTarihi.HasValue && k.IadeTarihi.Value < DateTime.Now)
        .Select(k => new
        {
            ISBN = k.ISBN,
            Ad = k.Ad,
            Yazar = k.Yazar,
            IadeTarihi = k.IadeTarihi.Value.ToShortDateString()
        })
        .ToList();

            dgvGecikenler.DataSource = null;
            dgvGecikenler.DataSource = gecikenler;
        }
    }
}
