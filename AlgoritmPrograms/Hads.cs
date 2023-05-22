using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    public class Hads
    {
        int m = 1000;
        int n = 29;
        int s;

        public int GuessNumber()
        {
            if (m < n)
            {
                n = n / 2;
            }

            while (s == m)
            {
                if (m > n)
                {
                    s = (n / 2) + n;
                }
                if (s > n)
                {
                    s = (s / 2) + (n / 2);
                }
                if (s < m)
                {
                    n = s;
                }
            }
            if (m == n)
            {
                return m;
            }
            return m;

        }
        enum words
        {
            lowear,
            higher,
            bingo
        }
        //public int GetNumberBinary(int rangedown, int rangeup)
        //{
        //    int range;
        //    Console.WriteLine("guess number in ur mind and tell me each time it is higher or lowear");

        //    range = rangeup - rangedown;

        //    if ()


        //}
    }
}