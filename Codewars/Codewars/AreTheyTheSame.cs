using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class AreTheyTheSame
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null) return false;
            if (a.Length != b.Length) return false;

            for (int i = 0; i < 3; i++)
            {
                for (int aInt = 0; aInt < a.Length; aInt++)
                {
                    for (int bInt = 0; bInt < b.Length; bInt++)
                    {
                        if (a[aInt] == (int)Math.Sqrt(b[bInt]))
                        {
                            b[bInt] = (int)Math.Sqrt(b[bInt]);
                        }
                        if (b[bInt] == (int)Math.Sqrt(a[aInt]))
                        {
                            a[aInt] = (int)Math.Sqrt(a[aInt]);
                        }
                    }
                }
            }

            List<int> aList = a.ToList();
            List<int> bList = b.ToList();

            for (int toBeSave = 0; toBeSave < a.Length; toBeSave++)
            {
                for (int i = 0; i < aList.Count; i++)
                {
                    if (bList.Contains(aList[i]))
                    {
                        bList.Remove(aList[i]);
                        aList.Remove(aList[i]);
                    }
                }
            }
            return aList.Count == 0 && bList.Count == 0;
        }
    }
}
