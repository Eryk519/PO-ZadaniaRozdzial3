using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float waga, wzrost, BMI;
            Console.WriteLine("Podaj swoja wage w kilogramach:");
            waga = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoj wzrost w metrach:");
            wzrost = float.Parse(Console.ReadLine());
            BMI = waga / (wzrost * wzrost);
            Console.WriteLine("Twoje BMI wynosi:" + BMI);
            if (BMI < 16)
                Console.WriteLine("Wygłodzenie");
            else if (BMI > 16 && BMI < 16.99)
                Console.WriteLine("Wychudzenie");
            else if (BMI > 17 && BMI < 18.49)
                Console.WriteLine("Niedowaga");
            else if (BMI > 18.5 && BMI < 24.99)
                Console.WriteLine("Pozadana masa ciala");
            else if (BMI > 25 && BMI < 29.99)
                Console.WriteLine("Nadwaga");
            else if (BMI > 30 && BMI < 34.99)
                Console.WriteLine("Otylosc I stopnia");
            else if (BMI > 35 && BMI < 39.99)
                Console.WriteLine("Otylosc II stopnia");
            else if (BMI > 40)
                Console.WriteLine("otylosc III stopnia");
            Console.ReadLine();

        }
    }
}
