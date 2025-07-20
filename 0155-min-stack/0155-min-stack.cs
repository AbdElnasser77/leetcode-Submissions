public class MinStack {

    List<int> _stack;

 public MinStack()
 {
     _stack = new List<int>();
 }

 public void Push(int val)
 {
     _stack.Add(val);
 }

 public void Pop()
 {
     _stack.RemoveAt(_stack.Count - 1);
 }

 public int Top()
 {
     return _stack[_stack.Count - 1];
 }

 public int GetMin()
 {
     return _stack.Min();
 }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */