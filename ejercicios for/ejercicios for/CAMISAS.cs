using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios_for
{
    public partial class CAMISAS : Form
    {
        public CAMISAS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, f;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            if (a <= 3)
            {
                c = (b * 3); // valor camisas
                d = c * 0.10;
                f = c - d;
                MessageBox.Show("tiene un descuento del 10%   " + d);
                label4.Text = f.ToString();
            }

            if (a > 3)
            {
                c = (b * a);
                d = c * 0.20;
                f = c - d;
                MessageBox.Show("tiene un descuento del 20%   " + d);
                label4.Text = f.ToString();
            }
        }

        private void CAMISAS_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            
        }
    }
}
