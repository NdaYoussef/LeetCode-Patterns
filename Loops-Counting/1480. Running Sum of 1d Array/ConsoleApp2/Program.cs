namespace ConsoleApp2
{
    internal class Program
    {
        public static int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }
            return nums;
        }
        static void Main(string[] args)
        {
            int[] arr = [1, 1, 1, 1, 1];

            var result = RunningSum(arr);
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
