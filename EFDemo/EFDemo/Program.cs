using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Model creation
            ModelBooks mb = new ModelBooks();



            /// demo part A
            /// 
            //Fetching order from Orders by OrderID
            Orders order = mb.Orders.FirstOrDefault(or => or.OrderID == 10248);

            Console.WriteLine("\n\n\n\n Printing demo part A");

            if (order != null)
            {
                foreach (Order_Details od in order.Order_Details)
                {
                    Console.WriteLine(od.Products.ProductName);
                }
            }


            Console.ReadKey();
            
        }
    }
}
