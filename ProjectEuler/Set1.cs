using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class Set1
    {
        /// <summary>
        /// Solves the problems 1-10 of Project Euler ( https://projecteuler.net/archives )
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int Problem1(int a, int b, int c)
        {
            int sum = 0;
            for (int i = 1; i < c; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }

            }
            return sum;
        }
    }
}
