using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int_50_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];

            Random rnd = new Random();
            for (int i = 0; i < arr.Count(); i++)
            {
                arr[i] = rnd.Next(-10, 100);
                Console.Write(arr[i] + " ");

            }
            IEnumerable<int> arrList = arr.OrderBy(i => i);
            foreach (int i in arrList)
            {
                Console.WriteLine(i + " ");
            }
            int number = (from t in arrList where (t == 50) select t).Count();
            Console.WriteLine("This List has  " + number + " number 50");
            Console.ReadKey();

        }
    }
}