using System;

namespace PrimosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Escribe un numero y te diré si es primo: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numero));

            numero = Math.Abs(numero);

            bool esPrimo = PrimosManager.isPrimo(numero);

            Console.WriteLine("El numero {0} es primo es {1}", numero, esPrimo);

            Console.ReadKey();
        }
    }
}
