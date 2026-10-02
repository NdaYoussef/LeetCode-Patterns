public class Solution {
    public void MoveZeroes(int[] nums) {
            int idx = -1;
        for(int i= 0 ; i< nums.Length; i++)
        {
            if(nums[i] == 0 && idx == -1 )
            {
                idx = i ; 
            }
            if(nums[i] != 0 && idx != -1 )
            {
                int current = nums[i]; 
                nums[idx] = current; 
                nums[i] = 0 ; 
                idx++;
            }

        }
    }
}