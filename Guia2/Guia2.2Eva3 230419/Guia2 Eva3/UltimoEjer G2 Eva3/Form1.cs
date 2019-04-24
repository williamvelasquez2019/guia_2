using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimoEjer_G2_Eva3
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double gfarenheit, ct1;
            ct1 = Convert.ToDouble(textBox1.Text);
            gfarenheit = ct1 * 1.8 + 32.0;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double gcentigrados, ct1;
            ct1 = Convert.ToDouble(textBox1.Text);
            gcentigrados = (ct1 - 32.0) / 1.8;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
