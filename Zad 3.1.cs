using System;

namespace Zad_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok;
            Console.WriteLine("Podaj rok");
            rok = int.Parse(Console.ReadLine());
            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
                {
                Console.WriteLine("Podany rok jest przestepny");
                }
            else
                {
                Console.WriteLine("Podany rok nie jest przestepny");
                }
            Console.ReadLine();

        }
    }
}
