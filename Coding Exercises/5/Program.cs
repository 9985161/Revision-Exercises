using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            {

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} x {1} = {2}", a, i, a * i);
                }
                Console.ReadLine();
            }
        }
    }
}
