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
            this.lblNumero.Location = new System.Drawing.Point(222, 47);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(73, 20);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero: ";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNumero.Location = new System.Drawing.Point(301, 44);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(194, 26);
            this.txtNumero.TabIndex = 1;
            // 
            // radSeno
            // 
            this.radSeno.AutoSize = true;
            this.radSeno.Location = new System.Drawing.Point(93, 109);
            this.radSeno.Name = "radSeno";
            this.radSeno.Size = new System.Drawing.Size(79, 24);
            this.radSeno.TabIndex = 2;
            this.radSeno.TabStop = true;
            this.radSeno.Text = "SENO";
            this.radSeno.UseVisualStyleBackColor = true;
            // 
            // radCoseno
            // 
            this.radCoseno.AutoSize = true;
            this.radCoseno.Location = new System.Drawing.Point(301, 109);
            this.radCoseno.Name = "radCoseno";
            this.radCoseno.Size = new System.Drawing.Size(102, 24);
            this.radCoseno.TabIndex = 3;
            this.radCoseno.TabStop = true;
            this.radCoseno.Text = "COSENO";
            this.radCoseno.UseVisualStyleBackColor = true;
            // 
            // radTangente
            // 
            this.radTangente.AutoSize = true;
            this.radTangente.Location = new System.Drawing.Point(517, 109);
            this.radTangente.Name = "radTangente";
            this.radTangente.Size = new System.Drawing.Size(120, 24);
            this.radTangente.TabIndex = 4;
            this.radTangente.TabStop = true;
            this.radTangente.Text = "TANGENTE";
            this.radTangente.UseVisualStyleBackColor = true;
            // 
            // radSecante
            // 
            this.radSecante.AutoSize = true;
            this.radSecante.Location = new System.Drawing.Point(93, 181);
            this.radSecante.Name = "radSecante";
            this.radSecante.Size = new System.Drawing.Size(109, 24);
            this.radSecante.TabIndex = 5;
            this.radSecante.TabStop = true;
            this.radSecante.Text = "SECANTE";
            this.radSecante.UseVisualStyleBackColor = true;
            // 
            // radRaiz
            // 
            this.radRaiz.AutoSize = true;
            this.radRaiz.Location = new System.Drawing.Point(301, 181);
            this.radRaiz.Name = "radRaiz";
            this.radRaiz.Size = new System.Drawing.Size(168, 24);
            this.radRaiz.TabIndex = 6;
            this.radRaiz.TabStop = true;
            this.radRaiz.Text = "RAÍZ CUADRADA";
            this.radRaiz.UseVisualStyleBackColor = true;
            // 
            // radFactorial
            // 
            this.radFactorial.AutoSize = true;
            this.radFactorial.Location = new System.Drawing.Point(517, 181);
            this.radFactorial.Name = "radFactorial";
            this.radFactorial.Size = new System.Drawing.Size(124, 24);
            this.radFactorial.TabIndex = 7;
            this.radFactorial.TabStop = true;
            this.radFactorial.Text = "FACTORIAL";
            this.radFactorial.UseVisualStyleBackColor = true;
            // 
            // radLogaritmo
            // 
            this.radLogaritmo.AutoSize = true;
            this.radLogaritmo.Location = new System.Drawing.Point(93, 249);
            this.radLogaritmo.Name = "radLogaritmo";
            this.radLogaritmo.Size = new System.Drawing.Size(130, 24);
            this.radLogaritmo.TabIndex = 8;
            this.radLogaritmo.TabStop = true;
            this.radLogaritmo.Text = "LOGARITMO";
            this.radLogaritmo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(301, 302);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(194, 68);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblExpresion
            // 
            this.lblExpresion.AutoSize = true;
            this.lblExpresion.Location = new System.Drawing.Point(93, 404);
            this.lblExpresion.Name = "lblExpresion";
            this.lblExpresion.Size = new System.Drawing.Size(107, 20);
            this.lblExpresion.TabIndex = 10;
            this.lblExpresion.Text = "EXPRESIÓN:";
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(226, 401);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(415, 26);
            this.txtExpresion.TabIndex = 11;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(97, 465);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(112, 20);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "RESULTADO:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(226, 462);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(415, 26);
            this.txtResultado.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "CALCULADORA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 532);
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

