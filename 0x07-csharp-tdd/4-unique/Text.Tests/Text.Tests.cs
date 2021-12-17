using NUnit.Framework;
using Text;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Str_UniqueChar_not_unique()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aaa"));
        }

        [Test]
        public void Str_UniqueChar_first_char()
        {
            Assert.AreEqual(0, Str.UniqueChar("hello"));
        }

        [Test]
        public void Str_UniqueChar_mid_char()
        {
            Assert.AreEqual(6, Str.UniqueChar("calacablec"));
        }

        [Test]
        public void Str_UniqueChar_last_char()
        {
            Assert.AreEqual(11, Str.UniqueChar("abccdadbgagz"));
        }

        [Test]
        public void Str_UniqueChar_empty_string()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }
    }
}
