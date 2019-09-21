using System.Linq;

namespace LeetCodeProblems
{
    public static class Problems4
    {
        public static bool CheckPerfectNumber(int num)
        {
            if (num <= 0)
                return false;

            var divisorSum = 0;
            
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    divisorSum += i;
            }
            bool isPerfect = divisorSum == num;
            
            return isPerfect;
        }
        public static int AddDigits(int num)
        {
            var digits = num.ToString().Select(t => int.Parse(t.ToString())).ToArray();

            if (digits.Length == 1)
                return num;
            
            var sum = digits.Sum();

            while(sum.ToString().Length > 1)
            {
                digits = sum.ToString().Select(t => int.Parse(t.ToString())).ToArray();
                sum = digits.Sum();
            }
            return sum;
        }
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                var buyingPrice = prices[i];

                for (int j = i + 1; j < prices.Length; j++)
                {
                    var sellingPrice = prices[j];
                    var profit = sellingPrice - buyingPrice;

                    if (profit > maxProfit)
                        maxProfit = profit;
                }
            }
            return maxProfit;
        }
        public static int MaxProfit2(int[] prices)
        {           
            var minprice = int.MaxValue;
            var maxprofit = 0;
            for (int i = 0; i < prices.Length; i++) {
                if (prices[i] < minprice)
                    minprice = prices[i];
                else if (prices[i] - minprice > maxprofit)
                    maxprofit = prices[i] - minprice;
            
            }
            return maxprofit;
        }
    }
}
