using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoiceExercise
{
    public class Invoice
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }

        public Item Item { get; set; }

        public int Amount { get; set; }

        public Invoice(int id, Customer customer, Item item, int amount = 1)
        {
            Id = id;
            Customer = customer;
            Item = item;
            Amount = amount <= 0 ? 1 : amount;
        }

        public override string ToString()
        {
            //return $"Invoice id: {Id}\nCustomer: {Customer.Name}\nItem: {Item.Name}\nAmount: {Amount}";
            return $"{Customer.Name} has purchased {Item.Name} using their {Customer.Discount}% discount {Amount} time(s)!";
        }
    }
}
