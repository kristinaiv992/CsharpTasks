using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.AddOrderLine("apples", 1, 65.3);
            order.AddOrderLine("grapes", 8, 92.3);
            Console.WriteLine( "You have to pay " + order.Orders() + "denars");
            
        }
    }
}
