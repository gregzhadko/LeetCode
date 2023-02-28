using NUnit.Framework;

namespace GenerateMatrix;

public class Tests
{
    [Test]
    public void Test1()
    {
        var expected = new[]
        {
            new[] {1, 2, 3},
            new[] {8, 9, 4},
            new[] {7, 6, 5}
        };
        Assert.AreEqual(expected, new Solution().GenerateMatrix(3));
    }
    
    [Test]
    public void Test2()
    {
        var expected = new[]
        {
            new[] {1, 2, 3, 4},
            new[] {12, 13, 14, 5},
            new[] {11, 16, 15, 6},
            new[] {10, 9, 8, 7}
        };
        Assert.AreEqual(expected, new Solution().GenerateMatrix(4));
    }
    
    [Test]
    public void Test3()
    {
        var expected = new[]
        {
            new[] {1, 2, 3, 4, 5},
            new[] {16, 17, 18, 19, 6},
            new[] {15, 24, 25, 20, 7},
            new[] {14, 23, 22, 21, 8},
            new[] {13, 12, 11, 10, 9}
        };
        Assert.AreEqual(expected, new Solution().GenerateMatrix(5));
    }
    
    [Test]
    public void Test4()
    {
        var expected = new[]
        {
            new[] {1, 2, 3, 4, 5, 6},
            new[] {20, 21, 22, 23, 24, 7},
            new[] {19, 32, 33, 34, 25, 8},
            new[] {18, 31, 36, 35, 26, 9},
            new[] {17, 30, 29, 28, 27, 10},
            new[] {16, 15, 14, 13, 12, 11}
        };
        Assert.AreEqual(expected, new Solution().GenerateMatrix(6));
    }
}