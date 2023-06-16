// See https://aka.ms/new-console-template for more information
using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podstawa: ");
            int podstawa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wykładnik: ");
            int wykladnik = Convert.ToInt32(Console.ReadLine());

            long wynik = Potegowanie(podstawa, wykladnik);
            Console.WriteLine("Wynik: " + wynik);

            Console.ReadLine();
        }

        static long Potegowanie(int podstawa, int wykladnik)
        {
            return (long)Math.Pow(podstawa, wykladnik);
        }
    }
}
