using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Lab2_XPath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnItemInformation_Click(object sender, EventArgs e)
        {
            txtboxItemInfo.Text = "";
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            String strExpression;
            strExpression = "/Order/Items/Item";
            // Open the XML.
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            docNav = new XPathDocument(xmlFile);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            NodeIter = nav.Select(strExpression);
            StringBuilder itemResult = new StringBuilder();

            while (NodeIter.MoveNext())
            {
                XPathNodeIterator custOptionIter;
                //XPathNodeIterator customerOptions = NodeIter.Current.SelectChildren(XPathNodeType.Element);
                itemResult.AppendLine(NodeIter.Current.SelectSingleNode("PartNo").Value);
                itemResult.AppendLine(NodeIter.Current.SelectSingleNode("Description").Value);
                itemResult.AppendLine(NodeIter.Current.SelectSingleNode("UnitPrice").Value);
                itemResult.AppendLine(NodeIter.Current.SelectSingleNode("Quantity").Value);
                itemResult.AppendLine(NodeIter.Current.SelectSingleNode("TotalCost").Value);

                custOptionIter = NodeIter.Current.Select("CustomerOptions");
                while (custOptionIter.MoveNext())
                {
                    XPathNavigator custOptNav = custOptionIter.Current;
                    int count = custOptionIter.Current.SelectChildren(XPathNodeType.Element).Count;
                    if (count > 0)
                    {
                        itemResult.AppendLine("-- Customer Options --");
                        itemResult.AppendLine("Size: " + custOptNav.SelectSingleNode("Size").Value);
                        itemResult.AppendLine("Color: " + custOptNav.SelectSingleNode("Color").Value);
                    }
                }

                itemResult.AppendLine("");
                txtboxItemInfo.Text = itemResult.ToString();
            };

            //double Total = (double)nav.Evaluate("sum(Order/Items/Item/TotalCost)");
            //double Count = (double)nav.Evaluate("count(Order/Items/Item)");
            //lblTotalCostOfOrder.Text = "Total Orders:    " + Total.ToString();
            //lblNumberOfItemsBought.Text = "Numbers of items:" + Count.ToString();

            lblTotalCostOfOrder.Text = "Total Orders:    " + nav.Evaluate("sum(Order/Items/Item/TotalCost)");
            lblNumberOfItemsBought.Text = "Numbers of items:" + nav.Evaluate("count(Order/Items/Item)");
            
        }

        private void btnShippingInformation_Click(object sender, EventArgs e)
        {
            txtboxShippingInfo.Text = "";
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            String strExpression;
            strExpression = "/Order/ShippingInformation";
            // Open the XML.
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            docNav = new XPathDocument(xmlFile);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            NodeIter = nav.Select(strExpression);

            while (NodeIter.MoveNext())
            {
                txtboxShippingInfo.Text += NodeIter.Current.SelectSingleNode("Address").Value + Environment.NewLine;
                txtboxShippingInfo.Text += NodeIter.Current.SelectSingleNode("City").Value + Environment.NewLine;
                txtboxShippingInfo.Text += NodeIter.Current.SelectSingleNode("State").Value + Environment.NewLine;
                txtboxShippingInfo.Text += NodeIter.Current.SelectSingleNode("ZipCode").Value + Environment.NewLine;
                txtboxShippingInfo.Text += Environment.NewLine;

            };


        }

        private void btnBillingInformation_Click(object sender, EventArgs e)
        {
            txtboxBillingInfo.Text = "";
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            String strExpression;
            strExpression = "/Order/BillingInformation";
            // Open the XML.
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            docNav = new XPathDocument(xmlFile);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            NodeIter = nav.Select(strExpression);

            while (NodeIter.MoveNext())
            {
                txtboxBillingInfo.Text += NodeIter.Current.SelectSingleNode("Name").Value + Environment.NewLine;
                txtboxBillingInfo.Text += NodeIter.Current.SelectSingleNode("Address").Value + Environment.NewLine;
                txtboxBillingInfo.Text += NodeIter.Current.SelectSingleNode("City").Value + Environment.NewLine;
                txtboxBillingInfo.Text += NodeIter.Current.SelectSingleNode("State").Value + Environment.NewLine;
                txtboxBillingInfo.Text += NodeIter.Current.SelectSingleNode("ZipCode").Value + Environment.NewLine;
                txtboxBillingInfo.Text += Environment.NewLine;

            };
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtboxItemInfo.Text = "";
            txtboxShippingInfo.Text = "";
            txtboxBillingInfo.Text = "";
            lblTotalCostOfOrder.Text = "";
            lblNumberOfItemsBought.Text = "";
        }

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            btnItemInformation_Click(sender, e);
            btnShippingInformation_Click(sender, e);
            btnBillingInformation_Click(sender, e);

        }
    }
}
