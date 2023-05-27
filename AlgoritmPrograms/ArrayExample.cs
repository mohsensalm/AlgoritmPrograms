using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    public class ArrayExample
    {

        public void BookExampArray()
        {
            Console.WriteLine("inter array length");
            var n = Convert.ToInt32(Console.ReadLine());
            int [] arr = new int[n + 1];
            var b = 1;
            var c = 11;
            for (int i = 1 ; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    if (b <= 10)
                    {
                        arr[i] = b;
                        Console.WriteLine(arr[i]);
                        b++;
                    }
                }
                else
                {
                    if (c<=20)
                    {
                        arr[i] = c;
                        Console.WriteLine(arr[i]);
                        c++;    
                    }
                }
            }
        }

    }
}
