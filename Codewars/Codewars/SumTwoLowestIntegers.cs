using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class SumTwoLowestIntegers
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            var lowIntegers = new int[2];

            lowIntegers[0] = getSmallestNumber(numbers);

            var list = numbers.ToList();
            list.Remove(lowIntegers[0]);

            lowIntegers[1] = getSmallestNumber(list.ToArray());

            return lowIntegers[0] + lowIntegers[1];
        }

        public static int getSmallestNumber(int[] numbers)
        {
            int lowest = numbers[0];

            foreach (int i in numbers)
            {
                if (i < lowest)
                    lowest = i;
            }

            return lowest;
        }
    }
}
