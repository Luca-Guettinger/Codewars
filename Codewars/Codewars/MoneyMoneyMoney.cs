using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class MoneyMoneyMoney
    {
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {

            int years = 0;


            while (principal < desiredPrincipal)
            {
                double amountToAdd = (principal / 100 * (interest * 100)) - 0;
                amountToAdd -= (amountToAdd / 100 * (tax * 100)) - 0;
                principal += amountToAdd;
                years++;
            }

            return years;
        }
    }
}
