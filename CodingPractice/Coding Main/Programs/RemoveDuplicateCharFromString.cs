namespace Coding_Main.Programs
{
    internal class RemoveDuplicateCharFromString
    {

        public string RemoveDuplicateCharacters(string text)
        {

            string result = string.Empty;

            foreach (char c in text) {
                if (!result.Contains(c))
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
