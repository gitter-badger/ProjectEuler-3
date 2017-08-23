using System;
using System.Collections.Generic;
using System.Text;

using static ProjectEuler.MathHelper;

namespace ProjectEuler
{
	/// <summary>
	/// Solves the problems 1-10 of Project Euler ( https://projecteuler.net/archives )
	/// </summary>
	public static class Set1
    {
        /// <summary>
        /// Finds the sum of all multiples of a or b below c
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int Problem1(int a, int b, int c)
        {
			return SumDivisibleBy(a, c) + SumDivisibleBy(b, c) - SumDivisibleBy(a * b, c);
		}
    }
}
