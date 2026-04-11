namespace ConsoleApp5
{
    internal class Program
    {
        public static int CountOdds(int low, int high)
        {
            int counter = 0;
            for (int i = low; i <= high; i++)
            {
                if (i % 2 != 0)
                    counter++;
            }
            return counter;
        }
        static void Main(string[] args)
        {
            int x = 3; 
            int y = 7;

            var result = CountOdds(x, y);
            Console.WriteLine(result);
        }
    }
}
