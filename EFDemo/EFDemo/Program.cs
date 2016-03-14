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

            /// demo part B
            /// 
            // fetching employees sorted by (or order by) City
            // printing only [FirstName] [LastName] [Title] [BirthDate] [City] 
            List<Employees> emp = mb.Employees.OrderBy(e => e.City).ToList();

            if (emp != null)
            {
                Console.WriteLine("\n\n\n\n Printing demo part B");
                foreach (Employees e in emp)
                {
                    Console.WriteLine(e.FirstName + "  " + e.LastName + "  " + e.Title);
                    Console.WriteLine("{0} {1} {2} {3} {4} ", e.FirstName, e.LastName, e.Title, e.BirthDate, e.City);
                }
            }
            Console.ReadKey();
        }
    }
}
