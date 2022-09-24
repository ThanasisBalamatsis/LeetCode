namespace RomanToInteger
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            bool skipIteration = false;
            int result = 0;
            Dictionary<char, int> charIntPairs = new Dictionary<char, int>()
                    {
                        {'I',  1},
                        {'V',  5},
                        {'X',  10},
                        {'L',  50},
                        {'C',  100},
                        {'D',  500},
                        {'M',  1000}
                    };
            Dictionary<string, int> stringIntPairs = new Dictionary<string, int>()
            {
                {"IV", 4 },
                {"IX", 9 },
                {"XL", 40 },
                {"XC", 90 },
                {"CD", 400 },
                {"CM", 900 }
            };

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (skipIteration)
                {
                    skipIteration = false;
                    continue;
                }
                else
                {
                    string nextTwoSymbols = s.Substring(i, 2);

                    if (stringIntPairs.ContainsKey(nextTwoSymbols))
                    {
                        skipIteration = true;
                        result += stringIntPairs[nextTwoSymbols];
                    }
                    else
                    {
                        result += charIntPairs[s[i]];
                    }
                }

            }

            if (skipIteration == false)
            {
                result += charIntPairs[s[s.Length - 1]];
                return result;
            }
            else
                return result;
        }
    }
}