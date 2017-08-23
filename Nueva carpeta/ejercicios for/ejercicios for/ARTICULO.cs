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
    public partial class ARTICULO : Form
    {
        public ARTICULO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string articulo;
            double a, b, c, d;

            articulo = Convert.ToString(textBox1.Text);
            a = double.Parse(textBox2.Text);
            b = double.Parse(textBox3.Text);

            if (a == 1)
            {
                c = b * 0.10;
                MessageBox.Show("Tiene un descuento del 10%      " + c + "     su articulo es:      " + articulo);
                d = b - c;
                textBox4.Text = d.ToString();
            }
            if (a == 2)
            {
                c = b * 0.20;
                MessageBox.Show("Tiene un descuento del 20%            " + c + "             su articulo es:           " + articulo);
                d = b - c;
                textBox4.Text = d.ToString();
            }


        }
    }
}
