

// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

namespace DSA.leetcode
{
    public class BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices) {
            int buy = 0, max = 0;
            for(int now=0;now<prices.Length;now++)
            {
                if(prices[now] < prices[buy])
                {
                    now=buy;
                }
                max = Math.Max(max, prices[now] - prices[buy]);
            }
            return max;
        }
    }
}