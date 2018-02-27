using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<int> arr = new List<int>();
            Random r = new Random();
            //int[] arr = new int[10];

            for (int i = 0; i < 20; i++)
            {
                arr.Add(r.Next(0, 10));
                //arr[i] = r.Next(0, 10);
                Console.Write("{0} ", arr[i]);
                //Console.Write(arr[i] + " ");

            }

            var biggerThree = arr.OrderByDescending(t => t).Take(3).ToList();
            Console.WriteLine("\nLargest 3 numbers");
            foreach (var i in biggerThree)
                Console.WriteLine(i);
                Console.ReadKey();
        }
    }
}
