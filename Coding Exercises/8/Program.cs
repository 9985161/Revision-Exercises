using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int nums = rnd.Next(1000, 9999);
            Console.WriteLine("*********** Random Numbers ********** ");
            for (int i = 0; i < 1000; i++)
            {
                nums = rnd.Next(1000, 9999);
                Console.Write("{0} ",nums);
            }
                Console.ReadLine();
        }
    }
}
