using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public class Set1
    {
        public int Problem1(int a, int b, int c)
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
