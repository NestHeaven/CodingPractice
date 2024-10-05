using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Main.Programs
{
    internal class CountOccurenceOfChar
    {

        public void PrintCountofOccurencesOfEachCharacter(string str)
        {

            Dictionary<char, int> keyValuePairs = [];

            foreach (char ch in str)
            {
                if (ch == ' ')
                    continue;
                else if (keyValuePairs.TryGetValue(ch, out int value))
                    keyValuePairs[ch] = ++value;
                else keyValuePairs[ch] = 1;

            }

            foreach(var item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
