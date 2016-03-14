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

            // Fetching Categories ordered by CategoryName
            IList<Categories> categories = mb.Categories.OrderBy(o => o.CategoryName).ToList();

            foreach (Categories category in categories)
            {
                // Writing category to to the console
                Console.WriteLine(category.CategoryName);
            }

            //Fetching order from Orders by OrderID
            Orders order = mb.Orders.FirstOrDefault(or => or.OrderID == 10248);
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
