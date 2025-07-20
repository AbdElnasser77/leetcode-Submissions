public class MinStack {

   List<(int,int)> _stack;
  public MinStack()
  {
      _stack = new List<(int, int)>();
  }

  public void Push(int val)
  {

      if (_stack.Count == 0)
          _stack.Add((val, val));
      else
          _stack.Add((val, Math.Min(val, GetMin())));
  }

  public void Pop()
  {
      _stack.RemoveAt(_stack.Count - 1);
  }

  public int Top()
  {
      return _stack.Last().Item1;
  }

  public int GetMin()
  {
      return _stack.Last().Item2;
  }
}

