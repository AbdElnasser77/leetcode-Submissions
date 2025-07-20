public class Solution {
    public int LongestConsecutive(int[] nums) {
        Array.Sort(nums);

        int counter = 0;
        int maxCount = 0;
        for (int i = 1 ; i < nums.Length ; i++)
        {
            if (nums[i - 1] == nums[i] - 1) counter++;
            else if(nums[i - 1] == nums[i]) continue;
            else
            {
                if (maxCount < counter) maxCount = counter;
                counter = 0;
            }
        }
        if( nums.Length == 0) return 0;
        else if (nums.Length == 1) return 1;
        else if(counter>maxCount) return counter+1;
        else
        return maxCount+1;
    }
}