using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TABLAS_DE_MULTIPLICAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string numero;
        double multiplicar;
       
        private void button1_Click(object sender, EventArgs e)
        {
         
            {
                numero = Interaction.InputBox("INGRESE UN NUMERO", " TABLAS DE MULTIPLICAR");
                double a = Convert.ToDouble(numero);

                for (int i = 0; i <= 10; i++)
                {
                    multiplicar = a * i;

                    MessageBox.Show("la tabla de multiplicar es " + a + " * " + i + " = " + multiplicar);
                }
               

            }
        }
    }
}
