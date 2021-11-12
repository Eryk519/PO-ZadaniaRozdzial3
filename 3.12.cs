using System;

namespace Zad3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz liczbe calkowita");
            int liczba = int.Parse(Console.ReadLine());
            while (liczba != 0)
            {
                Console.WriteLine("Wprowadz kolejna liczbe:");
                liczba = int.Parse(Console.ReadLine());
            }
        }

    }
}
