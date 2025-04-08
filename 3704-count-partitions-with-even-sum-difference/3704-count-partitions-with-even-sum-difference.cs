public class Solution {
    public int CountPartitions(int[] nums) {
            int sum, leftSum, count;
    sum = leftSum = count = 0;

    nums.Sum(x => sum += x);

    for(int i  = 0; i < nums.Length-1; i++)
    {
        leftSum += nums[i];
        if((leftSum - (sum - leftSum)) % 2 == 0) count++;
    }
    return count;


    }
}