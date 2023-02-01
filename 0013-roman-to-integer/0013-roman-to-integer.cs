public class Solution {
    public int RomanToInt(string s) {
        string romanString = s;
        romanString = PrependTilde(romanString);
        var reverseRomanChars = romanString.Reverse();
        uint num = 0;
        var romanStack = new Stack<char>();

        Boolean tag = false;
        foreach (var roman in reverseRomanChars) 
        {
            tag = false;
            while(!(romanStack.Count == 0) && PrecedenceOf(roman) < PrecedenceOf(romanStack.Peek()))
            {
                uint b = _romanToInt.GetValueOrDefault(romanStack.Pop());
                uint a = _romanToInt.GetValueOrDefault(roman);
                num += (b - a);
                tag = true;
            }
            if (tag) continue;
            romanStack.Push(roman);
        }
        return (int)num;
    }
    
    private static readonly Dictionary<char, uint> _romanToInt = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 },
        { '~', 0 }
    };
    
    private static uint PrecedenceOf(char roman)
    {
        return _romanToInt.GetValueOrDefault(roman);
    }

    private static string PrependTilde(string romanString)
    {
        return "~" + romanString;
    }
}