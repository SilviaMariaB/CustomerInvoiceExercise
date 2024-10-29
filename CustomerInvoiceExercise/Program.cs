using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomerInvoiceExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Dode", 65.5);

            Item item = new Item(1, "Dog food");

            Invoice invoice = new Invoice(1, customer, item, 4);
            Console.WriteLine(invoice);

            Console.WriteLine();
            Customer customer2 = new Customer(2, "Silvia", 13);

            Item item2 = new Item(2, "Dog bath robe");

            Invoice invoice2 = new Invoice(1, customer2, item2);
            Console.WriteLine(invoice2);

            Console.ReadLine();
        }
    }
}
