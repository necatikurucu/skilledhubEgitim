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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; // Timer1 nesnesini sayfa yüklenirken etkinleştir
            timer1.Interval = 1000; // timer in sure aralığını milisaniye olarak ayarlayabiliriz
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random renk = new Random(); // Renk isminde sayı üreten bir nesne oluşturuldu
            this.BackColor = Color.FromArgb(renk.Next(1, 100), renk.Next(1, 100), renk.Next(1, 100)); //burada this sınıfı geçerli form u temsil ediyor Formun arka plan rengini rastgele 1 ile 100 arası rgb renk kodlarını oluşturaca sayılar üretilecek şekilde ayarladık
        }

    }
}
