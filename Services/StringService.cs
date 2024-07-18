using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Application.Services
{
    public class StringService
    {
        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public bool IsPalindrome(string input)
        {
            string reversed = ReverseString(input);
            return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
