using System;

namespace Zad_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Podaj pierwsza liczbe calkowita");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe calkowita");
            b = int.Parse(Console.ReadLine());
            if (a % b != 0)
                {
                    Console.WriteLine("{1} nie jest dzielnikiem {0}",a,b);
                }
            else
                {
                Console.WriteLine("{1} jest dzielnikiem {0}",a,b);
                }
            Console.ReadKey();
        }
    }
}
