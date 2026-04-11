namespace ConsoleApp1
{
    internal class Program
    {
        /// <summary>
        /// 1234
        /// 1 2 3 4 
        /// </summary>
     
        static void Main(string[] args)
        {
            int[] nums = { 124, 4578, 1125786, 9, 11, 1 };
            int counter = 0;
            foreach(int num in nums)
            {
                int n = num;
                int digits = 0; 

                if(n == 0)
                    digits =1;

                while(n!= 0)
                {
                    n /= 10;
                    digits++;
                }
                if (digits % 2 == 0)
                    counter++;
            }
            Console.WriteLine(counter);
        }
    }
}

