using NUnit.Framework;
using Text;
using System;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Str_IsPalindrome_casac()
        {
            Assert.IsTrue(Str.IsPalindrome("casac"));
        }

        [Test]
        public void Str_IsPalindrome_casa()
        {
            Assert.IsFalse(Str.IsPalindrome("casa"));
        }

        [Test]
        public void Str_IsPalindrome_anitalavalatina()
        {
            Assert.IsTrue(Str.IsPalindrome("anitalavalatina"));
        }

        [Test]
        public void Str_IsPalindrome_Long_text()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        [Test]
        public void Str_IsPalindrome_empty_string()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        [Test]
        public void Str_IsPalindrome_Racecar()
        {
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
        }
    }
}
