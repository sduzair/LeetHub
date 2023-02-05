public class Solution {
    private static readonly Dictionary<char, char> BracketPairs = new()
    {
        { '{', '}' },
        { '[', ']' },
        { '(', ')' },
        { '<', '>' },
    };
    
    public bool IsValid(string word) {
        var bracketStack = new Stack<char>();
        bool isValid = true;

        foreach (var letter in word) if(isValid)
        {
            if (IsOpeningBracket(letter))
                bracketStack.Push(letter);
            else if (IsClosingBracket(letter))
            {
                if (bracketStack.Count == 0) 
                {
                    isValid = false;
                        break;
                }
                isValid = IsBracketPair(bracketStack.Pop(), letter) ? true : false;
            }
            else 
                isValid = false;
        }
        
                if (bracketStack.Count > 0) isValid = false;


        return isValid;
    }
    
    private static bool IsBracketPair(char v, char letter)
    {
        if (BracketPairs[v] == letter) return true;
        else return false;
    }

    private static bool IsClosingBracket(char letter)
    {
        return BracketPairs.ContainsValue(letter);
    }

    private static bool IsOpeningBracket(char letter)
    {
        return BracketPairs.ContainsKey(letter);
    }
}