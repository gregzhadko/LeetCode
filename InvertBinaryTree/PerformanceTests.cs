using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace InvertBinaryTree;

[MemoryDiagnoser]
public class PerformanceTests
{
    private readonly TreeNode _root = new(4, new(2, new(1), new(3)), new(7, new(6), new(9)));
    private readonly Solution _solution = new();

    [Benchmark]
    public void Sivykh()
    {
        _solution.InvertTreeSivykh(_root);
    }
    
    [Benchmark]
    public void Greg()
    {
        _solution.InvertTreeGreg(_root);
    }
    
    [Benchmark]
    public void LeetCode()
    {
        _solution.InvertTreeLeetCode(_root);
    }
}