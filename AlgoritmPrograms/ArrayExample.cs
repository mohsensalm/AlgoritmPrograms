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
            int[] arr = new int[n + 1];
            var b = 1;
            var c = 11;
            for (int i = 1; i <= n; i++)
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
                    if (c <= 20)
                    {
                        arr[i] = c;
                        Console.WriteLine(arr[i]);
                        c++;
                    }
                }
            }
        }

        public void Tekrari()
        {
            Console.WriteLine("Inter Size Of Array");
            var n = Convert.ToInt32(Console.ReadLine());
            var array = new int[n];

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("inter value of indexes");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (var j = 0; j < n; j++)
            {
                var t = j + 1;
                var k = 0;
                while (t < n)
                {
                    if (array[j] == array[t])
                    {
                        t++;
                        k++;


                    }
                    else
                    {
                        t++;
                    }

                }

                Console.WriteLine("at position:" + j + " we have" + k + " similar numbers");

            }


        }

    }
}
