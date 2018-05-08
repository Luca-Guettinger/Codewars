using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class getMidCharacter
    {
        public static string GetMiddle(string s)
        {
            if (IsOdd(s.Length))
            {
                return "" + s.ToCharArray()[s.ToCharArray().Length / 2];
            }
            else
            {
                return "" + s.ToCharArray()[s.ToCharArray().Length / 2 - 1] + s.ToCharArray()[s.ToCharArray().Length / 2];
            }
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
