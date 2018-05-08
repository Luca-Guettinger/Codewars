using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class Eureka
    {
        public static long[] SumDigPow(long a, long b)
        {
            List<long> outputList = new List<long>();

            for (long l = b - (b - a); l <= b; l++)
            {
                char[] lChars = l.ToString().ToCharArray();
                long number = 0;
                for (int i = 0; i < lChars.Length; i++)
                {
                    number += (long)Math.Pow(Int32.Parse(lChars[i].ToString()), i + 1);
                    if (i + 1 == lChars.Length && number == l) outputList.Add(number);
                }
            }
            return outputList.ToArray();
        }
    }
}
