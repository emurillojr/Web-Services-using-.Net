using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.OrderService;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService.OrderManagerClient myProxy = new OrderService.OrderManagerClient();

            int orderID = 1;
            ConsoleApplication1.OrderService.BillingAddress names = myProxy.GetBillingAddressForAnOrder(orderID);

            Console.WriteLine("Billing Information for Order " + orderID);
            Console.WriteLine("Name = " + names.Name);
            Console.WriteLine("Address = " + names.Address);
            Console.WriteLine("City = " + names.City);
            Console.WriteLine("State = " + names.State);
            Console.WriteLine("ZipCode = " + names.ZipCode);

            double numbers = myProxy.GetNumberOfOrders();
            Console.WriteLine("Number of orders = " + numbers);

            double total = myProxy.GetTotalCostForAnOrder(orderID);
            Console.WriteLine("Total cost for order " + orderID + " = " + total);

            string partno = "JETSWEATER";
            double count = myProxy.HowManyOrderedForAPartNo(partno);
            Console.WriteLine("The number of orders with part '" + partno + "' = " + count);

            ConsoleApplication1.OrderService.Items[] items = myProxy.GetItemListForOrder(orderID);
            int number = items.Length;
            Console.WriteLine("Items in order " + orderID + " (Qty, PartNo, Description, Unit Price, Size, Color, Total Cost)");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(items[i].Quantity + ", " + items[i].PartNo + ", " + items[i].Description + ", " +
                                  items[i].Size + ", " + items[i].Color + ", " + items[i].TotalCost);
                //Console.WriteLine(items[i].PartNo);
                //Console.WriteLine(items[i].Description);
                //Console.WriteLine(items[i].UnitPrice);
                //Console.WriteLine(items[i].Size);
                //Console.WriteLine(items[i].Color);
                //Console.WriteLine(items[i].TotalCost);
            }

            Console.ReadLine();
        }
    }
}
