using System;

namespace Zadanie_3._14petle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj przedział <1,n>");
            Console.Write("Podaj N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int suma = 0;
                for (int j = 1; j < i; j++)
                    if (i % j == 0)
                        suma = suma + j;
                if (suma == i)
                    Console.WriteLine("Liczba {0} jest liczbą doskonałą", i);
            }
            Console.ReadKey();
        }
    }
}