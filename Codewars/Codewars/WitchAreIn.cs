using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class WitchAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            HashSet<string> set = new HashSet<string>();
            foreach (string a2 in array2)
            {
                foreach (string a1 in array1)
                {
                    if (a2.Contains(a1))
                    {
                        set.Add(a1);
                    }
                }
            }
            List<String> output = set.ToList();
            output.Sort();
            return output.ToArray();
        }
    }
}
