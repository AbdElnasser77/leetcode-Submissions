public class Solution {
    public int EvalRPN(string[] tokens) {
            
            var proccess = new Stack<string>();
            
            foreach(var num in tokens)
            {
                if (num == "+")
                {
                    string current = proccess.Pop();
                    current = (int.Parse(proccess.Pop()) + int.Parse(current)).ToString();
                    proccess.Push(current);
                }
                else if (num == "-")
                {
                    string current = proccess.Pop();
                    current = (int.Parse(proccess.Pop()) - int.Parse(current)).ToString();
                    proccess.Push(current);
                }
                else if(num == "*")
                {
                    string current = proccess.Pop();
                    current = (int.Parse(proccess.Pop()) * int.Parse(current)).ToString();
                    proccess.Push(current);
                }
                else if(num == "/")
                {
                    string current = proccess.Pop();
                    current = (int.Parse(proccess.Pop()) / int.Parse(current)).ToString();
                    proccess.Push(current);
                }
                else
                {
                    proccess.Push(num); 
                }


            }

            return Convert.ToInt32(proccess.Peek());
    }
}