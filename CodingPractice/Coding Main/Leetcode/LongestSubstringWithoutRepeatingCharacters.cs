namespace Coding_Main.Leetcode
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s == " ")
            {
                return 1;
            }
            string largestSubstring = string.Empty;
            string secondLargestSubs = string.Empty;
            foreach (char c in s)
            {
                if (!secondLargestSubs.Contains(c))
                {
                    secondLargestSubs += c;
                }
                else
                {
                    if (largestSubstring.Length < secondLargestSubs.Length)
                    {
                        largestSubstring = secondLargestSubs;
                    }
                    int index = secondLargestSubs.LastIndexOf(c);

                    secondLargestSubs = secondLargestSubs.Substring(index + 1);
                    secondLargestSubs += c;
                }
            }

            if (largestSubstring.Length < secondLargestSubs.Length)
            {
                largestSubstring = secondLargestSubs;
            }

            return largestSubstring.Length;
        }
    }
}
