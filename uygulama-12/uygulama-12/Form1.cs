﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "sayıların:";
            int sayi = Convert.ToInt32(textBox1.Text);
            for(int i = 0; i < sayi; i++)
            {
                label1.Text = label1.Text+"," + i;
            }
        }
    }
}
