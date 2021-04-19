using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesB
{
    public class Numero 
    { 
        private double numero;


        public string SetNumero
        {
            set
            {
                numero = this.ValidarNumero(value);
            }
        }

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero) : this()
        {
            this.numero = numero;
        }


        public Numero(string strNumero)
        {
            double numParse;

            if (double.TryParse(strNumero, out numParse))
                this.numero = numParse;

        }

        /// <summary>
        /// Valida si en el string hay caracteres de numeros
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Si hay, devuelve el numero sino 0 </returns>
        public double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            double numero;

            if (double.TryParse(strNumero, out numero))
                retorno = numero;

            return retorno;
        }

        /// <summary>
        /// Convierte un numero binario a numero decimal. 
        /// Valida previamente que el string sea número y binario.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Retorna el numero convertido a decimal en tipo string</returns>
        public static string BinarioDecimal(string binario)
        {
            int resultado = 0;
            string retorno;
            int num;
            char c;

            if (Numero.EsBinario(binario))
            {
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    c = binario[i];

                    num = (int)Char.GetNumericValue(binario[i]);

                    resultado += num * (int)(Math.Pow(2, (binario.Length - 1) - i));

                }

                retorno = resultado.ToString();
            }
            else
            {
                retorno = "Valor inválido";
            }

            return retorno;

        }

        /// <summary>
        /// Convierte un numero decimal a numero binario.         
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna el numero convertido a binario en tipo string</returns>
        public static string DecimalBinario(double numero)
        {
            string numBinarioStr = "";
            string retorno = "";
            int div = (int)Math.Abs(numero);
            double numeroBinario;

            while (div >= 2)
            {
                numBinarioStr = (div % 2).ToString() + numBinarioStr;
                div = (div - div % 2) / 2;
            }
            numBinarioStr = div + numBinarioStr;

            if (double.TryParse(numBinarioStr, out numeroBinario))
            {

                if (numeroBinario < 0)
                {
                    retorno = "Valor inválido";
                }
                else
                {
                    retorno = numBinarioStr;
                }
            }

            return retorno;

        }

        /// <summary>
        /// Convierte un numero decimal a numero binario. 
        /// Valida previamente que el string sea número y binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna el numero convertido a binario en tipo string</returns>
        public static string DecimalBinario(string numero)
        {
            string retorno = "";
            double auxiliar;

            if (double.TryParse(numero, out auxiliar))
            {
                retorno = Numero.DecimalBinario(auxiliar);
            }
            else
            {
                retorno = "Valor inválido";
            }

            return retorno;

        }

        /// <summary>
        /// Valida que la cadena ingresada sea numero binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Si lo es retorna true, sino false </returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = true;

            foreach (char item in binario)
            {
                if (item != '0' && item != '1')
                {
                    retorno = false;
                    break;
                }

            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga el operador - para restar dos objetos del tipo Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>retorna el resultado en tipo double</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero - n2.numero;

            return resultado;
        }

        /// <summary>
        /// Sobrecarga el operador + para sumar dos objetos del tipo Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>retorna el resultado en tipo double</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado;
        }

        /// <summary>
        /// Sobrecarga el operador / para dividir dos objetos del tipo Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>retorna el resultado en tipo double</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double resultado;

            if (n2.numero != 0)
                resultado = n1.numero / n2.numero;
            else
                resultado = double.MinValue;

            return resultado;
        }

        /// <summary>
        /// Sobrecarga el operador * para multiplicar dos objetos del tipo Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>retorna el resultado en tipo double</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero * n2.numero;

            return resultado;
        }
    }
}
