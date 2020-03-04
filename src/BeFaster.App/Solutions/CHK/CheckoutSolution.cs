using BeFaster.Runner.Exceptions;
using System.Linq;
using System.Text.RegularExpressions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string skus)
        {
            int checkoutAmount = 0;
            if (string.IsNullOrEmpty(skus))
            {
                return 0;
            }
            if (!Regex.IsMatch(skus, @"^[A-E]+$"))
            {
                return -1;
            }
            int A_count = skus.Count(v => v == 'A');
            int B_count = skus.Count(v => v == 'B');
            int C_count = skus.Count(v => v == 'C');
            int D_count = skus.Count(v => v == 'D');
            int E_count = skus.Count(v => v == 'E');
            checkoutAmount = checkoutAmount + ((A_count / 5) * 130);
            checkoutAmount = checkoutAmount + ((A_count % 3) * 50);
            checkoutAmount = checkoutAmount + ((A_count / 3) * 130);
            checkoutAmount = checkoutAmount + ((B_count % 2) * 30);
            checkoutAmount = checkoutAmount + ((B_count / 2) * 45);
            checkoutAmount = checkoutAmount + (C_count * 20);
            checkoutAmount = checkoutAmount + (D_count * 15);
            return checkoutAmount;
        }
    }
}




