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
        //if (i<arr1.Length)
        //{
        //    i++;
        //}
        //else
        //{

        //}

        public void DifrenceBetweanTwoList()
        {
            int[] arr1 = new[] { 3, 2, 5, 6, 7, 8 ,11,13};
            int[] arr2 = new[] { 3, 3, 5, 5, 7, 8 ,7,9,11};
            List<int> arr3 = new List<int>();
            int s = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    while (j < arr2.Length)
                    {
                        if (arr1[i] == arr2[j])
                        {
                         
                            arr3.Add(arr2[j]);
                            arr1[i] = 0;
                            arr2[j] = 0;
                            j++;
                            s++;

                        }
                        else
                        {
                            j++;
                        }
                    }
                }
            }

            foreach (var num in arr3)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("there is "+s+" similar numbers ");
        }

    }
}
