using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraExcepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CalcularSeno()
        {
            int numero;
            double radianes, resultado = 0;

            //para Obtener el numero entero en grados
            numero = int.Parse(this.txtNumero.Text);

            //convertir a radianes
            radianes = numero * Math.PI / 180;

            //calculo del seno
            resultado = Math.Sin(radianes);

            //expresion
            this.txtExpresion.Text = "sen(" + numero + "°)";

            //resultado
            this.txtResultado.Text = resultado.ToString();

        }

        private void CalcularCoseno()
        {
            int numero;
            double radianes, resultado = 0;

            //para obtener el entero en grados
            numero = int.Parse(this.txtNumero.Text);

            //convertir a radianes 
            radianes = numero * Math.PI / 180;

            //calculo del coseno
            resultado = Math.Cos(radianes);

            //expresion
            this.txtExpresion.Text = "cos(" + numero + "°)";

            //Resultado
            this.txtResultado.Text = resultado.ToString();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if ((bool)this.radSeno.Checked)
                {
                    this.CalcularSeno();
                }
                else if ((bool)this.radCoseno.Checked)
                {
                    this.CalcularCoseno();
                }
            }

            catch (FormatException fEx)
            {
                //Si el user escribe letras o deja vacio
                this.txtResultado.Text = fEx.Message;
            }
            catch (OverflowException oEx)
            {
                //Error si el num es demasiado grande
                this.txtResultado.Text = oEx.Message;
            }
        }
    }
}
