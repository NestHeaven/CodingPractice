using Coding_Main.Delegate;

namespace Coding_Main.Programs
{
    public class DivideArrayEqualParts
    {
        //2206. Divide Array Into Equal Pairs
        //Easy
        //Topics
        //Companies
        //Hint
        //You are given an integer array nums consisting of 2 * n integers.

        //You need to divide nums into n pairs such that:

        //Each element belongs to exactly one pair.
        //The elements present in a pair are equal.


        public static bool DivideArrayAndCheckEqual(List<int> arr)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                if (freq.TryGetValue(i, out int value))
                {
                    freq[i] = ++value;
                }
                else freq[i] = 1;
            }

            foreach(var count in freq.Values)
            {
                if(count %2 !=0) 
                    return false;

            }

            return true;
        }
    }
}
