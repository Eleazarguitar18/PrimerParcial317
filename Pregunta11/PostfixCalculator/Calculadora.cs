using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostfixCalculator
{
    public class Calculadora
    {
        public static double EvaluarExpresionPostfija(string expresion)
        {
            Stack<double> pila = new Stack<double>();

            try
            {
                foreach (char c in expresion)
                {
                    if (char.IsDigit(c))
                    {
                        pila.Push(double.Parse(c.ToString()));
                    }
                    else if (EsOperador(c))
                    {
                        double operando2 = pila.Pop();
                        double operando1 = pila.Pop();
                        double resultado = AplicarOperador(c, operando1, operando2);
                        pila.Push(resultado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no intruduciste una expresion postfija: " + ex.Message);
            }
            return pila.Pop();
        }

        private static bool EsOperador(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        private static double AplicarOperador(char operador, double a, double b)
        {
            switch (operador)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        throw new ArgumentException("La división por cero no está permitida.");
                    }
                    return a / b;
                default:
                    throw new ArgumentException("Operador inválido.");
            }
        }
    }
}
