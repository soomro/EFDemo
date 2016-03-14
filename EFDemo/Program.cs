using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ---- TBD ---

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelBooks mb = new ModelBooks();
            IList<Categories> categories = mb.Categories.OrderBy(o => o.CatName).ToList();

            foreach(Categories category in categories)
            {
                Console.WriteLine(category.CatName);
            }

            //orders by find
            Orders order = mb.Orders.FirstOrDefault(or => or.OrderID == 10248);
            if (order != null)
            {
                foreach (Order_Details od in order.Order_Details)
                {
                    Console.WriteLine(od.Products.ProdName);
                }
            }
            


            Console.ReadKey();
            //mb.Categories.Add("hello");
        }
    }
}
