using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Toplama()
        {

            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            int sonuc = sayi1 + sayi2;
            lblSonuc.Text = sonuc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toplama();
        }
    }
}
