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
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        UrunDbModel context = new UrunDbModel();

        public DateTime CreateDate { get; private set; }

        private void Kategoriler_Load(object sender, EventArgs e)
        {

            Yukle();

        }
        void Yukle()
        {
            dgvKategoriler.DataSource = context.Categories.ToList();

            btnEkle.Enabled = true;
            btnGuncelle1.Enabled = false;
            btnSil.Enabled = false;
            txtKategoriAdi.Text = string.Empty;
            txtKategoriAciklamasi.Text = "";
            cbDurum.Checked = false;
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {

            var kategori = new Category
            {
                Name = txtKategoriAdi.Text,
                Description = txtKategoriAciklamasi.Text,
                CreateDate = DateTime.Now,
                Durum = cbDurum.Checked
            };
            context.Categories.Add(kategori);
            int sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                //dgvKategoriler.DataSource = context.Categories.ToList();
                Yukle();
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
            }

            try
            { }
            catch (Exception)
            {

                MessageBox.Show("hata oluştu!");
            }
        }

        private void dgvKategoriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvKategoriler.CurrentRow.Cells[0].Value;
            var kayit = context.Categories.Find(id);

            #region Db den gelen kaydı ekrana doldur
            txtKategoriAdi.Text = kayit.Name;
            txtKategoriAciklamasi.Text = kayit.Description;
            cbDurum.Checked = kayit.Durum;

            #endregion
            btnEkle.Enabled = false;
            btnGuncelle1.Enabled = true;
            btnSil.Enabled = true;

        }

        private void btnGuncelle1_Click_1(object sender, EventArgs e)
        {
            int id = (int)dgvKategoriler.CurrentRow.Cells[0].Value;
            var kayit = context.Categories.Find(id);

            kayit.Name = txtKategoriAdi.Text;
            kayit.Description = txtKategoriAciklamasi.Text;
            kayit.Durum = cbDurum.Checked;

            int sonuc = context.SaveChanges();

            if (sonuc > 0)
            {
                //dgvKategoriler.DataSource = context.Categories.ToList();
                Yukle();
                MessageBox.Show("Güncelleme Başarılı!");
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız! Lütfen Tüm Alanları Doldurunuz!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dgvKategoriler.CurrentRow.Cells[0].Value;
            var kayit = context.Categories.Find(id);

            context.Categories.Remove(kayit);

            int sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                //dgvKategoriler.DataSource = context.Categories.ToList();
                Yukle();
                MessageBox.Show("Silme İşlemi Başarılı!");
            }
            else
            {
                MessageBox.Show("Silme İşlemi Başarısız! Lütfen Tüm Alanları Doldurunuz!");
            }
        }
    }
}

