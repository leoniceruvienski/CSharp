using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine()); // Armazena o valor da variável digitada

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;

            Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine("O resultado da soma é " + (v1 + v2));
            Console.WriteLine("O resultado da soma é " + v1 + v2); // se não por entre parentêses imprime o valor digitado, e não faz a soma.


            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.WriteLine($"O resultado da soma é {v1 + v2}");
        }
    }
}