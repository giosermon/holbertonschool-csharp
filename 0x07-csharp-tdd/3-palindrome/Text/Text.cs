using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// Class Str
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Return true or false if a string is a palindrome
        /// </summary>
        /// <param name="s">String to check</param>
        /// <returns>true or false</returns>
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0)
                return true;

            string str = "";
            for (int i = 0; i < s.Length; i++)
                if (s[i] >= 'A' && s[i] <= 'Z' || s[i] >= 'a' && s[i] <= 'z')
                    str += s[i];

            str = str.ToLower();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
                if (str[i] != str[j])
                    return false;

            return true;
        }
    }
}
