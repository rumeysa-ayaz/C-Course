using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class CartManager
    {
        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + product.Name);
        }

        public void Add2(string productName, string description, double price)
        {

        }
    }
}
