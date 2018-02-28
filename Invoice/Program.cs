using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<Invoice>()
            {
                new Invoice { PartNumber = 1, PartDescription = "part7", Quantity = 5, Price = 10.5m },
                new Invoice { PartNumber = 2, PartDescription = "part2", Quantity = 2, Price = 12.5m },
                new Invoice { PartNumber = 3, PartDescription = "part5", Quantity = 3, Price = 20.5m },
                new Invoice { PartNumber = 4, PartDescription = "part4", Quantity = 4, Price = 2.5m }
            };
            Console.WriteLine("Collection: ");
            foreach (var o in list)
            {
                Console.WriteLine("PartNumber:" + " " + o.PartNumber + " " + "PartDescription:" + " " + o.PartDescription + " " + "Quantity:" + " " + o.Quantity + " " + "Price:" + " " + o.Price);
            }

            Console.WriteLine(    );
            Console.Write("Sorted by PartDescription: ");
            var sorPD = list.OrderBy(q => q.PartDescription).ToList();

            foreach (var o in sorPD)
            {
                Console.Write(o.PartDescription + "  ");
            }

            Console.WriteLine(      );
            Console.Write("Sorted by Price: ");

            var sorP = list.OrderBy(q => q.Price).ToList();
            foreach (var o in sorP)
            {
                Console.Write(o.Price + "  ");
            }

            Console.WriteLine(     );
            Console.WriteLine("Selecting by PartDescription and Quantity and sort by Quantity: ");

            var pDP = list.Select(q => new { PartDescription = q.PartDescription, Quantity = q.Quantity }).OrderBy(t => t.Quantity).ToList();

            foreach (var o in pDP)
            {
                Console.WriteLine("PartDescription:" + " " + o.PartDescription + " " + "Quantity:" + " " + o.Quantity + " ");
            }

            Console.ReadKey();
        }
        class Invoice
        {
            public int PartNumber { get; set; }
            public string PartDescription { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }

        }
    }
}
