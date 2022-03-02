using System;

namespace PrimeNumberChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a number to be checked.");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            int factor = 2;

            while (true)
            {
                int remainder = number % factor;
                Console.WriteLine("Factor: " + factor.ToString() + " || Remainder: " + remainder.ToString());
                if (remainder > 0)
                {
                    factor++;
                }else if (number == factor)
                {
                    Console.WriteLine("This number is a prime number.");
                    break;
                }else if (remainder == 0)
                {
                    Console.WriteLine("This number is not a prime number.");
                    break;
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Press enter to exit.");
            Console.ReadKey();
        }
    }
}