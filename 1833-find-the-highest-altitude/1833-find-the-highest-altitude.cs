public class Solution {
    public int LargestAltitude(int[] gain) {
        int n = gain.Length;
        int[] prefix = new int[n];
        prefix = gain;
        int max = 0;

          
    for (int i = 0; i < n; i++)
    {
        if (i == 0)
            max = int.Max(prefix[i],max);
        else
        {
            prefix[i] += prefix[i-1];
            max = int.Max(prefix[i], max);
        }
    }

    return max;

        return max;
    
    }
}