using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int howManyNumbers = 0, sum = 0, workingNumber = 1;
            while (sum < 100)
            {
                howManyNumbers++;
                sum += workingNumber;
                workingNumber++;
            }
            Console.Write("Ilość użytych liczb: {0} | Największa użyta liczba: {1} | Suma: {2}", howManyNumbers, workingNumber, sum);
            Console.ReadKey();

        }
    }
}