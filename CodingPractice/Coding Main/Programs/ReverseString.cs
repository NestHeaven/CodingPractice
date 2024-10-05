namespace Coding_Main.Programs
{
    public class ReverseString
    {
        public string GetReversedStringApproach1(string str)
        {
            string result = string.Empty;

            foreach (char c in str) {

                result = $"{c}{result}";
            }
            return result;
        }

        public string GetReversedStringApproach2(string str)
        {
            string result = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }
    }
}
