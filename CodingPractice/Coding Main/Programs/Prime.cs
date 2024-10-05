using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Main.Programs
{
    internal static class Prime
    {
        public static bool IsPrime(int num)
        {
            if (num <= 1) return false; // 0 and 1 are not prime numbers
            if (num == 2) return true;  // 2 is the only even prime number
            if (num % 2 == 0) return false; // eliminate even numbers greater than 2

            // Check for factors from 3 to the square root of num
            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0) return false; // Found a factor
            }

            return true; // No factors found, it's prime
        }
    }
}
