namespace NaryTreeLevelOrderTraversal;

public class Solution
{
    public IList<IList<int>> LevelOrder(Node? root)
    {
        var result = new List<IList<int>>();
        if (root == null)
        {
            return result;
        }

        var queue = new Queue<(Node, int)>();
        queue.Enqueue((root, 0));
        while (queue.Count > 0)
        {
            var (node, level) = queue.Dequeue();
            if (result.Count == level)
            {
                result.Add(new List<int>());
            }

            result[level].Add(node.val);
            if (node.children == null)
            {
                continue;
            }

            foreach (var nodeChild in node.children)
            {
                queue.Enqueue((nodeChild, level + 1));
            }
        }

        return result;
    }
}