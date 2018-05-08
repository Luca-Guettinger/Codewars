using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class MovingZerosToTheEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> allInts = arr.ToList();


            for (int times = 0; times < arr.Length; times++)
            {
                for (int i = 0; i < allInts.Count; i++)
                {

                    if (allInts[i] == 0)
                    {
                        allInts.RemoveAt(i);
                        allInts.Add(0);
                        break;
                    }
                }
            }
            return allInts.ToArray();
        }
    }
}
