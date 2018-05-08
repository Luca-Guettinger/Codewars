using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class IQTest
    {
        public static int Test(string numbers)
        {

            String[] n = numbers.Split(' ');

            List<int> Odd = new List<int>();
            List<int> Even = new List<int>();

            for (int i = 0; i < n.Length; i++)
            {

                int ii = Int32.Parse(n[i]);

                if (IsOdd(ii))
                {
                    Odd.Add(ii);
                }
                else
                {
                    Even.Add(ii);
                }
            }

            if (Odd.Count > Even.Count)
            {
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i].Equals("" + Even[0]))
                    {
                        return i + 1;
                    }
                }
            }
            else if (Odd.Count < Even.Count)
            {
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i].Equals("" + Odd[0]))
                    {
                        return i + 1;
                    }
                }
            }
            return -1;
        }


        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
