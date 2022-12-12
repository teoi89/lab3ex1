using System;

namespace lab3ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti o functie care va calcula suma cifrelor unui numar  */
            Console.WriteLine("Introduceti un numar");
            int num = int.Parse(Console.ReadLine());
            int sum = GetSumOfANumber(num);
            Console.WriteLine("Suma cifrelor numarului, " + num + ", este " + sum);
        }
        static int GetSumOfANumber(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum = sum + i % 10;
                i = i / 10;
            }
            return sum;
        }
    }
}
