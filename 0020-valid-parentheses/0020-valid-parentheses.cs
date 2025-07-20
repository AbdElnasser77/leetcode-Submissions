public class Solution {
    public bool IsValid(string s) {
        
          Stack<char> openBracket = new Stack<char>(s);
  Stack<char> closeBracket = new Stack<char>();

  while (openBracket.Count != 0)
  {
      char bracket = openBracket.Peek();

      if (bracket == ')' || bracket == ']' || bracket == '}')
      {
          closeBracket.Push(bracket);
          openBracket.Pop();
      }
      else
      {
          if (closeBracket.Count == 0)
          {
              return false;
          }
          if (bracket == '(' && closeBracket.Peek() == ')'
              || bracket == '{' && closeBracket.Peek() == '}'
              || bracket == '[' && closeBracket.Peek() == ']')
          {
              openBracket.Pop();
              closeBracket.Pop();
          }
          else
          {
              return false;
          }
      }
  }


         
  if (openBracket.Count == 0 && closeBracket.Count == 0)
  {
      return true;
  }
  else
  {
    return false;
  }


    }
}