using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class Ccrambles
    {
        public static bool Scramble(string str1, string str2)
        {
            foreach (char s in str2.ToCharArray())
            {
                if (!str1.Contains(s))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
