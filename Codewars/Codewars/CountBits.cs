using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class CountBits
    {
        public static int CountBitss(int n)
        {
            int count = 0;
            string bin = IntToBinary(n);

            foreach (char c in bin.ToCharArray())
            {
                if (c.Equals('1'))
                {
                    count++;
                }
            }
            return count;

        }

        public static string IntToBinary(int num)
        {
            int quot;
            string rem = "";
            while (num >= 1)
            {
                quot = num / 2;
                rem += (num % 2).ToString();
                num = quot;
            }
            string bin = "";
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];
            }
            return bin;
        }
    }
}
