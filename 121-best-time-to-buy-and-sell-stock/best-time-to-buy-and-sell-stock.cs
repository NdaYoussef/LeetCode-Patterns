public class Solution {
    public int MaxProfit(int[] prices) {
      int minPrice = prices[0];
      int MaxProfit = 0 ; 
      foreach(var price in prices)
      {
        if(price < minPrice )
        {
            minPrice = price;
        }
        else 
        {
            int profit = price - minPrice;
            if(profit > MaxProfit)
            MaxProfit = profit;
        }
      }
        return MaxProfit;
    }
}
