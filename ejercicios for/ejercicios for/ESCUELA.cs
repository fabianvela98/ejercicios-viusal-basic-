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
    public partial class ESCUELA : Form
    {
        public ESCUELA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double a, b, c, d, f;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            if (b >= 9)
            {
                c = a * 0.30;
                d = a - c;
                MessageBox.Show("Felicidades obtuvo un descuento del 30%    " + c);
                textBox3.Text = d.ToString();
            }

            if (b < 9)
            {
                c = a * 0.10;
                d = a + c;
                MessageBox.Show("Debe cancelar el total de la colegiatura,incluyendo el 10% de iva");
                textBox3.Text = d.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
    }
}
