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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamadan çıkış yapar
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste(); // Seçili metni panoya kopyalar ve metinden siler
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut(); // Seçili metni panoya keser ve metinden siler
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
