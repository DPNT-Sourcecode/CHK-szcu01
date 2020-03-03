using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string skus)
        {
            int checkoutAmount = 0;
            foreach (char c in skus)
            {
                if (c == 'A')
                {
                    checkoutAmount = checkoutAmount + 50;
                }
                else if (c == 'B')
                {
                    checkoutAmount = checkoutAmount + 50;
                }
                else if (c == 'C')
                {
                    checkoutAmount = checkoutAmount + 50;
                }
                else if (c == 'D')
                {
                    checkoutAmount = checkoutAmount + 50;
                }
            }
        }
    }
}


