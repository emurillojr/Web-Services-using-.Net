using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcfNEIT
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface INEITStoreOrdersService
    {
        [OperationContract]
        int ReturnDoubleOrderID(int orderID);

        [OperationContract]
        Order GetOrder(int orderID);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]

    public class Order
    {
        [DataMember]
        public string orderId;
        [DataMember]
        public string shopperAddress;
        [DataMember]
        public string shopperName;
        [DataMember]
        public Item[] items;

    }

    [DataContract]
    public class Item
    {
        [DataMember]
        public CustomerOptions Options;
        [DataMember]
        public string cost;
        [DataMember]
        public string name;
        [DataMember]
        public string sku;

    }

    [DataContract]
    public class CustomerOptions
    {
        [DataMember]
        public string color;
        [DataMember]
        public string size;
    }


}
