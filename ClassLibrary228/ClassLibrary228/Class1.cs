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
        { // 0
            while (num1 != 0 /* 1 */ && num2 != 0 /* 2 */)
            {
                if (num1 > num2) // 3
                    num1 %= num2; // 4
                else
                    num2 %= num1; // 5
            } // 6

            var output = num1 | num2; // 7

            return output; // 8
        } // 9
    }
}
