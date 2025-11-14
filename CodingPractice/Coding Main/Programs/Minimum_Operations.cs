namespace Coding_Main.Programs
{
    public class Minimum_Operations
    {
        public static int MinOperations(int[] nums)
        {

            int operations = 0;
            for (int i = 0; i <= nums.Length; i++)
            {
                if (i + 3 > nums.Length)
                {
                    if (nums[i] == 0) return -1;
                    if (nums[i + 1] == 0) return -1;
                }

                if (nums[i] == 0)
                {
                    nums[i] = 1;

                    if (nums[i + 1] == 1)
                        nums[i + 1] = 0;
                    else
                        nums[i + 1] = 1;

                    if (nums[i + 2] == 1)
                        nums[i + 2] = 0;
                    else
                        nums[i + 2] = 1;

                    operations++;
                }
            }
            return operations;
        }
    }
}
