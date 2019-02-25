using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int nums = rnd.Next(100, 999);
            Console.WriteLine("*********** Random Numbers ********** ");
            for (int i = 0; i < 100; i++)
            {
                nums = rnd.Next(100, 999);
                Console.Write("{0} ", nums);
            }
            Console.ReadLine();
        }
    }
}
