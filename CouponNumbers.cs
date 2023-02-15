using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class CouponNumbers
    {
        public static void distinctCouponNumber()
        {
            Console.WriteLine("Enter total number of distinct Coupon Numbers you want: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] couponNumber = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                couponNumber[i] = random.Next(1, 100);

                
                for(int j = i-1 ; j > 0; j--)
                {
                    if (couponNumber[j] == couponNumber[i])
                    {
                        i--;
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Coupon numer {i+1}: {couponNumber[i]}");
            }

           
        }
    }
}
