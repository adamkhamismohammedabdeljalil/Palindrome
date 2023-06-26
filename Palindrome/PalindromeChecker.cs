using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class PalindromeChecker
    {
        public string ReverseMethod(string input)
        {

            string reverse = string.Empty;
            char[] array = input.ToCharArray();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverse += array[i];
            }
            return reverse;
        }
    }
}

