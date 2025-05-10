using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class _123_Best_Time_to_Buy_and_Sell_Stock3
    {
        public int MaxProfit(int[] prices)
        {
            Dictionary<int, int> transaction = new Dictionary<int, int>();
            int transactionCount = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] <= prices[i - 1])
                    continue;
                transactionCount += 1;
                transaction[transactionCount] = prices[i] - prices[i - 1];

            }

            var sortedTransaction = transaction.OrderByDescending(kv => kv.Value);

            int profit = 0;
            int count = 0;
            foreach (var item in sortedTransaction)
            {
                profit += item.Value;
                count++;
                if (count == 2)
                    break;
            }
            return profit;
            List<int>tep = new List<int>();
            tep.OrderByDescending(x=>x);

        }
    }
}
