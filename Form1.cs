using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torteria
{
    public partial class Form1 : Form
    {

        String[,] tortas = new string[4, 2];
        String[,] refrescos = new string[4, 2];
        String[,] postres = new string[4, 2];
        String[,] premios = new string[4, 2];
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Valores arreglos tortas

            tortas[0, 0] = "Torta al pastor";
            tortas[0, 1] = "40";
            tortas[1, 0] = "Torta de pierna";
            tortas[1, 1] = "75";
            tortas[2, 0] = "Torta de pollo";
            tortas[2, 1] = "50";
            tortas[3, 0] = "Torta cabeza";
            tortas[3, 1] = "95";

            //Valores arreglo refrescos
            refrescos[0, 0] = "Coca cola";
            refrescos[0, 1] = "35";
            refrescos[1, 0] = "Fanta de naranja";
            refrescos[1, 1] = "45";
            refrescos[2, 0] = "Pepsi";
            refrescos[2, 1] = "29";
            refrescos[3, 0] = "Fanta de fresa";
            refrescos[3, 1] = "40";

            //Valores arreglo postres
            postres[0, 0] = "Pay de queso";
            postres[0, 1] = "24";
            postres[1, 0] = "Flan";
            postres[1, 1] = "59";
            postres[2, 0] = "Malteada";
            postres[2, 1] = "70";
            postres[3, 0] = "Pastel de chocolate";
            postres[3, 1] = "100";

            premios[0, 0] = "Switch";
            premios[0, 1] = "1";
            premios[1, 0] = "Membresia Gym";
            premios[1, 1] = "2";
            premios[2, 0] = "Gorra";
            premios[2, 1] = "3"; 
            premios[3, 0] = "Cupón de $100";
            premios[3, 1] = "4";



            //Agregar valores de listBox
            for (int i = 0; i < 4; i++)
            {
                listBox1.Items.Add(tortas[i, 0]);
                listBox2.Items.Add(refrescos[i, 0]);
                listBox3.Items.Add(postres[i, 0]);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciones un opción de torta");
            }
            else
            {
                if (listBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciones un opción de refresco");
                }
                else
                {
                    if (listBox3.SelectedIndex == -1)
                    {
                        MessageBox.Show("Selecciones un opción de postre");

                    }
                    else
                    {
                        double subtotal, total, iva;
                        //Variables para obtener precios
                        double preciotorta = Convert.ToDouble(tortas[listBox1.SelectedIndex, 1]);
                        double preciorefresco = Convert.ToDouble(refrescos[listBox2.SelectedIndex, 1]);
                        double preciopostre = Convert.ToDouble(postres[listBox3.SelectedIndex, 1]);
                        //Calcular valores totales
                        subtotal = preciopostre + preciorefresco + preciotorta;
                        if (checkBox1.Checked == true)
                        {
                            subtotal = subtotal + 60;
                        }
                        iva = subtotal * 0.16;
                        total = subtotal + iva;
                        //Mandar valores a Labels
                        label10.Text = "$" + subtotal.ToString();
                        label11.Text = "$" + iva.ToString();
                        label12.Text = "$" + total.ToString();

                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Random aleatorio = new Random();
                Int32 premio = aleatorio.Next(0, 3);
                label15.Text = premios[premio, 0];
                label15.Visible= true;  

            }
            else
            {
                label15.Visible = false;
            }
        }
    }
}
