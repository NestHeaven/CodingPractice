using System.Collections.Generic;

namespace Coding_Main.Programs
{
    public class ValidatePattern
    {
        public static bool ValidateThePattern(string pattern)
        {
            List<char> chars = [];

            bool isValidPattern = true;

            for (int i = 0; i <= pattern.Length - 1; i++)
            {
                if (pattern[i] == '{' && (i + 1) <= pattern.Length - 1 && pattern[i + 1] == '}')
                {
                    i ++;
                    continue;
                }
                else if (pattern[i] == '{')
                {
                    chars.Add(pattern[i]);
                }
                else if (pattern[i] =='}' && chars.Count>0)
                {
                    chars.Remove('{');
                }
                else if(pattern[i] == '}' && chars.Count <= 0)
                {
                    isValidPattern = false;
                    break;
                }
            }

            if (chars.Count > 0) { 
                isValidPattern = false;
            }
            return isValidPattern; 
        }
    }
}
