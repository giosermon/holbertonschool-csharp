using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_Matrix_Divide_Arr_7Width_1Height()
        {
            int[,] arr = new int[,] { { 0 }, { 1 }, { 2 }, { 3 }, { 4 }, { 5 }, { 6 } };
            int[,] res = new int[,] { { 0 }, { 0 }, { 1 },  { 1 },  { 2 }, { 2 },  { 3 } };

            Assert.AreEqual(res, Matrix.Divide(arr, 2));
        }

        [Test]
        public void Test_Matrix_Divide()
        {
            int[,] arr = new int[,] { { 2, 2, 18}, { 1, 2, 3} };
            int[,] res = new int[,] { { 1, 1, 9}, { 0, 1, 1} };

            Assert.AreEqual(res, Matrix.Divide(arr, 2));
        }

        [Test]
        public void Test_Matrix_Divide_by_0()
        {
            int[,] arr = new int[,] { { 2, 2, 18}, { 1, 2, 3} };

            Assert.AreEqual(null, Matrix.Divide(arr, 0));
        }

        [Test]
        public void Test_Matrix_Divide_Null_Matrix_by_3()
        {
            int[,] arr = null;

            Assert.AreEqual(null, Matrix.Divide(arr, 3));
        }
    }
}
