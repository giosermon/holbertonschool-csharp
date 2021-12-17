using NUnit.Framework;
using Text;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test_Str_CamelCase_null()
        {
            Assert.AreEqual(0, Str.CamelCase(null));
        }

        [Test]
        public void Test_Str_CamelCase_empty_string()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        public void Test_Str_One_Word()
        {
            Assert.AreEqual(1, Str.CamelCase("hello"));
        }

        public void Test_Str_Two_Word()
        {
            Assert.AreEqual(2, Str.CamelCase("hello World!"));
        }

        public void Test_Str_Three_Word()
        {
            Assert.AreEqual(3, Str.CamelCase("helloWorld!Finally "));
        }
    }
}
