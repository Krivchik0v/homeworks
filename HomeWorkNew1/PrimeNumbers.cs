using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public static class PrimeNumberGenerator
    {
        public static int[] Generate(int count)
        {
            int[] numbers = new int[count];
            int index = 0;
            int number = 2;
            while (index < count)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    numbers[index] = number;
                    index++;
                }

                number++;
            }
            return numbers;

        }
    }
}