﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int baslangic = Convert.ToInt32(textBox1.Text);
            int bittis = Convert.ToInt32(textBox2.Text);


            for (int i = baslangic; i < bittis; i++)
            {
                if (i % 2 == 0)
                
                    richTextBox1.Text = richTextBox1.Text + i + " ";
                
            }
            
            
                
            

        }
    }
}
