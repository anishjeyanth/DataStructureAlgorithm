using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Greedy
{
    public class Item
    {
        public int Weight { get; set; }
        public int Value { get; set; }

        public Item(int weight, int value)
        {
            Weight = weight;
            Value = value;
        }   
    }

    public class Greedy
    {
        public static void CoinChangeProblem(int[] coin, int n)
        {
            System.Array.Sort(coin);
            int index = coin.Length - 1;
            while (true)
            {
                int coinValue = coin[index];
                index--;
                int maxAmount = (n / coinValue) * coinValue;
                if(maxAmount > 0)
                {
                    Console.WriteLine("Coin value: " + coinValue + " taken count: " + (n / coinValue));
                    n = n - maxAmount;
                }

                if(n==0)
                {
                    break;
                }
            }
        }


        public static void FractionalKnapsack(Item[] items, int Capacity)
        {
            System.Array.Sort(items, (x,y)=> (y.Value / (double)y.Weight).CompareTo(x.Value/ (double)x.Weight));

            double totalValue = 0;
            int remainingCapacity = Capacity;

            foreach(var item in items)
            {
                if (remainingCapacity <= 0)
                    break;

                if(item.Weight <= remainingCapacity)
                {
                    totalValue += item.Value;
                    remainingCapacity -= item.Weight;
                }
                else
                {
                    totalValue += (item.Value / (double)item.Weight) * remainingCapacity;
                    break;
                }
            }

            Console.WriteLine(totalValue);
        }

    }
}
