namespace ValidParentheses;

public class Solution {
    public bool IsValid(string s)
    {
        var opens = new[] {'(', '[', '{'};
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (opens.Contains(c))
            {
                stack.Push(c);
            }
            else
            {
                if (!stack.TryPop(out var popped))
                {
                    return false;
                }
                
                switch (popped)
                {
                    case '(' when c != ')':
                    case '[' when c != ']':
                    case '{' when c != '}':
                        return false;
                }
            }
        }

        return stack.Count == 0;
    }
}