﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suma_heterogeneos_con_switch
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, resultado, multiplicacion;
            int op;

            if (textBox5.Text == "")
            {
                MessageBox.Show(" DEBE ELEGIR UNA OPCION A REAIZAR");
            }
            else
            {
                a = int.Parse(txta.Text);
                b = int.Parse(txtb.Text);
                c = int.Parse(txtc.Text);
                d = int.Parse(txtd.Text);
                op = int.Parse(textBox5.Text);
                
                switch (op)
                {
                    case 1:

                        {
                            if (c == d)
                            {
                                multiplicacion = a + b;
                                resultado = d = c;
                                cajaresultado.Text = multiplicacion.ToString();
                                textBox2.Text = resultado.ToString();
                            }
                            else
                            {
                                MessageBox.Show("debe ingresar los denominadores iguales, ya que  ");
                            }
                            break;
                            }
                    case 2:

                        {
                            if (a == d)
                            {
                                multiplicacion = a - b;
                                resultado = d = c;
                                cajaresultado.Text = multiplicacion.ToString();
                                textBox2.Text = resultado.ToString();
                            }
                            else
                            {
                                MessageBox.Show("debe ingreasar los denominadores iguales ya que es una fraccio homogenea");
                            }
                            break;                     
                        }

                             case 3:
                        {
                            if (c == d)
                            {
                                multiplicacion = a * d;
                                resultado = (c * d);
                                cajaresultado.Text = multiplicacion.ToString();
                                textBox2.Text = resultado.ToString();
                            }
                            else
                            {
                                MessageBox.Show("debe ingreasar los denominadores iguales ya que es una fraccio homogenea");
                            }

                            break;
                             

                        }
                    case 4:
                        {
                           
                            {
                                multiplicacion = a *b;
                                resultado = (d * c);
                                cajaresultado.Text = multiplicacion.ToString();
                                textBox2.Text = resultado.ToString();
                            }
                            break;
                        }


                       

                        }

                        }

                }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox5.Clear();
            cajaresultado.Clear();
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtd.Clear();

        }
    }
    }


