using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Min_Max_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            arr.ToList();
            Random r = new Random();
            for (int i = 0; i < arr.Count(); i++)
            {
                arr[i] = r.Next(-10, 10);
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine("\nsum= " + arr.Sum());
            Console.WriteLine("max= " + arr.Max());
            Console.WriteLine("min= " + arr.Min());
            Console.WriteLine("avg= " + arr.Average());
            Console.ReadKey();
        }
    }
}