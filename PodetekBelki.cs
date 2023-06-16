// See https://aka.ms/new-console-template for more information
using System;

namespace Cwiczenie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Początkowa kwota: ");
            decimal Poczatkowa = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Oprocentowanie w skali roku: ");
            decimal oprocentowanie = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Liczba miesięcy oszczędzania: ");
            int liczbaMiesiecy = Convert.ToInt32(Console.ReadLine());

            decimal kwotaZarobiona = ObliczKwoteZarobiona(Poczatkowa, oprocentowanie, liczbaMiesiecy);
            Console.WriteLine("Kwota zarobiona: " + kwotaZarobiona);

            Console.ReadLine();
        }

        static decimal ObliczKwoteZarobiona(decimal Poczatkowa, decimal oprocentowanie, int liczbaMiesiecy)
        {
            decimal oprocentowanieMiesieczne = oprocentowanie / 1200;
            decimal kwotaZarobiona = Poczatkowa * (decimal)Math.Pow(1 + (double)oprocentowanieMiesieczne, liczbaMiesiecy);
            kwotaZarobiona -= Poczatkowa;
            kwotaZarobiona *= 0.81m;

            return kwotaZarobiona;
        }
    }
}
