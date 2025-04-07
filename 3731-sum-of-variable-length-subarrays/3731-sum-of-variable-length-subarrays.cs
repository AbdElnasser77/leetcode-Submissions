public class Solution {
    public int SubarraySum(int[] nums) {
          int total = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j =int.Max(0,i - nums[i]) ; j <= i; j++)
                {
                    total += nums[j];
                }
            }



            return total;
    }
}