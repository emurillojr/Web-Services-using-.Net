using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace ReadFileFromXpath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
 
            XPathNavigator nav;
            XPathDocument docNav;

            String strExpression;
            String strExpression1;
            strExpression = "/ContactDatabase/DBinfo/LatestVers";
            strExpression1 = "/ContactDatabase/DBinfo/CurrentVersion";
            // Open the XML.
            string xmlFile = Application.StartupPath + "\\contacts.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            String version = nav.SelectSingleNode(strExpression).Value;
            String version2 = nav.SelectSingleNode(strExpression1).Value;

            txtResults.Text += version + Environment.NewLine;
            txtResults.Text += version2 + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";

            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            String strExpression;
            strExpression = "/ContactDatabase/DBinfo/Contact";

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\contacts.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            
            NodeIter = nav.Select(strExpression);

            while (NodeIter.MoveNext())
            {
                txtResults.Text += "Gender: " + NodeIter.Current.SelectSingleNode("./@sex").Value + Environment.NewLine; ;
                txtResults.Text += NodeIter.Current.SelectSingleNode("FirstName").Value + Environment.NewLine; ;
                txtResults.Text += NodeIter.Current.SelectSingleNode("LastName").Value + Environment.NewLine; ;
                txtResults.Text += NodeIter.Current.SelectSingleNode("PhoneNumber").Value + Environment.NewLine; ;
                txtResults.Text += NodeIter.Current.SelectSingleNode("FaxNumber").Value + Environment.NewLine; ;
                txtResults.Text += NodeIter.Current.SelectSingleNode("emailAddress").Value + Environment.NewLine; ;
                txtResults.Text += Environment.NewLine;

            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";

            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            String strExpression;
            strExpression = "/ContactDatabase/DBinfo/Contact[@sex = 'm']";

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\contacts.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            NodeIter = nav.Select(strExpression);

            while (NodeIter.MoveNext())
            {
                txtResults.Text += "Gender: " + NodeIter.Current.SelectSingleNode("./@sex").Value + Environment.NewLine;
                txtResults.Text += NodeIter.Current.SelectSingleNode("FirstName").Value + Environment.NewLine;
                txtResults.Text += NodeIter.Current.SelectSingleNode("LastName").Value + Environment.NewLine;
                txtResults.Text += NodeIter.Current.SelectSingleNode("PhoneNumber").Value + Environment.NewLine;
                txtResults.Text += NodeIter.Current.SelectSingleNode("FaxNumber").Value + Environment.NewLine;
                txtResults.Text += NodeIter.Current.SelectSingleNode("emailAddress").Value + Environment.NewLine;
                txtResults.Text += Environment.NewLine;
            };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";

            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            String strExpression;
            strExpression = "/ContactDatabase/DBinfo/Contact[LastName[contains(text(),'" + lastNameText.Text.ToString() + "')]]";

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\contacts.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            
            NodeIter = nav.Select(strExpression);
            
            while (NodeIter.MoveNext())
            {
                txtResults.Text += "Gender: " + NodeIter.Current.SelectSingleNode("./@sex").Value + Environment.NewLine;
                txtResults.Text += NodeIter.Current.SelectSingleNode("FirstName").Value + Environment.NewLine;
                txtResults.Text += NodeIter.Current.SelectSingleNode("LastName").Value + Environment.NewLine;
                txtResults.Text += NodeIter.Current.SelectSingleNode("PhoneNumber").Value + Environment.NewLine;
                txtResults.Text += NodeIter.Current.SelectSingleNode("FaxNumber").Value + Environment.NewLine;
                txtResults.Text += NodeIter.Current.SelectSingleNode("emailAddress").Value + Environment.NewLine;
                txtResults.Text += Environment.NewLine;

            };
        }
    }
}
