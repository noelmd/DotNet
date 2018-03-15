using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    public static class FactorialManager
    {
        public static long Factorial(long numero)
        {
            long resultado;

            if (numero < 0)
                throw new Exception("El número debe ser positivo");
            else if (numero == 0)
            {
                resultado =  1;
            }
            else
            {
                resultado = numero * Factorial(numero - 1);
            }

            return resultado;
        }

        public static long FactorialIterativo(long numero)
        {
            long resultado = 1;

            if (numero < 0)
                throw new Exception("El parámetro debe ser positivo");

            for (long i = 1; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
