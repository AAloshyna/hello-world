using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int k = random.Next(0, 100);
            
            Console.WriteLine("Enter the number from 0 to 100:");
            int n;
            int i = 0;
            do
            {
                
                bool IsInt = int.TryParse(Console.ReadLine(), out n);
                if (!IsInt)
                { Console.WriteLine("Please, provide a number!"); }

                
                if (n > k)
                    Console.WriteLine("You number is bigger, try again");

                if (n < k)
                    Console.WriteLine("You number is smaller, try again");

                i = i + 1;
                
            } while (n != k);


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yes! Correct number is: " + n);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Number of gessing is: {0}", i);
          

            Console.ReadKey();

        }
    }
}
