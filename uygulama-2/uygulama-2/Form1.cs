﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYap_Click(object sender, EventArgs e)
        {
            string isim;
            isim = txtSayi1.Text;
            txtSayi2.Text = isim;
        }
    }
}
