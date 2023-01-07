public class Solution {
    public int Reverse(int x)
    {
        var originalString = x.ToString();
        var prefix = "";
        if (x < 0)
        {
            prefix = "-";
            originalString = originalString.Substring(1, originalString.Length - 1);
        }
        var str = prefix + new string(originalString.Reverse().ToArray());
        return int.TryParse(str, out var result) ? result : 0;
    }
}