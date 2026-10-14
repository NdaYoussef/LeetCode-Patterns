public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
        if(original.Length == m*n)
        {
            int[][] arr = new int[m][]; 
            for(int i = 0 ; i < m ; i++)
            {
               arr[i] = new int[n];
                for(int j = 0 ; j < n; j++)
                {
                   arr[i][j] = original[i * n + j];
                }
            }
                return arr;
        }
        return new int[0][];
    }
}