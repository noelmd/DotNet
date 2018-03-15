using System;

namespace Factorial
{
    class Program
    {
        
        static void Main(string[] args)
        {
            long numero;

            do
            {
                Console.WriteLine("Escribe un número cuyo factorial quieras conocer...");
            }
            while (!long.TryParse(Console.ReadLine(), out numero));

            numero = Math.Abs(numero);

            Console.WriteLine("El factorial de {0} es {1}", numero, FactorialManager.Factorial(numero));

            Console.ReadKey();
        }
    }
}
