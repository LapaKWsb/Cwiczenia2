// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba wyrazów: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ciąg Fibonacciego:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }

            Console.ReadLine();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
