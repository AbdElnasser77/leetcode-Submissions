public class Solution {
    public int[] MinOperations(string boxes) {
         int[] answer = new int[boxes.Length];

 for(int i = 0; i < boxes.Length ; i++)
 {
     int sum = 0;
     for(int j = 0; j < boxes.Length; j++)
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