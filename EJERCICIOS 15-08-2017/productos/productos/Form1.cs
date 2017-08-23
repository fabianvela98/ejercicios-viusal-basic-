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

namespace productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nombrep;
        string valor;
        string cantidad;
        string IVA;

        private void button1_Click(object sender, EventArgs e)
        {
            nombrep = Interaction.InputBox("INGRESE EL NOMBRE DEL PRODUCTO");
            valor = Interaction.InputBox("INGRESE EL VALOR DEL PRODUCTO");
            cantidad = Interaction.InputBox("INGRESE CANTIDAD DE PRODUCTOS");
            IVA = Interaction.InputBox("DIGITE EL IVA");

            double total;

            double v = Convert.ToDouble(valor);
            double c = Convert.ToDouble(cantidad);
            double iva = Convert.ToDouble(IVA);

            iva = (v * iva) / 100;
            total = (c * v) + iva;


            MessageBox.Show("EL PRODUCTO ES:  " + nombrep + "\n" + " TIENE UN VALOR DE:  " + v + " CON UN VALRO DE IVA" + iva );

            MessageBox.Show(" TOTAL A PAGAR " + total);

        }
        
    }
}
