using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class CoinCalculator
    {
        public int CalculateMinCoins(int amount)
        {
            int totalCoins = 0;
            int[] array = { 1, 2, 5, 10, 20, 50, 100, 200 };
            Array.Reverse(array);

            for (int i = 0; i < array.Length; i++)
            {
                while (amount >= array[i])
                {
                    amount -= array[i];
                    totalCoins++;
                }
            }
            return totalCoins;
        }
    }
}