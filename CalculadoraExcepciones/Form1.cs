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

        private void CalcularRaizCuadrada()
        {
            int numero;
            double resultado = 0;
            //Obtener el numero
            numero = int.Parse(this.txtNumero.Text);
            if (numero < 0)
            {
                throw new ArithmeticException("No se pueden calcular raíces cuadradas de números negativos.");
            }
            //calculo de la raiz cuadrada
            resultado = Math.Sqrt(numero);
            //expresion
            this.txtExpresion.Text = "√(" + numero + ")";
            //resultado
            this.txtResultado.Text = resultado.ToString();
        }

        private void CalcularFactorial()
        {
            int numero, resultado = 1;
            //Obtener el numero
            numero = int.Parse(this.txtNumero.Text);
            if (numero < 0)
            {
                throw new InvalidOperationException("No se pueden calcular factoriales de números negativos.");
            }
            //calculo del factorial
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            //Expresión
            this.txtExpresion.Text = numero + "!";
            //Resultado
            this.txtResultado.Text = resultado.ToString();
        }

        private void CalcularLogaritmo()
        {
            int numero;
            double resultado = 0;
            //Obtener el numero
            numero = int.Parse(this.txtNumero.Text);
            if (numero <= 0)
            {
                throw new ArithmeticException("No se pueden calcular logaritmos de números menores o iguales a cero.");
            }
            //calculo del logaritmo
            resultado = Math.Log10(numero);
            //expresion
            this.txtExpresion.Text = "log(" + numero + ")";
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
                else if ((bool)this.radRaiz.Checked)
                {
                    this.CalcularRaizCuadrada();
                }
                else if ((bool)this.radFactorial.Checked)
                {
                    this.CalcularFactorial();
                }
                else if ((bool)this.radLogaritmo.Checked)
                {
                    this.CalcularLogaritmo();
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
            catch (ArithmeticException aEx)
            {
                this.txtResultado.Text = aEx.Message;
            }
            catch (InvalidOperationException iEx)
            {
                this.txtResultado.Text = iEx.Message;
            }
            catch (Exception ex)
                {
                    //Cualquier otro error
                    this.txtResultado.Text = "Ocurrió un error inesperado: " + ex.Message;
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
