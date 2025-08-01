using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(txtM.Text);
            int sonucKare = m * m ;
            lblKare.Text =Convert.ToString("karenin Alanı  "+sonucKare);







            int k = Convert.ToInt32(txtKisakenar.Text);
            int u = Convert.ToInt32(txtUzunkenar.Text);
            int sonucDikdortgen = k * u;
            lblDikdortgen.Text = Convert.ToString("dikdörtgenin alanı" + sonucDikdortgen);



            int yaricap = Convert.ToInt32(txtYaricap.Text);
            int sonucdaire = (int)Math.PI *(yaricap* yaricap);
            lblYaricap.Text = Convert.ToString("dairenin  Alanı" + sonucdaire);


        }
    }
}
