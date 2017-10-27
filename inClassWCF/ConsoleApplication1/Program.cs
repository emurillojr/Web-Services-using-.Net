using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel; // added 

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactExample.ContactManagerClient myProxy = new ContactExample.ContactManagerClient();  // added
            int num = myProxy.GetNumberOfContacts();
            
            //project name. service reference .  class name from other project VARIABLE =  myProxy.GetClientInformation();
            ConsoleApplication1.ContactExample.ContactInformation names = myProxy.GetClientInformation();
            //Console.WriteLine(names.FirstName);
            //Console.WriteLine(names.LastName);
            //Console.WriteLine(names.PhoneNumber);
            Console.WriteLine("The fax number is: " + names.FaxNumber);
            //Console.WriteLine(names.EmailAddress);

            Console.WriteLine("The number of contacts are: " + num);
            
            Console.ReadLine();
        }
    }
}
