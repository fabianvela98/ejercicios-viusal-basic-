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
namespace empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string[] nom;
        string nombres;
        string area;
        string sueldo;
        double SUMA = 0;
       


        private void button1_Click(object sender, EventArgs e)
        {
            
            nom = new string[3];
            for (int i = 0; i < 3; i++)
            {
                
                nombres = Interaction.InputBox("INGRESE LOS NOMBRES DE LOS EMPLEADOS");
                

                area = Interaction.InputBox("INGRESE EL AREA DE DESEMPEÑO");
                sueldo = Interaction.InputBox("INGRESE EL SUELDO DE LOS EMPLEADOS");
                Double n = Convert.ToDouble(sueldo);

                SUMA = SUMA + n;
                string nom = Convert.ToString(nombres);
            
                MessageBox.Show("los trabajadores son: " + nom[i] + "\n" + "la suma de los sueldos es:  " + SUMA);
            }
           



            



        }
    }
}
