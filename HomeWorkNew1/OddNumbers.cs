﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbers
{
    public static class OddNumberGenerator
    {
        public static int[] Generate(int count)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = 2 * i + 1;
            }
            return numbers;
        }
    }
}