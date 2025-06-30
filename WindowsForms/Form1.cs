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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
          //  form2.Show(); // çağırılan form show metoduyla gösterilirse tüm formlara erişim sağlanabilir
            form2.ShowDialog(); // çagırılan form showdialog metoduyla gösterilirse üstteki form kapatılana kadar alttaki forma erişim sağlanamaz
          //  this.Hide(); // form 2 yi açtıktan sonra bu formu (forem 1) gizlemek için kullanılır
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this.Close(); // form  kapatmak için kullanılır
            Application.Exit(); // uygulamayı kapatmak için kullanılır. Bu formu kapatınca uygulama kapanmaz, diğer formlar açık kalır. Application.Exit() ile tüm formlar kapatılır.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.AdSoyad = txtAdSoyad.Text;
            form2.ShowDialog();
        }
    }
}
