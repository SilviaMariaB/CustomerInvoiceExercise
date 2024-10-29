using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoiceExercise
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }

        public Customer(int id, string name, double discount)
        {
            Id = id;
            Name = name;
            Discount = discount < 0 || discount > 100 ? 0 : discount;
        }
        public override string ToString()
        {
            return $"Customer id: {Id}\nName: {Name}\nDiscount: {Discount}%";
        }
    }
}
