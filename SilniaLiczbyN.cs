// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int n = SprawdzSilnie(x);

            Console.WriteLine(n != -1 ? $"Liczba {x} jest silnią liczby {n}" : $"Liczba {x} nie jest silnią żadnej liczby");

            Console.ReadLine();
        }

        static int SprawdzSilnie(int x)
        {
            int n = 1;
            int silnia = 1;

            while (silnia <= x)
            {
                if (silnia == x)
                    return n;

                n++;
                silnia *= n;
            }

            return -1;
        }
    }
}
