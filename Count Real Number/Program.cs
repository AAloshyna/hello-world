using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var part = Console.ReadLine().ToLower().Split('.', ',', ':', ';', '(', ')', '[', ']', '“', '‘', '\\', '/', '!', '?', ' ').Distinct().Where(i => i.Length < 5);
            IEnumerable<string> word = from p in part orderby p select p;
            foreach (string i in word)
            {

                Console.WriteLine(i + ", ");
            }
            Console.ReadKey();
        }
    }
}

