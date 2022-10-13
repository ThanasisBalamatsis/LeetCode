using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNote
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            List<char> magazineChars = magazine.ToList();
            foreach (char character in ransomNote)
            {
                if (!magazineChars.Contains(character))
                    return false;
                else
                    magazineChars.Remove(character);
            }
            return true;
        }
    }
}
