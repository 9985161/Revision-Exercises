using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, per, area;
            Console.Write("Please Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            per = 2 * Math.PI * radius;
            area = Math.PI * (radius * radius);

            Console.WriteLine("Perimeter = {0}", per);
            Console.WriteLine("Area = {0}",area);
            
            Console.ReadLine();
        }
    }
}
