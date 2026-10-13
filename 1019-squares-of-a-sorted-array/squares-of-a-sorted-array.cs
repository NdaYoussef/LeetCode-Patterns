public class Solution {
    public int[] SortedSquares(int[] nums) {
        int left = 0 ; 
        int right = nums.Length - 1 ; 
        int[] result = new int[nums.Length]; 
        int index = result.Length -1 ; 

        while(left <= right)
        {
         if(nums[left] * nums[left] > nums[right] * nums[right])
         {
            result[index] = nums[left] * nums[left];
            left++; 
            index--;
         }    
         else 
         {
             result[index] = nums[right] * nums[right]; 
             right --; 
             index--;
         }
        }
        return result;
    }
}