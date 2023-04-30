namespace PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            var reversedString = new string(x.ToString().Reverse().ToArray());

            return reversedString == x.ToString();
        }
    }
}
