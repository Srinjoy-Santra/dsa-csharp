/*
---
problem: You are given an array prices where prices[i] is the price of a given stock on the ith day.
tags:
  - array
  - dynamic-programming
  - easy
  - leetcode
  - sliding-window
  - blind75
  - neetcode
link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
---
*/

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