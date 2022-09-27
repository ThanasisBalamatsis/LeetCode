namespace Richest_Customer_Wealth
{
    public class Solution
    {
        public int MaximumWealth(int[][] accounts)
        {
            int maxWealth = 0;

            foreach (int[] account in accounts)
            {
                int wealth = account.Sum();
                if (wealth > maxWealth)
                    maxWealth = wealth;
            }

            return maxWealth;
        }
    }
}
