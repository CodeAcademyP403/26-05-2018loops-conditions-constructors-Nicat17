using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleSection;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop(3);

            for (int i = 0; i < 3; i++)
            {
                shop.AddArray[i] = new Product();
                shop.AddArray[i].Catagory = new Catagory();


                shop.AddArray[i].Name = Console.ReadLine();

            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(shop.AddArray[i].Name);
            }

            Console.ReadKey();
        }
    }
}
