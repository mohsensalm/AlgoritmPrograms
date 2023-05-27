using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    public class Seke
    {
        //private int r;
        //private int k;
        //private int p;

        //public string Coins(int n)
        //{
        //    for (int r = 1; r * 20 < n; r++)
        //    {
        //        if (r * 20 % n == 0)
        //            return r.ToString();
        //        for (int k = 1; k * 10 < n; k++)
        //        {
        //            if (k * 10 % n == 0)
        //                return k.ToString();
        //            for (int p = 1; p * 5 < n; p++)
        //            {
        //                if (p * 5 % n == 0)
        //                {
        //                    return p.ToString();
        //                }
        //            }

        //        }
        //    }

        //    var s = "you have rCoin:" + r + "and kCoin:" + k + "and PCoin:" + p;
        //    return s;
        //}


        //int resualt = 0, counter = 0, five, ten, twenty;
        //    for (twenty = 1; twenty< 2; twenty++)
        //{
        //    for (ten = 1; ten< 3; ten++)
        //    {
        //        for (five = 1; five< 5; five++)
        //        {
        //            resualt = (twenty* 20) + (ten* 10) + (five* 5);
        //            if (resualt == 50)
        //            {
        //                Console.WriteLine("twenty:" + twenty + "" + "ten:" + ten + "" + "five:" + five);
        //                counter++;
        //                break;
        //            }
        //        }


        //    }
        //}

        //Console.WriteLine(counter);

        public void DynamicCoin()
        {
            Console.WriteLine("inter ur amount");
            int total = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inter ur coins value");
            var n = Convert.ToInt32(Console.ReadLine());
            int sum = total;
            List<int> coinsList = new List<int>();
            List<int> coins = new List<int>();
            coins.Add(n);
            for (int i = 0; i < coins.Count; i++)
            {
                var Numbers = total / coins[i];
                coinsList.Add(Numbers);         // ba estefade az a mitonim tedad seke va hamon meghdar da har marhalaro ro neshon bedim.
                total -= Numbers * coins[i];
                if (total == 0)
                {
                   

                    break;
                }
                foreach (var s in coinsList)
                {
                    Console.WriteLine("amount of coins i:" + coins[i] + " " + coinsList[i]);
                }

                Console.WriteLine("inter ur coins value");
                n = Convert.ToInt32(Console.ReadLine());
                coins.Add(n);

            }

        }
    }
}

