using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    public class Daramad
    {
        int N = 2;
        public void Tax()
        {
            int tax;
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine("درامد را وارد کنید");
                int p = Convert.ToInt32(Console.ReadLine()); 
                if (p <= 5000)
                {
                    tax = 0;
                    Console.WriteLine(tax); 
                }
                if (p<=10000&&p>5000)
                {                    
                     tax =10*p/100;
                    Console.WriteLine(tax);
                }
                if (p > 10000)
                {
                     tax =15*p/100;
                    Console.WriteLine(tax);
                }
            }
        }

    }
}
