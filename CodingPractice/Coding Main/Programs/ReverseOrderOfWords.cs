using System.Text;

namespace Coding_Main.Programs
{
    internal class ReverseOrderOfWords
    {
        public string ReverseOrderOfTheWords(string words) {

            if (!string.IsNullOrEmpty(words))
            {
                var wordsList = words.Split(" ");

                String result = string.Empty;

                foreach (var word in wordsList) {
                    if (word == wordsList[0])
                    {
                        result = (word);
                    }
                    else
                        result = $"{word} {result}";
                }
                return result ;
            }
            return null;
            
        }
    }
}
