using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
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

        public Numero(double numero): this()
        {
            this.numero = numero;
        }


        public Numero(string strNumero)
        {
            double numParse;

            if (double.TryParse(strNumero, out numParse))
                this.numero = numParse;

        }

        public double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            double numero;

            if (double.TryParse(strNumero, out numero))
                retorno = numero;

            return retorno;
        }

        public static string BinarioDecimal(string binario)
        {
            int resultado = 0;
            string retorno;
            int bit;
            char c;

            if (Numero.EsBinario(binario))
            {
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    c = binario[i];

                    bit = (int)Char.GetNumericValue(binario[i]);
                    
                    resultado += bit * (int)(Math.Pow(2, (binario.Length - 1) - i));

                }
                
                retorno = resultado.ToString();
            }
            else
            {
                retorno = "Valor inválido";
            }
                       
            return retorno;

        }

        public static string DecimalBinario(double numero)
        {

            string retorno = "";
            int div = (int) Math.Abs(numero);
            
            while (div >= 2)
            {
                retorno = (div % 2).ToString() + retorno;
                div = (div - div % 2) / 2;
            }
            retorno = div + retorno;
            return retorno;

        }

        public static string DecimalBinario(string numero)
        {
            string retorno = "";
            double auxiliar;

            if(double.TryParse(numero, out auxiliar))
            {
                retorno = Numero.DecimalBinario(auxiliar);
            }
            else
            {
                retorno = "Valor inválido";
            }

            return retorno;

        }

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

        public static double operator -(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero - n2.numero;

            return resultado;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double resultado;

            if (n2.numero != 0)
                resultado = n1.numero / n2.numero;
            else
                resultado = double.MinValue;

            return resultado;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero * n2.numero;

            return resultado;
        }
    }

}
