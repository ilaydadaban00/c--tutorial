using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 3, 5, 7, 9, 11, 25 };

            for(int i = 0; i < sayilar.Length; i++)
            {
                richTextBox1.Text += sayilar[i]+"\n";
                comboBox1.Items.Add(sayilar[i]);
            }
        }
    }
}
