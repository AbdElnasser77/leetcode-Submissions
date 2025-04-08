public class Solution {
    public int[] MinOperations(string boxes) {
  int n = boxes.Length;
int[] answer = new int[n];

for(int i = 0; i < n; i++)
{
    int sum = 0;
    for(int j = 0; j < n; j++)
    {
            if(boxes[j] == '1')
            {
                sum += Math.Abs(j-i);
            }
    }
    answer[i] = sum;
}


return answer;
    }
}