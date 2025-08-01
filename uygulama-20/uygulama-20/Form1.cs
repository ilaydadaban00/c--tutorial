using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


           int[] sayilar = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            foreach (int ogrenci in sayilar)
            {
                richTextBox1.Text += ogrenci + "\n";
                comboBox1.Items.Add(ogrenci);

            }
        }
    }
}
