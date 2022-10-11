using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public static bool IsAPalindrome(string answer)
        {
            if (answer == null || answer == "")
            {
                return false;
            }
            string lower = answer.ToLower();
            string reversed = "";

            for (int i = answer.Length - 1; i >=0; i--)
            {
                reversed += lower[i];
            }

            return lower == reversed;  
        }
    }
}
