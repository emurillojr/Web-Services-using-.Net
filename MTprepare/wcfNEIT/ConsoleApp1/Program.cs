using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            NEITServiceReference.NEITStoreOrdersServiceClient myProxy = new NEITServiceReference.NEITStoreOrdersServiceClient();

            Console.WriteLine("----- Order Information ------");

            Console.WriteLine("Order ID: " + myProxy.GetOrder(1).orderId);
            Console.WriteLine("Shopper Name: " + myProxy.GetOrder(1).shopperName);
            Console.WriteLine("Shopper Address: " + myProxy.GetOrder(1).shopperAddress);

            Console.WriteLine("Items:");
            Console.WriteLine("Item 1");
            Console.WriteLine("\tCost: $" + myProxy.GetOrder(1).items[0].cost);
            Console.WriteLine("\tName: " + myProxy.GetOrder(1).items[0].name);
            Console.WriteLine("\tSKU: " + myProxy.GetOrder(1).items[0].sku);
            Console.WriteLine("Options");
            Console.WriteLine("\tColor: " + myProxy.GetOrder(1).items[0].Options.color);
            Console.WriteLine("\tSize: " + myProxy.GetOrder(1).items[0].Options.size);

            Console.WriteLine("Item 2");
            Console.WriteLine("\tCost: $" + myProxy.GetOrder(1).items[1].cost);
            Console.WriteLine("\tName: " + myProxy.GetOrder(1).items[1].name);
            Console.WriteLine("\tSKU: " + myProxy.GetOrder(1).items[1].sku);
            Console.WriteLine("Options");
            Console.WriteLine("\tColor: " + myProxy.GetOrder(1).items[1].Options.color);
            Console.WriteLine("\tSize: " + myProxy.GetOrder(1).items[1].Options.size);

            Console.WriteLine();
            Console.WriteLine("Hit ENTER to exit");
            Console.ReadLine();


        }
    }
}
