using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesB
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida si el operador ingresado es +, -, * o / 
        /// </summary>
        /// <param name="operador"></param>
        /// <returns> Si el operador es válido, retorna el operador. Sino '+' </returns>
        private static string ValidarOperador(char operador)
        {
            string resultado = "+";

            if (operador.Equals('-'))
                resultado = "-";
            else if (operador.Equals('/'))
                resultado = "/";
            else if (operador.Equals('*'))
                resultado = "*";

            return resultado;
        }

        /// <summary>
        /// Realiza una operación autorizada (+,-,*,/) entre dos objetos de clase Numero.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado de la operación en tipo double. </returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;
            char auxOperador;

            if (char.TryParse(operador, out auxOperador))
            {
                switch (Calculadora.ValidarOperador(auxOperador))
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        resultado = num1 / num2;
                        break;
                }

            }

            return resultado;

        }
    }
}
