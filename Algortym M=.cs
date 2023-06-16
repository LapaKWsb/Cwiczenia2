// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;

            do
            {
                Console.WriteLine("Podaj liczbę n (n >= 5): ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 5);

            do
            {
                Console.WriteLine("Podaj liczbę k (k >= 5): ");
                k = Convert.ToInt32(Console.ReadLine());
            } while (k < 5);

            long wynik = ObliczM(n, k);
            Console.WriteLine("Wynik: " + wynik);

            Console.ReadLine();
        }

        static long ObliczM(int n, int k)
        {
            long m = 1;

            for (int i = 1; i <= n - k; i++)
            {
                m *= n - i + 1;
                m /= i;
            }

            return m;
        }
    }
}
