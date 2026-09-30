public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        int n = nums.Length; 
        Dictionary<int,int> dic = new  Dictionary<int,int>(); 
        foreach(var num in nums)
        {
            if(dic.ContainsKey(num))
            {
                dic[num]++;
            }
            else 
            dic[num] = 1 ; 
        }

        var result = new List<int>(); 
        for(int i = 1 ; i<= n; i++)
        {
            if(!dic.ContainsKey(i))
            {
                result.Add(i);
            }
        }

    return result;
    }
}