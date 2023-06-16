// See https://aka.ms/new-console-template for more information
using System;

namespace Cwiczenie7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Pary liczb naturalnych o sumie n:");
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine($"{i} + {n - i} = {n}");
            }

            Console.ReadLine();
        }
    }
}
