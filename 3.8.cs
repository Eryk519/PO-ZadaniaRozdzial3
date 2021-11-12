using System;

namespace Zad3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POdaj swoją srednia ocen: ");
            float srednia = float.Parse(Console.ReadLine());
            if (srednia < 2.00)
            {
                Console.WriteLine("Srednia nie moze byc tak niska");
            }
            else if (srednia >= 2.00 && srednia <= 3.99)
            {
                Console.WriteLine("Brak stypednium");
            }
            else if (srednia >= 4.00 && srednia <= 4.79)
            {
                Console.WriteLine("Kwota stypednium dla podanej sredniej wynosi 350zl ");
            }
            else if (srednia >= 4.80 && srednia <= 5.00)
            {
                Console.WriteLine("Kwota stypednium dla podanej sredniej wynosi 550zl ");
            }
            else if (srednia >= 5.00)
            {
                Console.WriteLine("Srednia nie moze byc tak wysoka");
            }
            Console.ReadKey();
        }
    }
}
