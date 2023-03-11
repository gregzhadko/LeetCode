using NUnit.Framework;

namespace MaxSumOfAPairWithEqualSumOfDigits;

public class Tests
{
    [Test]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.MaximumSum(new[] { 18, 43, 36, 13, 7 });
        Assert.AreEqual(54, result);
    }

    [Test]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.MaximumSum(new[] { 10, 12, 19, 14 });
        Assert.AreEqual(-1, result);
    }

    [Test]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.MaximumSum(new[] { 229, 398, 269, 317, 420, 464, 491, 218, 439, 153, 482, 169, 411, 93, 147, 50, 347, 210, 251, 366, 401 });
        Assert.AreEqual(973, result);
    }
}