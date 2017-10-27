using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab4OrderWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IOrderManager
    {
        // TODO: Add your service operations here

        [OperationContract]
        double GetNumberOfOrders();

        [OperationContract]
        double GetTotalCostForAnOrder(int OrderID);

        [OperationContract]
        Items[] GetItemListForOrder(int OrderID);

        [OperationContract]
        double HowManyOrderedForAPartNo(String sPartNo);

        [OperationContract]
        BillingAddress GetBillingAddressForAnOrder(int OrderID);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }

    }


    [DataContract]
    public class BillingAddress
    {
        [DataMember]
        public string Name;
        [DataMember]
        public string Address;
        [DataMember]
        public string City;
        [DataMember]
        public string State;
        [DataMember]
        public string ZipCode;

    }

    [DataContract]
    public class Items
    {
        [DataMember]
        public string PartNo;
        [DataMember]
        public string Description;
        [DataMember]
        public string UnitPrice;
        [DataMember]
        public string Quantity;
        [DataMember]
        public string TotalCost;
        [DataMember]
        public string Size;
        [DataMember]
        public string Color;

    }

}
