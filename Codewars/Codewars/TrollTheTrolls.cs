using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class TrollTheTrolls
    {
        public static String Disemvowel(string str)
        {
            Char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            foreach (Char vowel in vowels)
            {
                str = str.Replace(vowel + "", "");
            }

            return str;
        }
    }
}
