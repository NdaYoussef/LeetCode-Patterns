namespace _643._Maximum_Average_Subarray_I
{
    internal class Program
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            int sum = 0;
            for(int i =0;i<k;i++)
            {
                sum+= nums[i];
            }

            int maxSum = sum; 
            for(int i = k; i<nums.Length;i++)
            {
                sum += nums[i];
                sum-= nums[i-k];
                if(sum > maxSum)
                    maxSum = sum;
            }
            return (double)maxSum / k;
        }

            static void Main(string[] args)
        {
            int[] nums = [1, 12, -5, -6, 50, 3];
            int k = 4;
           double result = FindMaxAverage(nums, k);
            Console.WriteLine($"result: {result}");
        }
    }
}
