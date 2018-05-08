using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class TrippleDoubleX
    {
        public static int TripleDouble(long num1, long num2)
        {
            if (contains3(num1) && contains2(num2)) return 1;
            else return 0;
        }


        public static bool contains3(long num1)
        {
            char[] chars = ("" + num1).ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                try
                {
                    if (chars[i].Equals(chars[i + 1]) && chars[i].Equals(chars[i + 2]))
                    {
                        return true;
                    }
                }
                catch (IndexOutOfRangeException e) { }
            }
            return false;
        }

        public static bool contains2(long num2)
        {
            char[] chars = ("" + num2).ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                try
                {
                    if (chars[i].Equals(chars[i + 1]))
                    {
                        return true;
                    }
                }
                catch (IndexOutOfRangeException e) { }
            }
            return false;
        }
    }
}
