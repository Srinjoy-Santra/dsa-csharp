

// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

namespace DSA.leetcode
{
    public class BestTimeToBuyAndSellStock
    {
        public static int Solution(int[] prices) {
            int buy = 0, sell = 1, maxProfit = 0;
            while(sell < prices.Length)
            {
                if (prices[buy] < prices[sell])
                    maxProfit = Math.Max(maxProfit, prices[sell] - prices[buy]);
                else
                    buy = sell;
                sell++;
            }
            return maxProfit;
        }
    }
}