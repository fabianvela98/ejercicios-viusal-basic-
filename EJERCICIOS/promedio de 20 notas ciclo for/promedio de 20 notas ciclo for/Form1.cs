﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace promedio_de_20_notas_ciclo_for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long reprobado = 0;
        long porcentage = 0;
        string nota;
        long i = 1;
        private void button1_Click(object sender, EventArgs e)
        {
             for (i=0; i<=10; i++)
            {
                nota = Interaction.InputBox("ingrese valor", "mensaje", " ", 50, 50);
                if (Convert.ToDouble(nota) >= 0 && Convert.ToDouble(nota) <= 3.4)
                {
                    reprobado = reprobado + 1;
                }
                else
                {
                    porcentage = (reprobado * 100) / 20;
                    MessageBox.Show(" el procentage de estuduiantes reprobado es:  " + porcentage);

                }
                i = 0 + 1;
                

            }
           
        }

        }
    }

