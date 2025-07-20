public class Solution {
    public int LongestConsecutive(int[] nums) {
          var hashSet = new HashSet<int>(nums);
   int max = 0;

   foreach(var num in hashSet)
   {
       if (!hashSet.Contains(num - 1))
       {
           int currentNum = num;
           while(hashSet.Contains(currentNum + 1))
           {
               currentNum++;
           }
           max = Math.Max(currentNum-num + 1,max);
       }
   }    

   return max;
    }
}