public class Solution {
    public int EvalRPN(string[] tokens) {
            
              var proccess = new Stack<int>();
  
  foreach(var num in tokens)
  {
      if (num == "+" || num == "*" || num == "-" || num == "/")
      {
          int num1 = proccess.Pop();
          int num2 = proccess.Pop();
          int result = num switch
          {
              "+" => num1 + num2,
              "-" => num2 - num1,
              "*" => num1 * num2,
              "/" => num2 / num1,
              _ => throw new InvalidOperationException("Invalid operator")
          };
          proccess.Push(result);
      }
      else
      {
          proccess.Push(int.Parse(num));
      }
  }

            return proccess.Pop();
    }
}