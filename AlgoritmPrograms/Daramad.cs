using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    public class Daramad
    {
        public void Tax()
        {
            Console.WriteLine("tedad afrad ra vared konid");
            int n = Convert.ToInt32(Console.ReadLine());
            int tax;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Inter a Person Income");
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
