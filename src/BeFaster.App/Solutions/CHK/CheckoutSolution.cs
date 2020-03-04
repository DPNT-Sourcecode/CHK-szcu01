using BeFaster.Runner.Exceptions;
using System.Text.RegularExpressions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string skus)
        {
            int checkoutAmount = 0;
            if (!Regex.IsMatch(skus, @"^[A-D]+$"))
            {
                return -1;
            }
            //foreach (char c in skus)
            //{
            //    if (c == 'A')
            //    {
            //        checkoutAmount = checkoutAmount + 50;
            //    }
            //    else if (c == 'B')
            //    {
            //        checkoutAmount = checkoutAmount + 50;
            //    }
            //    else if (c == 'C')
            //    {
            //        checkoutAmount = checkoutAmount + 50;
            //    }
            //    else if (c == 'D')
            //    {
            //        checkoutAmount = checkoutAmount + 50;
            //    }
            //}
        }
    }
}


