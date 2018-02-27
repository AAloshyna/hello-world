using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random list:");
            List<char> array = new List<char>();
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                array.Add(Convert.ToChar(rnd.Next('a', 'a' + 27)));
                Console.Write("{0} ", array[i]);
            }

            var ar = array.OrderBy(t => t).Distinct().ToList();
            Console.WriteLine("\nSorted list:");
            foreach (var t in ar)
                Console.WriteLine(t);
          
                
                Console.ReadKey();
            
        }
    }
}
