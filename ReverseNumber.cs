using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class ReverseNumber
    {
        public static void printReverse()
        {
            Console.WriteLine("Enter a multi digit number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem, sum = 0;
            Console.WriteLine($"Given number is: {num}");

            while (num > 0)
            {
                rem = num % 10;
                sum = sum * 10 + rem;
                num /= 10;
            }
            Console.WriteLine($"Reverse of a number is: {sum}");
        }
    }
}
