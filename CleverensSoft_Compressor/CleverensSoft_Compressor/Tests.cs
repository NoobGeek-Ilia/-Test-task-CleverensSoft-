using NUnit.Framework;
using NUnit.Framework.Legacy;

[TestFixture]
public class CompressionTests
{
    // Покрыл тестами

    [TestCase("aaabbc", "a3b2c")]
    [TestCase("aabbbccc", "a2b3c3")]
    [TestCase("abcd", "abcd")]
    public void Compress_ValidInput_ReturnsExpected(string input, string expected)
    {
        ClassicAssert.AreEqual(expected, Compression.Compress(input));
    }

    [TestCase("a3b2c", "aaabbc")]
    [TestCase("a2b3c3", "aabbbccc")]
    [TestCase("abcd", "abcd")]
    public void Decompress_ValidInput_ReturnsExpected(string input, string expected)
    {
        ClassicAssert.AreEqual(expected, Compression.Decompress(input));
    }

    [Test]
    public void Compress_InvalidInput_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => Compression.Compress("abc123"));
    }

    [Test]
    public void Decompress_InvalidInput_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => Compression.Decompress("abc123"));
    }
}
