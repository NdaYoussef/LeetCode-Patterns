namespace ConsoleApp4
{
    internal class Program
    {
        public static int NumIdenticalPairs(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i < j)
                        counter++;
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3, 1, 1, 3];

            var result = NumIdenticalPairs(arr);
            Console.WriteLine(result);
        }
    }
}
