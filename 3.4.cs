using System;

namespace Zad3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,d,e,f;
            string znak;
            Console.WriteLine("Podaj pierwsza liczbe");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Wybierz znak operacji ktora chcesz wykonac: +, -, *, /,  ");
            znak = (Console.ReadLine());
            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;
            if (znak == "+")
                Console.WriteLine("Wynik dodawania wynosi: " + c);
            if (znak == "-")
                Console.WriteLine("Wynik dodawania wynosi: " + d);
            if (znak == "*")
                Console.WriteLine("Wynik dodawania wynosi: " + e);
            if (znak == "/")
                Console.WriteLine("Wynik dodawania wynosi: " + f);
            Console.ReadKey();
        }
    }
}
