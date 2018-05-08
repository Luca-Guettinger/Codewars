using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class XO
    {
        public static bool XOx(string input)
        {

            input = input.ToLower();

            int x = 0;
            int o = 0;

            foreach (Char c in input.ToCharArray())
            {
                if (c == 'x') x++;
                if (c == 'o') o++;
            }

            if (x == o) return true;

            return false;
        }
    }
}
