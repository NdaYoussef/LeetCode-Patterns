public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
       int sum = 0 ; 

       for(int i =0 ;i<k;i++)
       {
         sum+=nums[i];
       }

       int maxSum = sum ; 
       for (int i = k; i < nums.Length; i++)
       {
        sum+=nums[i];
        sum-=nums[i-k];
        if (sum > maxSum)
            {
                maxSum = sum;
            }
       }
       
    
    return (double)maxSum/k;
}
}