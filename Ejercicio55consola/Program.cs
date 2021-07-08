using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaDenumeros = 0, pares = 0, impares = 0, numParcial = 0;
            int primerNumero, segundoNumero;

            Console.Write("Ingrese el primer número ");
            primerNumero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número");
            segundoNumero = Convert.ToInt32(Console.ReadLine());
            numParcial = primerNumero;
            Console.Clear();
            Console.WriteLine($"Cantidad de números entre {primerNumero} y {segundoNumero} ");
            Console.WriteLine(" ");
            do
            {
                if (numParcial%2==0)
                {
                    pares = pares + 1;
                    sumaDenumeros = sumaDenumeros + numParcial;
                }
                Console.Write($" {numParcial} ");
                numParcial = numParcial + 1;

            } while (numParcial>segundoNumero);
            Console.Clear();
            Console.WriteLine($"Cantidad de números pares {pares} ");
            Console.WriteLine($"Cantidad de números impares: {impares}");
            Console.WriteLine($"Suma de los pares: {sumaDenumeros}");
            Console.ReadLine();

        }   

    }
}
