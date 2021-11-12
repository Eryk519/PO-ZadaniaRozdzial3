using System;

namespace Zad3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Podaj pierwsza liczbe:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga inna liczbe:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecia inna  liczbe:");
            c = double.Parse(Console.ReadLine());
            if (a > b && a > c)
                {
                    Console.WriteLine("{0} jest liczba najwieksza", a,b,c);
                }
            else if (b > a && b > c)
                {
                    Console.WriteLine("{1}jest liczba najwieksza", a, b, c);
                }
            else if (c > a && c > b)
                {
                    Console.WriteLine("{2} jest liczba najwieksza", a, b, c);
                }
            else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Liczby sa rwone", a, b, c);
                }
            Console.ReadKey();
        }
    }
}
