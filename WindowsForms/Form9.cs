using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsForms
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Dosya Seçiniz";
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.bmp)|*.bmp";
            // dosya seçme penceresinden  listelenecek dosya uzantıları
            openFileDialog1.FilterIndex=1; // varsayılan olarak ilk filtreyi seçer
            if (openFileDialog1.ShowDialog() == DialogResult.OK) // eger dosya seçme penceresi açılır ve kullanıcı bir dosya seçerse
            {
                // kullanıcı dosyayı seçtiyse
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName); // seçilen dosyanın yolunu alır ve resmi yükler
                label1.Text = openFileDialog1.FileName; // seçilen dosyanın yolunu label'a yazar
            }
        }
    }
}
