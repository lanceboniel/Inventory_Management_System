using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product { ProductId = 1, Name = "Laptop", Price = 1000m };
            var product2 = new Product { ProductId = 2, Name = "Mouse", Price = 20m };
            var product3 = new Product { ProductId = 3, Name = "Keyboard", Price = 50m };

            var orderItem1 = new OrderItem { Product = product1, Quantity = 4 };
            var orderItem2 = new OrderItem { Product = product2, Quantity = 10 };
            var orderItem3 = new OrderItem { Product = product3, Quantity = 15 };

            var order = new Order { OrderId = 101 };
            order.AddOrderItem(orderItem1);
            order.AddOrderItem(orderItem2);
            order.AddOrderItem(orderItem3);

            order.DisplayOrderDetails();

            decimal finalTotal = order.ApplyDiscount();
            Console.WriteLine($"Final Total After Discount: {finalTotal:C}");
        }
    }
}
