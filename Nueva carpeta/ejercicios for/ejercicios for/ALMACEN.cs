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
    public partial class ALMACEN : Form
    {
        public ALMACEN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, por, total;
            a = double.Parse(textBox1.Text);

            if (a >= 100000)
            {
                por = a * 0.20;
                total = a - por;

                MessageBox.Show(" Tiene un descuento del 20%   " + "y es de:    " + por + "cancela un total de:     " + total);
            }
            else
            {
                MessageBox.Show("gracias por su compra");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Camisas frm2 = new Camisas();
            frm2.ShowDialog();


        }
    }
}
