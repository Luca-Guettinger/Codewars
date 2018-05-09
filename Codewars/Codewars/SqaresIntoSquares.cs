using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class SqaresIntoSquares
    {
        public string decompose(long n)
        {
            List<long> allNumbersToUse = new List<long>();

            for (int i = 1; i < n; i++)
            {
                allNumbersToUse.Add(i * i);
            }

            foreach (int number in allNumbersToUse)
            {
                Console.WriteLine(number);
            }

            for (int startIndex = 0; startIndex < n; startIndex++)
            {
                for (int numbersToAdd = 0; numbersToAdd < (n - startIndex); numbersToAdd++)
                {
                    long startNumber = 0;
                    for (int numberGenerator = 0; numberGenerator < numbersToAdd; numberGenerator++)
                    {
                        startNumber += allNumbersToUse[(startIndex + numbersToAdd)];
                    }
                    if (startNumber == n * n)
                    {
                        Console.WriteLine("geht ja ehh nicht...");
                    }
                }
            }
            return "";
        }
    }
}
