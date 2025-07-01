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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) // eğer textbox1 boş değilse
            {
                MessageBox.Show(" Merhaba " + textBox1.Text); // messagebox sınıfındaki show metodu ekranda uyarı penceresi çıkartmamızı sağlar
            }
            else // eğer textbox1 boş ise
            {
                MessageBox.Show(" Lütfen adınızı giriniz!" , "Uyarı!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning); // messagebox sınıfındaki show metodu ekranda uyarı penceresi çıkartmamızı sağlar
            }
        }
    }
}
