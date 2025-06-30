﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public String AdSoyad { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            LblMesaj.Text = "Merhaba " + AdSoyad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
           form1.ShowDialog();
           //form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); // Form2'yi kapatır
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı kapatır
        }
    }
}
