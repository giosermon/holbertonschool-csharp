using System;

namespace Text
{
    /// <summary>
    /// Class Str
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Get the first uniq char
        /// </summary>
        /// <param name="s">String</param>
        /// <returns>First uniq index</returns>
        public static int UniqueChar(string s)
        {
            if (s.Length == 0)
                return -1;

            int length = s.Length;
            bool isRepeated;
            string repeated = "";
            for (int i = 0; i < length; i++)
            {
                isRepeated = false;
                if (repeated.Contains(s[i].ToString()))
                    continue;

                for (int j = i + 1; j < length; j++)
                {
                    if (s[i] == s[j])
                    {
                        isRepeated = true;
                        repeated += s[i];
                        break;
                    }
                }

                if (!isRepeated)
                    return i;
            }

            return -1;
        }
    }
}
