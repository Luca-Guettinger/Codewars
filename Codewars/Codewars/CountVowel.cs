using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class CountVowel
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            Char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (Char vowel in vowels)
            {
                foreach (Char c in str.ToLower().ToCharArray())
                {
                    if (vowel.Equals(c)) vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
