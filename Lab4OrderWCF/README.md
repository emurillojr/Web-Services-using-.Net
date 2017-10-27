<b>Creating a WCF Service</b>  
For this lab you will be creating a WCF Service and a client application that will call it.  
These are to both be in the same solution.  
For this service, we will use the OrderInforLab3.xml file as your database  
You will be creating the following methods:  
GetNumberOfOrders
*  Returns an integer with the number of orders in the XML file  
  
GetTotalCostForAnOrder(int OrderID)
*  Returns the total cost for an order  
  
GetItemListForOrder(int OrderID)
*  Returns all of the elements (i.e. from PartNo through customeroptions if they exist) for each item in an order  
  
HowManyOrderedForAPartNo(String sPartNo)
*  The total number of parts that have been ordered across all orders  
The partNo will be an exact match to your part number  
  
GetBillingAddressForAnOrder(int OrderID)
*  Returns the billing header information (i.e. FirstName through ZipCode)
