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

            Console.Write("\nSorted by PartDescription: ");
            var sorPD = list.OrderBy(q => q.PartDescription).ToList();

            foreach (var o in sorPD)
            {
                Console.Write(o.PartDescription + "  ");
            }
   
            Console.Write("\nSorted by Price: ");

            var sorP = list.OrderBy(q => q.Price).ToList();
            foreach (var o in sorP)
            {
                Console.Write(o.Price + "  ");
            }

            Console.WriteLine("\nSelecting by PartDescription and Quantity and sort by Quantity: ");

            var pDP = list.Select(q => new { PartDescription = q.PartDescription, Quantity = q.Quantity }).OrderBy(t => t.Quantity).ToList();

            foreach (var o in pDP)
            {
                Console.WriteLine("PartDescription:" + " " + o.PartDescription + " " + "Quantity:" + " " + o.Quantity + " ");
            }

            Console.WriteLine("\nSelecting by PartDescription and InvoiceTotal: ");
            var invTotal = list.Select(q => new { PartDescription = q.PartDescription, invTotal = q.Quantity * q.Price }).ToList();
            foreach (var o in invTotal)
            {
                Console.WriteLine("PartDescription:" + " " + o.PartDescription + " " + "invTotal:" + " " + o.invTotal + " ");
            }

            Console.WriteLine("\nInvoiceTotal in the range 5-33: ");

            var invTotalInRange = from t in invTotal 
                                  where t.invTotal > 5 && t.invTotal <30
                                  //orderby t
                                  select t;

            foreach (var s in invTotalInRange)
            {
                Console.WriteLine("invTotal: " + " " + s.invTotal);
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
