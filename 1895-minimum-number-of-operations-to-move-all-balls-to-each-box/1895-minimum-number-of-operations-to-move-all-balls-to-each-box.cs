public class Solution {
    public int[] MinOperations(string boxes) {
  int n = boxes.Length;
int[] answer = new int[n];

 int steps = 0,count = 0;
 for(int i = 0; i < n; i++)
 {
     answer[i] += steps;
     if (boxes[i] == '1') count++;
     steps += count;
 }

 steps = 0;
 count = 0;
 for(int i = n-1;i >= 0; i--)
 {
     answer[i] += steps;
     if(boxes[i] == '1') count++; 
     steps += count;
 }

 return answer;
}
}