using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class PascalsTriangle
    {
        public static List<int> PascalsTriangleList(int n)
        {
            List<int[]> list = new List<int[]>();


            for (int i = 2; i < n; i++)
            {
                int[] a = new int[i + 1];
                a[0] = 1;
                a[i] = 1;

                list.Add(a);
            }

            for (int rows = 2; rows < list.Count; rows++)
            {
                for (int i = 1; i < list[rows].Length - 1; i++)
                {
                    list[rows][i] = list[rows - 1][i - 1] + list[rows - 1][i];
                }
            }

            List<int> output = new List<int>();

            foreach (int[] ia in list)
            {
                foreach (int i in ia)
                {
                    output.Add(i);
                }
            }
            return output;
        }

    }
}
