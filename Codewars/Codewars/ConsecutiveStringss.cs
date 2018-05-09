using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class ConsecutiveStringss
    {
        //public static String LongestConsec(String[] StringArray, int k)
        //{

        //    if (StringArray.Length <= 0 || k > StringArray.Length || k <= 0) return "";

        //    var cShaprsHashMap = new SortedDictionary<String, int>();  

        //    for (int i = 0; i < StringArray.Length; i++)
        //    {
        //        cShaprsHashMap[StringArray[i]] = StringArray[i].Length;
        //    }

        //    var myList = cShaprsHashMap.ToList();

        //    myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

        //    String output = "";
        //    for (int i = 0; i < k; i++)
        //    {
        //        output += myList[myList.Count-i-1].Key;
        //    }
        //    return output;
        //}
        //

        public static String LongestConsec(String[] stringArray, int k)
        {
            stringArray.OrderBy(e => e.Length);

            var enumabrle = stringArray.Where(e => e.StartsWith("A")).OrderBy(e => e.Length);


            var namen = new String[] { "a", "b" };

            var namen2 = new List<int>();



            String output = "";
            for (int i = 0; i < k; i++)
            {
                output += myList[myList.Count - i - 1].Key;
            }
            return output;
        }
    }
}
