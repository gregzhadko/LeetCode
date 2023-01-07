using NUnit.Framework;

namespace LetterCombinationsOfAPhoneNumber;

public class Tests
{
    [Test]
    public void Test1()
    {
        var result = new Solution().LetterCombinations("23");
        CollectionAssert.AreEquivalent(new List<string> { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf", }, result);
    }

    [Test]
    public void Test2()
    {
        var result = new Solution().LetterCombinations("2");
        Assert.AreEqual(3, result.Count);
        Assert.AreEqual("a", result[0]);
        Assert.AreEqual("b", result[1]);
        Assert.AreEqual("c", result[2]);
    }

    [Test]
    public void Test3()
    {
        var result = new Solution().LetterCombinations("");
        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public void Test4()
    {
        var result = new Solution().LetterCombinations("7");
        Assert.AreEqual(4, result.Count);
        Assert.AreEqual("p", result[0]);
        Assert.AreEqual("q", result[1]);
        Assert.AreEqual("r", result[2]);
        Assert.AreEqual("s", result[3]);
    }

    [Test]
    public void Test5()
    {
        var result = new Solution().LetterCombinations("9");
        Assert.AreEqual(4, result.Count);
        Assert.AreEqual("w", result[0]);
        Assert.AreEqual("x", result[1]);
        Assert.AreEqual("y", result[2]);
        Assert.AreEqual("z", result[3]);
    }
}