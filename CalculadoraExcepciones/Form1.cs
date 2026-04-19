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
        private void CalcularSecante()
        {
            int numero;
            double radianes,coseno, resultado = 0; 
            

            //obtener numero
            numero = int.Parse(this.txtNumero.Text);
            //convertir a radianes
            radianes = numero * Math.PI / 180;
            //calculo del coseno
            coseno = Math.Cos(radianes);
            if (Math.Abs(coseno) < 0.000001)
            {
                throw new DivideByZeroException("La secante no está definida para este valor.");
            }

            //calculo de la secante
            resultado = 1 / coseno;

            //expresion
            this.txtExpresion.Text = "sec(" + numero + "°)";

            //Resultado
            this.txtResultado.Text = resultado.ToString();

        }
        //calculo de la tangente
        public void CalcularTangente()
        {
            int numero;
            double radianes,coseno, resultado = 0;
            //para Obtener el numero
            numero = int.Parse(this.txtNumero.Text);

            //convertir a radianes
            radianes = numero * Math.PI / 180;

            coseno = Math.Cos(radianes);
            if (Math.Abs(coseno) < 0.000001)
            {
                throw new DivideByZeroException("La tangente no está definida para este valor.");
            }

            //calculo de la tangente
            resultado = Math.Tan(radianes);

            //expresion
            this.txtExpresion.Text = "tan(" + numero + "°)";

            //resultado
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
                else if ((bool)this.radSecante.Checked)
                {
                    this.CalcularSecante();
                }
                else if ((bool)this.radTangente.Checked)
                {
                    this.CalcularTangente();
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
            catch (DivideByZeroException dEx)
            {
                //Error si el coseno es 0 para secante o tangente
                this.txtResultado.Text = dEx.Message;
            }
           
        }

        private void radSeno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radTangente_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
