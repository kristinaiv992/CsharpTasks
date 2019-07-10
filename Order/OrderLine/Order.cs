using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLine
{
    public class Order
    {
        private List<OrderLine> _orderLines = new List<OrderLine>();

        public void AddOrderLine(string product, int quantity, double price)
        {
            OrderLine orders = new OrderLine();
            orders.ProductName = product;
            orders.Quantity = quantity;
            orders.Price = price;
            _orderLines.Add(orders);
        }
        public double Orders()
        {
            double total = 0;
            foreach (var item in _orderLines)
            {
                total = total + item.OrderLineTotal();
                Console.WriteLine($"You have bought {item.ProductName}");
            }
            return total;
        }

        private class OrderLine
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }

            public double OrderLineTotal()
            {
                return Price * Quantity;
            }
        } 
    }
}
