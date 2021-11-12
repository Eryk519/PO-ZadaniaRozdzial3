using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x0, x1, x2;
            Console.WriteLine("Podaj a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = double.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            x0 = (-b / 2 * a);
            x1 = (-b - Math.Sqrt(delta) / 2 * a);
            x2 = (-b + Math.Sqrt(delta) / 2 * a);
                if (delta < 0)
                    {
                        Console.WriteLine("Delta mniejsza od 0, brak rozwiazan rownania");
                    }
                if (delta == 0)
                    {
                        Console.WriteLine("Delta rowna zero, jedno rozwiazanie x0= " + x0);
                    }
                if (delta > 0)
                    {
                        Console.WriteLine("Delta wieksza od 0, dwa rozwiazania x1 = {0}, x2 = {1}", x1, x2);
                    }
            Console.ReadKey();
        }
    }
}