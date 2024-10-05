namespace Coding_Main.Programs
{
    internal class Palindrome
    {

        public string CheckPalindrome(string palindrome) { 
            
            bool isPalidrome = false;

            for (int i = 0, j = palindrome.Length - 1; i < palindrome.Length /2; i++, j--) {
                if (palindrome[i] != palindrome[j])
                {
                    isPalidrome = false;
                    break;
                }
                else
                    isPalidrome = true;
            }

            if (isPalidrome)
                return "Palindrome";
            else
                return "Not Palindrome";
        }
    }
}
