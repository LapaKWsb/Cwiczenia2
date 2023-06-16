// See https://aka.ms/new-console-template for more information
using System;

namespace Cwiczenie8
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 20;
            int guess;
            int counter = 0;

            Console.WriteLine("Wybierz liczbę od 1 do 20.");

            while (min <= max)
            {
                guess = (min + max) / 2;
                counter++;

                Console.WriteLine($"Czy twoja liczba to {guess}? Liczba ujemna = mniejsza liczba, Liczba dodatnia = większa liczba, 0 jeśli odgadłem liczbę :).");

                int response = Convert.ToInt32(Console.ReadLine());

                if (response < 0)
                {
                    max = guess - 1;
                }
                else if (response > 0)
                {
                    min = guess + 1;
                }
                else
                {
                    Console.WriteLine($"Jestem najlepszy odgadłem twoją liczbę {guess} w {counter} próbach! 8)");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
