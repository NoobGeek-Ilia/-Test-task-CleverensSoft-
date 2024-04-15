using NUnit.Framework;
using NUnit.Framework.Legacy;

[TestFixture]
public class SpiralOrderTests
{
    [Test]
    public void TestExample1()
    {
        int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[] expected = { 1, 4, 7, 8, 9, 6, 3, 2, 5 };
        ClassicAssert.AreEqual(expected, SpiralTraverse.SpiralOrder(matrix));
    }

    [Test]
    public void TestExample2()
    {
        int[,] matrix = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
        int[] expected = { 1, 5, 9, 10, 11, 12, 8, 4, 3, 2, 6, 7 };
        ClassicAssert.AreEqual(expected, SpiralTraverse.SpiralOrder(matrix));
    }

    [Test]
    public void TestEmptyMatrix()
    {
        int[,] matrix = new int[0, 0];
        int[] expected = { };
        ClassicAssert.AreEqual(expected, SpiralTraverse.SpiralOrder(matrix));
    }

    [Test]
    public void TestSingleElementMatrix()
    {
        int[,] matrix = new int[1, 1] { { 1 } };
        int[] expected = { 1 };
        ClassicAssert.AreEqual(expected, SpiralTraverse.SpiralOrder(matrix));
    }

    [Test]
    public void TestSingleRowMatrix()
    {
        int[,] matrix = new int[1, 4] { { 1, 2, 3, 4 } };
        int[] expected = { 1, 2, 3, 4 };
        ClassicAssert.AreEqual(expected, SpiralTraverse.SpiralOrder(matrix));
    }

    [Test]
    public void TestSingleColumnMatrix()
    {
        int[,] matrix = new int[4, 1] { { 1 }, { 2 }, { 3 }, { 4 } };
        int[] expected = { 1, 2, 3, 4 };
        ClassicAssert.AreEqual(expected, SpiralTraverse.SpiralOrder(matrix));
    }
}
