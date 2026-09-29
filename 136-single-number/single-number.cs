public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int,int> counts = new();

        foreach(int num in nums)
        {
            if(counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }

       foreach(var item in counts)
        {
            if(item.Value == 1)
            {
                return item.Key;
            }
        }
        return 0 ;
    }
}