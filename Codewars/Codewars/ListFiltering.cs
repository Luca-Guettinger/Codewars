using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class ListFiltering
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> list = new List<int>();

            foreach (object o in listOfItems)
            {
                int i = 0;
                if (o.GetType() == i.GetType())
                {
                    list.Add((int)o);
                }
            }
            return list;
        }
    }
}
