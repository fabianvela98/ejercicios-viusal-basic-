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

namespace atleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string t;
        int  i = 1;
        double cont = 0;
        double suma = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            while (i<=10)
            {
                t = Interaction.InputBox("ingrese el tiempo de la carrera","Resultados Diarios","  ",10,10);

                Double h = Convert.ToDouble(t);

                cont = cont + 1;
                suma = (suma + cont) / 10;


                }
            MessageBox.Show("  " + suma);

          

            

        }
    }
}
