using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class PrimeNumber
    {
        public static void checkPrime()
        {
            int factors = 1;
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    factors++;
                }
            }

            if (factors == 2)
            {
                Console.WriteLine($"{num} is a prime number");
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
        }
    }
}
