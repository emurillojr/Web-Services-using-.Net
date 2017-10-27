using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


// interface

namespace ContactManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IContactManager
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        [OperationContract]
        int GetNumberOfContacts();  // added for in class

        [OperationContract]
        ContactInformation GetClientInformation();  // added for in class
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        [DataMember]
        public bool BoolValue = true;
        [DataMember]
        public string StringValue = "Hello ";

    }

    [DataContract]
    public class ContactInformation
    {
        [DataMember]
        public string FirstName;
        [DataMember]
        public string LastName;
        [DataMember]
        public string PhoneNumber;
        [DataMember]
        public string FaxNumber;
        [DataMember]
        public string EmailAddress;

    }

}
