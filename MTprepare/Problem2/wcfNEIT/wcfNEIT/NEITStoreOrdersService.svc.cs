using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcfNEIT
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class NEITStoreOrdersService : INEITStoreOrdersService
    {
        public Order GetOrder(int orderID)
        {
            // Create top order
            Order myOrder = new Order();
            // Create array of items
            Item[] myItem = new Item[2];
            // Create item
            Item myNewItem1 = new Item();
            Item myNewItem2 = new Item();
            // Create Customer options for each item
            CustomerOptions myCustOptions1 = new CustomerOptions();
            CustomerOptions myCustOptions2 = new CustomerOptions();

            myOrder.orderId = "1";
            myOrder.shopperAddress = "101 Main Street";
            myOrder.shopperName = "Sam Spade";

            myNewItem1.cost = "7.00";
            myNewItem1.name = "T-Shirt";
            myNewItem1.sku = "T001";
            // add first item to array
            myItem[0] = myNewItem1;

            // add customer options to array if any
            myCustOptions1.color = "Green";
            myCustOptions1.size = "S";
            myItem[0].Options = myCustOptions1;

            ///////////////////////////////////////

            myNewItem2.cost = "17.00";
            myNewItem2.name = "Pants";
            myNewItem2.sku = "P002";
            // add second item to array
            myItem[1] = myNewItem2;

            // add customer options to array if any
            myCustOptions2.color = "Green";
            myCustOptions2.size = "L";
            myItem[1].Options = myCustOptions2;

            // add array of items to Order items 
            myOrder.items = myItem;

            return myOrder;
        }

        public int ReturnDoubleOrderID(int orderID)
        {
            return orderID * 2;
        }
    }
}
