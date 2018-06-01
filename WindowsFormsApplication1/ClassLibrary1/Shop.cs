using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSection
{
    public class Shop
    {
        private Product[] products;

        public Shop(int i)
        {
            products = new Product[i];
        }

        public Product[] AddArray
        {
            get { return products; }
            set
            { 
                products = value;
            }
        }

       
        //public void AddProduct(Product pro)
        //{
        //    if (index<products.Length)
        //    {
        //        products[index] = pro;
        //        
        //    }
        //}
    }
}
