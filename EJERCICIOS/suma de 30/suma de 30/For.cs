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

namespace suma_de_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       
        string valor;

        private void button1_Click(object sender, EventArgs e)
        {
            double suma = 0;
           
            
                for (int i = 1; i <= 30; i++)
                {
                    

                    valor = Interaction.InputBox("ingrese numero", "mensaje");
                    double c = Convert.ToDouble(valor);

                    suma = suma + c;


                    
                }

            MessageBox.Show("la sumatoria es: " + suma);
        }
           

        }
        
    }

