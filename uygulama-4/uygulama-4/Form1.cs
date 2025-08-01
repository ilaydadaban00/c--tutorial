using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            float x = 5.78546884f;
            double y = 5.123456789;
            txtSayi.Text = Convert.ToString(y);
            */

            char c='w';
            txtSayi.Text = Convert.ToString(c);

        }
    }
}
