public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        List<int> leftSum = new List<int>(nums);
        List<int> rightSum = new List<int>(nums);

        for(int i = 0; i < nums.Length; i++)
        {
            if (i == 0) leftSum[i] = 0;
            else leftSum[i] = leftSum[i-1] + nums[i-1];
        }
        for(int i = nums.Length - 1 ; i>=0 ;i--)
        {
            if (i == nums.Length - 1) rightSum[i] = 0;
            else rightSum[i] = rightSum[i+1] + nums[i+1];
        }
        int[] answer = new int[nums.Length];
        for(int i = 0 ; i < nums.Length ; i++)
        {
            answer[i] = Math.Abs(leftSum[i] - rightSum[i]);
        }
        return answer;
        
    }
}