using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    public static class FibonacciNumbersGenerator
    {
        public static int[] Generate(int count)
        {
            int[] numbers = new int[count];
            numbers[0] = 0;
            numbers[1] = 1;
            for (int i = 2; i < count; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
            }
            return numbers;
        }
    }
}
