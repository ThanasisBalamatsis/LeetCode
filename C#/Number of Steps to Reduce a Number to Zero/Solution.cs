
namespace ReduceToZero
{
    public class Solution
    {
        public int NumberOfSteps(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count++;
                if (num % 2 == 0)
                    num = num / 2;
                else
                    num--;
            }
            return count;
        }
    }
}
