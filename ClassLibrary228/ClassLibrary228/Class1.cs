using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary228
{
    public class Class228
    {
        // Euclidean algorithm implementation. Hello to all ancient Greek mathmatitians
        public static int FindGreatestCommonDivisor(int num1, int num2)
        {
            while (num1 != 0 && num2 != 0)
            {
                if (num1 > num2)
                    num1 %= num2;
                else
                    num2 %= num1;
            }

            var output = num1 | num2;

            return output;
        }
    }
}
