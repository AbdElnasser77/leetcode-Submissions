public class Solution {
    public int LargestAltitude(int[] gain) {
        int n = gain.Length;
        int[] prefix = new int[n];
        prefix = gain;
        int max = 0;

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                if (prefix[i] > max) max = prefix[i];
            }
            else
            {
                prefix[i] += prefix[i-1];
                if (prefix[i] > max) max = prefix[i];
            }
        }

        return max;
    
    }
}