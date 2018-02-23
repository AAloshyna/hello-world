using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTask_Count_Real_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> array = new List<double>() { 1, 1.2, 5, 5, 2.3, 1 };
            array.Sort();

            foreach (double val in array.Distinct())
            {
                Console.WriteLine(val + " - " + array.Where(x => x == val).Count() + " times");
            }
            Console.ReadKey();
        }
    }
}
