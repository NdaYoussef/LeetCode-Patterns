public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length; 
        int result = 0 ; 
        foreach(var num in nums)
        {
            result^= num;
        }

        for(int i = 0 ; i<=n; i++)
        {
            result^= i ;
        }
        return result;
    }
}