namespace CalculadoraExcepciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.radSeno = new System.Windows.Forms.RadioButton();
            this.radCoseno = new System.Windows.Forms.RadioButton();
            this.radTangente = new System.Windows.Forms.RadioButton();
            this.radSecante = new System.Windows.Forms.RadioButton();
            this.radRaiz = new System.Windows.Forms.RadioButton();
            this.radFactorial = new System.Windows.Forms.RadioButton();
            this.radLogaritmo = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblExpresion = new System.Windows.Forms.Label();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(148, 31);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero: ";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNumero.Location = new System.Drawing.Point(201, 29);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(131, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // radSeno
            // 
            this.radSeno.AutoSize = true;
            this.radSeno.Location = new System.Drawing.Point(62, 71);
            this.radSeno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radSeno.Name = "radSeno";
            this.radSeno.Size = new System.Drawing.Size(55, 17);
            this.radSeno.TabIndex = 2;
            this.radSeno.TabStop = true;
            this.radSeno.Text = "SENO";
            this.radSeno.UseVisualStyleBackColor = true;
            this.radSeno.CheckedChanged += new System.EventHandler(this.radSeno_CheckedChanged);
            // 
            // radCoseno
            // 
            this.radCoseno.AutoSize = true;
            this.radCoseno.Location = new System.Drawing.Point(201, 71);
            this.radCoseno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radCoseno.Name = "radCoseno";
            this.radCoseno.Size = new System.Drawing.Size(70, 17);
            this.radCoseno.TabIndex = 3;
            this.radCoseno.TabStop = true;
            this.radCoseno.Text = "COSENO";
            this.radCoseno.UseVisualStyleBackColor = true;
            // 
            // radTangente
            // 
            this.radTangente.AutoSize = true;
            this.radTangente.Location = new System.Drawing.Point(345, 71);
            this.radTangente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radTangente.Name = "radTangente";
            this.radTangente.Size = new System.Drawing.Size(84, 17);
            this.radTangente.TabIndex = 4;
            this.radTangente.TabStop = true;
            this.radTangente.Text = "TANGENTE";
            this.radTangente.UseVisualStyleBackColor = true;
            this.radTangente.CheckedChanged += new System.EventHandler(this.radTangente_CheckedChanged);
            // 
            // radSecante
            // 
            this.radSecante.AutoSize = true;
            this.radSecante.Location = new System.Drawing.Point(62, 118);
            this.radSecante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radSecante.Name = "radSecante";
            this.radSecante.Size = new System.Drawing.Size(75, 17);
            this.radSecante.TabIndex = 5;
            this.radSecante.TabStop = true;
            this.radSecante.Text = "SECANTE";
            this.radSecante.UseVisualStyleBackColor = true;
            // 
            // radRaiz
            // 
            this.radRaiz.AutoSize = true;
            this.radRaiz.Location = new System.Drawing.Point(201, 118);
            this.radRaiz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radRaiz.Name = "radRaiz";
            this.radRaiz.Size = new System.Drawing.Size(113, 17);
            this.radRaiz.TabIndex = 6;
            this.radRaiz.TabStop = true;
            this.radRaiz.Text = "RAÍZ CUADRADA";
            this.radRaiz.UseVisualStyleBackColor = true;
            // 
            // radFactorial
            // 
            this.radFactorial.AutoSize = true;
            this.radFactorial.Location = new System.Drawing.Point(345, 118);
            this.radFactorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radFactorial.Name = "radFactorial";
            this.radFactorial.Size = new System.Drawing.Size(84, 17);
            this.radFactorial.TabIndex = 7;
            this.radFactorial.TabStop = true;
            this.radFactorial.Text = "FACTORIAL";
            this.radFactorial.UseVisualStyleBackColor = true;
            // 
            // radLogaritmo
            // 
            this.radLogaritmo.AutoSize = true;
            this.radLogaritmo.Location = new System.Drawing.Point(62, 162);
            this.radLogaritmo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radLogaritmo.Name = "radLogaritmo";
            this.radLogaritmo.Size = new System.Drawing.Size(89, 17);
            this.radLogaritmo.TabIndex = 8;
            this.radLogaritmo.TabStop = true;
            this.radLogaritmo.Text = "LOGARITMO";
            this.radLogaritmo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(201, 196);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 44);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblExpresion
            // 
            this.lblExpresion.AutoSize = true;
            this.lblExpresion.Location = new System.Drawing.Point(62, 263);
            this.lblExpresion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpresion.Name = "lblExpresion";
            this.lblExpresion.Size = new System.Drawing.Size(72, 13);
            this.lblExpresion.TabIndex = 10;
            this.lblExpresion.Text = "EXPRESIÓN:";
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(151, 261);
            this.txtExpresion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(278, 20);
            this.txtExpresion.TabIndex = 11;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(65, 302);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(76, 13);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "RESULTADO:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(151, 300);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(278, 20);
            this.txtResultado.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "CALCULADORA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(533, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.lblExpresion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.radLogaritmo);
            this.Controls.Add(this.radFactorial);
            this.Controls.Add(this.radRaiz);
            this.Controls.Add(this.radSecante);
            this.Controls.Add(this.radTangente);
            this.Controls.Add(this.radCoseno);
            this.Controls.Add(this.radSeno);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.RadioButton radSeno;
        private System.Windows.Forms.RadioButton radCoseno;
        private System.Windows.Forms.RadioButton radTangente;
        private System.Windows.Forms.RadioButton radSecante;
        private System.Windows.Forms.RadioButton radRaiz;
        private System.Windows.Forms.RadioButton radFactorial;
        private System.Windows.Forms.RadioButton radLogaritmo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblExpresion;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label1;
    }
}

