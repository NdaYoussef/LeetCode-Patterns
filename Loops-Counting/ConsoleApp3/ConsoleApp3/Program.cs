namespace ConsoleApp3
{
    internal class Program
    {
        public static int MaxWealth(int[][] accounts)
        {
            int maxWealth = 0;
            for(int i =0; i< accounts.Length; i++)
            {
                int sum = 0;
                for(int j = 0; j< accounts[i].Length;j++)
                {
                    sum += accounts[i][j];
                }
                if(sum > maxWealth) 
                    maxWealth = sum;
            }
            return maxWealth;
        }
        static void Main(string[] args)
        {
            int[][] arr = [[2, 8, 7], [7, 1, 3], [1, 9, 5]];
            var result = MaxWealth(arr);
            Console.WriteLine(result);


        }
    }
}
