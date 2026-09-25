public class Solution {
    public int MajorityElement(int[] nums) {
        int Length = nums.Length;
        Dictionary<int,int> dic = new();

        foreach(int key in nums)
        {
            if(!dic.ContainsKey(key))
            {
                dic[key] = 1 ;
            }
            else 
            {
                dic[key]++;
            }
            if(dic[key] >Length/2)
            {
                return key;
            }
        }
        return -1;
    }
}