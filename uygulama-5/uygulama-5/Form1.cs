using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            int not1 = Convert.ToInt32(txtNot1.Text);
            int not2 = Convert.ToInt32(txtNot2.Text);
            int not3 = Convert.ToInt32(txtNot3.Text);

            double ort =(double) (not1 + not2 + not3) / 3;


            txtOrtalama.Text = Convert.ToString(ort);

            
        }
    }
}
