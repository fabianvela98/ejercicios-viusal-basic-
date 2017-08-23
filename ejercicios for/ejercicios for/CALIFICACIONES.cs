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
    public partial class CALIFICACIONES : Form
    {
        public CALIFICACIONES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, res;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            res = (a + b + c) / 3;
            textBox4.Text = res.ToString();

            if (res >= 70)
            {
                MessageBox.Show("aprueba");
            }
            else
            {
                MessageBox.Show("reprueba");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
