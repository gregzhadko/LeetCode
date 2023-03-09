using NUnit.Framework;

namespace NaryTreeLevelOrderTraversal;

public class Tests
{
    [Test]
    public void Test1()
    {
        var root = new Node(1, new List<Node>
        {
            new(3, new List<Node>
            {
                new(5),
                new(6)
            }),
            new(2),
            new(4)
        });
        var expected = new List<IList<int>>
        {
            new List<int> { 1 },
            new List<int> { 3, 2, 4 },
            new List<int> { 5, 6 }
        };
        Assert.AreEqual(expected, new Solution().LevelOrder(root));
    }
}