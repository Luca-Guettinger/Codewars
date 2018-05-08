using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class CountSmylies
    {
        public static int CountSmileys(string[] smileys)
        {
            int output = 0;
            foreach (string s in smileys)
            {
                if (IsSmiley(s))
                {
                    output++;
                }
            }


            return output;
        }


        public static bool IsSmiley(string s)
        {

            //to long or to short Smylies
            if (s.ToCharArray().Length < 2 || s.ToCharArray().Length > 3) return false;

            //wrong eyes
            if (!s.StartsWith(":") && !s.StartsWith(";")) return false;

            //wrong nose
            if (s.ToCharArray().Length == 3)
            {
                if (!s.ToCharArray()[1].Equals('-') && !s.ToCharArray()[1].Equals('~'))
                {
                    return false;
                }
            }

            //wrong mouth
            if (!s.EndsWith("D") && !s.EndsWith(")")) return false;

            return true;
        }
    }
}
