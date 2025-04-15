public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
       
var freqMap = new Dictionary<int, int>();
foreach(int num in nums)
{
    if(freqMap.ContainsKey(num)) freqMap[num]++;
    else freqMap[num] = 1;
}

List<int>[] buckets = new List<int>[nums.Length + 1];
foreach(var pair in freqMap)
{
    int freq = pair.Value;
    if (buckets[freq] == null) buckets[freq] = new List<int>();

    buckets[freq].Add(pair.Key);
}

List<int> result = new List<int>(k);
for(int i = buckets.Length - 1; i > 0 && result.Count < k; i--)
{
    if(buckets[i] != null)
    {
        result.AddRange(buckets[i]);
    }
    
}

return result.ToArray();
    }
}