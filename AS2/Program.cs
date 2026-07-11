using System;

namespace AS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 273, 24, 310, 340, 450 };

            Console.WriteLine("Array Elements:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}