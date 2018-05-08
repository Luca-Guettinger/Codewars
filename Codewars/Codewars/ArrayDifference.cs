using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class ArrayDifference
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {

            List<int> list = a.OfType<int>().ToList();
            foreach (int int1 in a)
            {
                foreach (int int2 in b)
                {
                    if (int1 == int2)
                    {
                        list.Remove(int1);
                    }
                }
            }

            return list.ToArray<int>();
        }
    }
}
