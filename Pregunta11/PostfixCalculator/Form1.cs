using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PostfixCalculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void AgregarNumeroAlTextBox(string numero)
        {
            // Agregar el número al final del TextBox
            txtExpression.Text += numero;
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {

            string texto = txtExpression.Text;
            try
            {
                double resultado = Calculadora.EvaluarExpresionPostfija(texto);
                txtExpression.Text = resultado.ToString();
                //lblResult.Text = Convert.ToString(resultado);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            // Hacer algo con el texto recogido
            //MessageBox.Show("El texto ingresado es: " + texto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 nuevaVentana = new Form2();
            nuevaVentana.FormClosed += (s, args) =>
            {
                // Muestra nuevamente la ventana actual (Form1) cuando se cierre Form2
                this.Show();
            };
            nuevaVentana.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox("3");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox("4");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox("6");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox("7");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox("8");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox("9");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox("0");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox("+");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox("-");
        }

        private void puntoDecimal_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox(puntoDecimal.Text);
        }

        private void producto_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox(producto.Text);
        }

        private void division_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlTextBox(division.Text);
        }

        private void Evaluar_Click(object sender, EventArgs e)
        {
            string texto = txtExpression.Text;
            try
            {
                double resultado = Calculadora.EvaluarExpresionPostfija(texto);
                txtExpression.Text = resultado.ToString();
            //    lblResult.Text = Convert.ToString(resultado);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BTlimpiar_Click(object sender, EventArgs e)
        {
            txtExpression.Text = "";
        }

        private void BTborrar_Click(object sender, EventArgs e)
        {
            // Verificar que el TextBox no esté vacío
            if (txtExpression.Text.Length > 0)
            {
                // Eliminar el último carácter del TextBox
                txtExpression.Text = txtExpression.Text.Substring(0, txtExpression.Text.Length - 1);
            }
        }

        private void txtExpression_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
