using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Xml.XPath;

namespace Lab4OrderWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class OrderManager : IOrderManager
    {
        public BillingAddress GetBillingAddressForAnOrder(int OrderID)
        {

            BillingAddress billaddress = new BillingAddress();

            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "orderInfoLab3.xml";
            XPathDocument docNav;
            XPathNavigator nav;
            docNav = new XPathDocument(strFilename);
            nav = docNav.CreateNavigator();
            //XPath varible search in doc
            String strExpression;
            strExpression = "//Order[@id="+ OrderID + "]/BillingInformation";

            XPathNodeIterator NodeIter;
            docNav = new XPathDocument(strFilename);
            nav = docNav.CreateNavigator();
            //XPath varible search in doc

            NodeIter = nav.Select(strExpression);
 
            while (NodeIter.MoveNext())
            {
                billaddress.Name = NodeIter.Current.SelectSingleNode("Name").Value + " ";
                billaddress.Address = NodeIter.Current.SelectSingleNode("Address").Value + " ";
                billaddress.City = NodeIter.Current.SelectSingleNode("City").Value + " ";
                billaddress.State = NodeIter.Current.SelectSingleNode("State").Value + " ";
                billaddress.ZipCode = NodeIter.Current.SelectSingleNode("ZipCode").Value + " ";
            };

            return billaddress;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Items [] GetItemListForOrder(int OrderID)
        {

            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "orderInfoLab3.xml";
            XPathDocument docNav;
            XPathNavigator nav;
            XPathNodeIterator NodeIter;
            XPathNodeIterator NodeIter2;
            docNav = new XPathDocument(strFilename);
            nav = docNav.CreateNavigator();
            //XPath varible search in doc
            string varString;
            varString = "//Order[@id=" + OrderID + "]/Items/Item";
            //Iterate through number of orders
            NodeIter = nav.Select(varString);
            Items[] oItemInfo = new Items[NodeIter.Count];

            XPathNavigator myNav = nav.SelectSingleNode(varString);
            int i = 0;

            while (NodeIter.MoveNext())
            {
                Items newItem = new Items();
                newItem.PartNo = NodeIter.Current.SelectSingleNode("PartNo").Value;
                newItem.Description = NodeIter.Current.SelectSingleNode("Description").Value;
                newItem.UnitPrice = NodeIter.Current.SelectSingleNode("UnitPrice").Value;
                newItem.Quantity = NodeIter.Current.SelectSingleNode("Quantity").Value;
                newItem.TotalCost = NodeIter.Current.SelectSingleNode("TotalCost").Value;

                NodeIter2 = NodeIter.Current.Select("CustomerOptions");
                while (NodeIter2.MoveNext())
                {
                    XPathNavigator custNav = NodeIter2.Current;
                    int count = NodeIter2.Current.SelectChildren(XPathNodeType.Element).Count;
                    if (count > 0)
                    {
                        newItem.Size = custNav.SelectSingleNode("Size").Value;
                        newItem.Color = custNav.SelectSingleNode("Color").Value;
                    } //else add blank strings to the other items
                    else
                    {
                        newItem.Size = "";
                        newItem.Color = "";
                    }
                }
                oItemInfo[i] = newItem;
                i++;
            }
            return oItemInfo;
        }

        public double GetNumberOfOrders()
        {

            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "orderInfoLab3.xml";
            XPathDocument docNav;
            XPathNavigator nav;
            XPathNodeIterator NodeIter;
            docNav = new XPathDocument(strFilename);
            nav = docNav.CreateNavigator();
            //XPath varible search in doc
            string varString;
            varString = "//Order";
            int count = 0;
            //Iterate through number of orders
            NodeIter = nav.Select(varString);
            count = NodeIter.Count;
            return count;

        }

        public double GetTotalCostForAnOrder(int OrderID)
        {
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "orderInfoLab3.xml";
            XPathDocument docNav;
            XPathNavigator nav;
            docNav = new XPathDocument(strFilename);
            nav = docNav.CreateNavigator();
            //XPath varible search in doc
            
            double Total = (double)
            nav.Evaluate("sum(//Order[@id="+ OrderID +"]/Items/Item/TotalCost)");
            return Total;
        }

        public double HowManyOrderedForAPartNo(string sPartNo)
        {
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "orderInfoLab3.xml";
            XPathDocument docNav;
            XPathNavigator nav;
            XPathNodeIterator NodeIter;
            docNav = new XPathDocument(strFilename);
            nav = docNav.CreateNavigator();
            //XPath varible search in doc
            string varString;
            varString = "//PartNo[text()='" + sPartNo + "']";
            int count = 0;
            //Iterate through number of orders
            NodeIter = nav.Select(varString);
            count = NodeIter.Count;
            return count;


            
        }
    }
}
