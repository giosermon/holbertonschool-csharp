using System;

namespace Text
{
    /// <summary>
    /// Class Str
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Get the number of words in a string
        /// </summary>
        /// <param name="s">String to analizes</param>
        /// <returns>Number of words</returns>
        public static int CamelCase(string s)
        {
            if (s == null || s.Length == 0)
                return 0;

            int count = 1;
            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                    ++count;
            }

            return count;
        }
    }
}
