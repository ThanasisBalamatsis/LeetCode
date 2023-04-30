namespace GroupAnagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var uniqueStrings = new List<string>();
            var anagrams = new List<IList<string>>();

            foreach (var str in strs)
            {
                var stringSorted = SortString(str);

                if (uniqueStrings.Contains(stringSorted))
                {
                    var index = uniqueStrings.IndexOf(stringSorted);
                    anagrams[index].Add(str);
                }
                else
                {
                    uniqueStrings.Add(stringSorted);
                    anagrams.Add(new List<string>() { str});
                }
            }

            return anagrams;
        }

        private string SortString(string givenString)
        {
            var charArray = givenString.ToCharArray();
            Array.Sort(charArray);

            return new string(charArray);
        }
    }
}
