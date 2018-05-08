using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class FindTheOdd
    {
        public static int find_it(int[] seq)
        {
            foreach (int i in seq)
            {
                if ((seq.Where(item => item == i).Count()) % 2 != 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
