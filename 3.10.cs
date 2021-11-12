using System;

namespace Zad3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe ktorej silnia chcesz obliczyc");
            int liczba, silnia = 1;
            liczba = int.Parse(Console.ReadLine());
            for (int i = 1; i <= liczba; i--)
                silnia = silnia*i;
            Console.WriteLine(silnia);
        }
    }
}
