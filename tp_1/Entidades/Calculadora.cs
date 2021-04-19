using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
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
