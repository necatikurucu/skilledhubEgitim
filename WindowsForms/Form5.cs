using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciadi.Text))
            {
                MessageBox.Show("kullanıcı adı ve şifre boş geçilemez", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("kullanıcı adı ve şifre boş geçilemez", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                string veritabanındakiKullanici = "Admin",
                       veritabanındakiSifre = "1234";
                if (txtKullaniciadi.Text == veritabanındakiKullanici && txtSifre.Text == veritabanındakiSifre)
                {
                    this.Hide(); // bnu formuı gizle
                    Form4 form4 = new Form4();
                    form4.ShowDialog(); 
                }
                else
                {
                    MessageBox.Show("kullanıcı adı veya şifre yanlış", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // datagridview'e veri ekleme işlemi
            dgvUrunler.ColumnCount = 3; // kaç kolon ürün ekleyeceğimizi belirtiyoruz
            // kolon başlıklarını belirtiyoruz
            dgvUrunler.Columns[0].Name = "Ürün Adı";
            dgvUrunler.Columns[1].Name = "Kategori";
            dgvUrunler.Columns[2].Name = "Fiyat";

            // satıra yeni ürün bilgisi ekleme işlemi
            dgvUrunler.Rows.Add(cbKategoriler.SelectedItem.ToString() ,txtUrunAdi.Text, txtFiyati.Text);

            MessageBox.Show(cbKategoriler.SelectedItem + " kategorisine " + txtUrunAdi.Text + " ürünü eklendi");
        }

    }
}
