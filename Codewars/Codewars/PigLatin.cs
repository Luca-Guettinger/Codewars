using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class PigLatin
    {
        public static string PigIt(string str)
        {
            string st = "";

            foreach (string s in str.Split(' '))
            {
                st += s.Remove(0, 1) + s.ToCharArray()[0] + "ay ";
            }
            st = st.Remove(st.ToCharArray().Length - 1, 1);

            return st;
        }
    }
}
