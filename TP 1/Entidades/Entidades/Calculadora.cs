﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        #region Metodos

        private static string ValidarOperador(string operador)
        {
            if(operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                return operador;
            }
            return "+";
        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            operador = ValidarOperador(operador);

            switch(operador)
            {
                case "+":
                    return (num1 + num2);
                case "-":
                    return (num1 - num2);
                case "*":
                    return (num1 * num2);
                default:
                    return (num1 / num2);
            }

        }
        #endregion
    }
}
