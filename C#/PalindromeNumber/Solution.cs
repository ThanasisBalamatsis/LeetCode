using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
