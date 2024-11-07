namespace Coding_Main.Leetcode
{
    public class TwoSum
    {
        public static int[] TwoSumProblem(int[] nums, int target)
        {

            int[] aar = new int[2];

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for (int j = 0; j <= nums.Length - 1; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (nums[i] + nums[j] == target)
                    {
                        aar[0] = i;
                        aar[1] = j;
                        return aar;
                    }
                }
            }
            return aar;
        }
    }
}