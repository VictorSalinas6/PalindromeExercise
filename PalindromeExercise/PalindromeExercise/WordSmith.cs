using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {

            var charArray = word.ToCharArray();
            var charLength = charArray.Length;
            var counter = charLength - 1;
            var answer = true;

            for (int i = 0; i < charLength; i++)
            {
                if (charArray[i] != charArray[counter])
                    answer = false;
                counter--;
            }


            return answer;
        }
    }
}
