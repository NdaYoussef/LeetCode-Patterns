namespace _1652._Defuse_the_Bomb
{
    internal class Program
    {
            public static int[] Decrypt(int[] code, int k)
            {
                int sum = 0;
                for (int i = 0; i < k; i++)
                {
                    if (k > 0)
                    {
                        sum += code[i + 1];
                        code[i] = sum;
                    }
                    else if (k < 0)
                    {
                        sum += code[i - 1];
                        code[i] = sum;
                    }
                    else
                    {
                        code[i] = 0;
                    }
                }
                return code;
            }
        static void Main(string[] args)
        {
            int[] code = [5, 7, 1, 4];
            int k = 3;
            Console.WriteLine(Decrypt(code,k));
        }
    }
}
