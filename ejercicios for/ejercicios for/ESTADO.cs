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
    public partial class ESTADO : Form
    {
        public ESTADO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string estado;
            double calorias, cons1, cons2;

            estado = Convert.ToString(textBox1.Text);
            calorias = double.Parse(textBox2.Text);

            if (estado == "dormir")
            {
                cons1 = 1.08 * calorias;
                textBox3.Text = cons1.ToString();
            }
            if (estado == "sentado")
            {

                cons2 = 1.66 * calorias;
                textBox3.Text = cons2.ToString();
            }


        }
    }
}
