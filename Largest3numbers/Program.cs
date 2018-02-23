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
            int[] arr = new int[10];
            Random r = new Random();
            for (int i = 0; i < arr.Count(); i++)
            {
                arr[i] = r.Next(-10, 10);
                Console.Write(arr[i] + " ");

            }

            var arrList = arr.OrderByDescending(t => t).Take(3).ToList();
            foreach (int i in arr)
                Console.WriteLine(i);

            //for (int i = 0; i < 3; i++)
            //    Console.Write(arrList[i] + " ");


            Console.ReadKey();
        }
    }
}
