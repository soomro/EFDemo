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

            Console.ReadKey();
            //mb.Categories.Add("hello");
        }
    }
}
