using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppAdoNet;

namespace WindowsFormseNTİTYfRAMEwORK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunDbModel context = new UrunDbModel(); // UrunDbModel sınıfından model nesnesi oluşturuyoruz
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvUrunListesi.DataSource = context.Products.ToList(); // context nesnesi üzerinden Products tablosunu listeleyip datagridview e atıyoruz
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var urun = new Product
                {
                    UrunAdi = txtUrunAdi.Text,
                    StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                    UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text),
                    Durum = cbDurum.Checked
                };
                context.Products.Add(urun); // context nesnesindeki products tablosuna ürünü ekle
                int sonuc = context.SaveChanges(); // context deki değişiklikleri veritabanına yansıt
                if (sonuc > 0)
                {
                    dgvUrunListesi.DataSource = context.Products.ToList();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!");
            }
        }

        private void dgvUrunListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dgvUrunListesi.CurrentRow.Cells[1].Value.ToString();
            txtUrunFiyati.Text = dgvUrunListesi.CurrentRow.Cells[2].Value.ToString();
            txtStokMiktari.Text = dgvUrunListesi.CurrentRow.Cells[3].Value.ToString();
            cbDurum.Checked = (bool)dgvUrunListesi.CurrentRow.Cells[4].Value;

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvUrunListesi.CurrentRow.Cells[0].Value; // seçili satırdaki Id değerini al
                var urun = context.Products.Find(id);
                urun.UrunAdi = txtUrunAdi.Text;
                urun.StokMiktari = Convert.ToInt32(txtStokMiktari.Text);    
                urun.UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text);    
                urun.Durum = cbDurum.Checked;

                int sonuc = context.SaveChanges(); // context deki değişiklikleri veritabanına yansıt
                if (sonuc > 0)
                {
                    dgvUrunListesi.DataSource = context.Products.ToList();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!" + hata.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydı Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var product = context.Products.Find((int)dgvUrunListesi.CurrentRow.Cells[0].Value);

                    context.Products.Remove(product);

                    int sonuc = context.SaveChanges();
                    if (sonuc > 0)
                    {
                        dgvUrunListesi.DataSource = context.Products.ToList();
                        btnEkle.Enabled = true;
                        btnGuncelle.Enabled = false;
                        btnSil.Enabled = false;
                        MessageBox.Show("Kayıt Silindi!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata Oluştu!");
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvUrunListesi.DataSource = context.Products.Where(p=>p.UrunAdi.Contains(txtAra.Text)).ToList();
        }
    }
}
