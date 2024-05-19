namespace PostfixCalculator
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
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.producto = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.Evaluar = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.puntoDecimal = new System.Windows.Forms.Button();
            this.BTlimpiar = new System.Windows.Forms.Button();
            this.BTborrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExpression
            // 
            this.txtExpression.Location = new System.Drawing.Point(48, 141);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(294, 26);
            this.txtExpression.TabIndex = 0;
            this.txtExpression.TextChanged += new System.EventHandler(this.txtExpression_TextChanged);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(48, 173);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(104, 50);
            this.btnEvaluate.TabIndex = 1;
            this.btnEvaluate.Text = "Evaluar";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(198, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(273, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 48);
            this.button5.TabIndex = 7;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(273, 278);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(69, 48);
            this.resta.TabIndex = 11;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(198, 278);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 48);
            this.button7.TabIndex = 10;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(123, 278);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 48);
            this.button8.TabIndex = 9;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(48, 278);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 48);
            this.button9.TabIndex = 8;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // producto
            // 
            this.producto.Location = new System.Drawing.Point(273, 333);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(69, 48);
            this.producto.TabIndex = 15;
            this.producto.Text = "*";
            this.producto.UseVisualStyleBackColor = true;
            this.producto.Click += new System.EventHandler(this.producto_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(198, 333);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(69, 48);
            this.button11.TabIndex = 14;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(123, 333);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(69, 48);
            this.button12.TabIndex = 13;
            this.button12.Text = "8";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(48, 333);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(69, 48);
            this.button13.TabIndex = 12;
            this.button13.Text = "7";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(273, 387);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(69, 48);
            this.division.TabIndex = 19;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // Evaluar
            // 
            this.Evaluar.Location = new System.Drawing.Point(198, 387);
            this.Evaluar.Name = "Evaluar";
            this.Evaluar.Size = new System.Drawing.Size(69, 48);
            this.Evaluar.TabIndex = 18;
            this.Evaluar.Text = "=";
            this.Evaluar.UseVisualStyleBackColor = true;
            this.Evaluar.Click += new System.EventHandler(this.Evaluar_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(123, 387);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(69, 48);
            this.button16.TabIndex = 17;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // puntoDecimal
            // 
            this.puntoDecimal.Location = new System.Drawing.Point(48, 387);
            this.puntoDecimal.Name = "puntoDecimal";
            this.puntoDecimal.Size = new System.Drawing.Size(69, 48);
            this.puntoDecimal.TabIndex = 16;
            this.puntoDecimal.Text = ".";
            this.puntoDecimal.UseVisualStyleBackColor = true;
            this.puntoDecimal.Click += new System.EventHandler(this.puntoDecimal_Click);
            // 
            // BTlimpiar
            // 
            this.BTlimpiar.Location = new System.Drawing.Point(158, 176);
            this.BTlimpiar.Name = "BTlimpiar";
            this.BTlimpiar.Size = new System.Drawing.Size(109, 45);
            this.BTlimpiar.TabIndex = 20;
            this.BTlimpiar.Text = "Limpiar";
            this.BTlimpiar.UseVisualStyleBackColor = true;
            this.BTlimpiar.Click += new System.EventHandler(this.BTlimpiar_Click);
            // 
            // BTborrar
            // 
            this.BTborrar.Location = new System.Drawing.Point(267, 176);
            this.BTborrar.Name = "BTborrar";
            this.BTborrar.Size = new System.Drawing.Size(75, 42);
            this.BTborrar.TabIndex = 21;
            this.BTborrar.Text = "Borrar";
            this.BTborrar.UseVisualStyleBackColor = true;
            this.BTborrar.Click += new System.EventHandler(this.BTborrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Caluladora de expresiones postfijas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre: Elezar Jhonny Cruz Mamani";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Materia:INF - 317";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTborrar);
            this.Controls.Add(this.BTlimpiar);
            this.Controls.Add(this.division);
            this.Controls.Add(this.Evaluar);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.puntoDecimal);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.txtExpression);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button producto;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button Evaluar;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button puntoDecimal;
        private System.Windows.Forms.Button BTlimpiar;
        private System.Windows.Forms.Button BTborrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

