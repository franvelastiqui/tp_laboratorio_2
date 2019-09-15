using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos

        private double numero;
        #endregion

        #region Propiedades

        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion

        #region Constructores

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        #endregion

        #region Validadores

        private double ValidarNumero(string strNumero)
        {
            double numero;

            if(double.TryParse(strNumero, out numero))
            {
                return numero;
            }

            return 0;
        }


        #endregion
        
        #region Conversores
        
        public string BinarioDecimal(string binario)
        {
            double retorno = 0;
            int j = 0;

            for(int i = 0; i < binario.Length; i++)
            {
                if(binario[i]!='0' && binario[i]!='1')
                {
                    return "Valor invalido";
                }
            }

            for (int i = binario.Length - 1; i >= 0; i--)
            {
                if (binario[i] == '1')
                {
                    retorno += Math.Pow(2, j);
                }

                j++;
            }

            return (Convert.ToString(retorno));
        }
        
        public string DecimalBinario(string numero)
        {
            int retorno;

            retorno = (int)(ValidarNumero(numero));

            if(retorno>0)
            {
                return DecimalBinaro(retorno);
            }
            else
            {
                return "Valor invalido";
            }
        }
        
        public string DecimalBinaro(double numero)
        {
            string retorno = "";
            double resto;

            while(numero>0)
            {
                resto = numero % 2;

                if(resto==0)
                {
                    retorno = "0" + retorno;
                }
                else if(resto==1)
                {
                    retorno = "1" + retorno;
                }

                numero = Convert.ToInt32(numero) / 2;
            }

            //retorno = "1" + retorno;

            return retorno;
        }
        
        #endregion
    
        #region Sobrecargas

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            if(n2.numero==0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }
        #endregion
    }
}
