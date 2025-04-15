public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int,int>();

        foreach(int n in nums){
            if(freq.ContainsKey(n)){
                freq[n]++;
            }else{
                freq[n]=1;
            }
        }

        var res = freq.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();

        return res;
    }
}