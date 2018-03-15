using System;
using System.Collections.Generic;
using System.Text;

namespace PrimosApp
{
    class PrimosManager
    {
        public static bool isPrimo(int numero)
        {
            bool primo = true;

            if (!checkCasosEspeciales(numero))
            {
                int numeroInicial = numero;

                while ((numero > 2) && (primo == true))
                {
                    numero--;

                    if (numeroInicial % numero == 0)
                    {
                        primo = false;
                    }
                }
            }
            else
            {
                primo = false;
            }
            
            return primo;
        }

        private static bool checkCasosEspeciales (int numero)
        {
            bool resuelto = false;

            if (numero == 0 || numero == 1)
            {
                resuelto = true;    
            }

            return resuelto;
        }
    }
}
