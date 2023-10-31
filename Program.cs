public class Solution {
        public bool IsValid(string s)
    {        
        Stack<char> stack = new Stack<char>();
        
        foreach (char c in s)
        {            
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
          
            else if (c == ')' || c == ']' || c == '}')
            {              
                if (stack.Count == 0 || stack.Pop() != GetMatchingParenthesis(c))
                {
                    return false;
                }
            }
        }      
        return stack.Count == 0;
    }
    
    private char GetMatchingParenthesis(char c)
    {
        switch (c)
        {
            case ')': return '(';
            case ']': return '[';
            case '}': return '{';
            default: return '\0';
        }
    }
}
