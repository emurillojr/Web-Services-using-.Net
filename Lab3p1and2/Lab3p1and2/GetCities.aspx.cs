using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;

namespace Lab3p1and2
{
    public partial class GetCities : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            String enteredZipCode = TextBox1.Text;

            //Create Request
            String ZipCodeCitiesURL = "http://api.geonames.org/postalCodeSearch?postalcode=" + enteredZipCode + "&maxRows=10&username=emurillojr";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(ZipCodeCitiesURL);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            //Get Response
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //Load response stream into XMLReader
            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            XPathNodeIterator NodeIter;
            String zip;
            zip = "//code";
            
            NodeIter = nav.Select(zip);
            
            while (NodeIter.MoveNext())
            {
                TextBox2.Text += NodeIter.Current.SelectSingleNode("postalcode").Value + " - " + NodeIter.Current.SelectSingleNode("name").Value;
                TextBox2.Text += "\n";
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            String enteredZipCode = TextBox1.Text;

            //Create Request
            String ZipCodeCitiesURL = "http://api.geonames.org/findNearbyPostalCodes?postalcode=" + enteredZipCode + "&country=US&radius=10&username=emurillojr";
           
            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(ZipCodeCitiesURL);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            //Get Response
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //Load response stream into XMLReader
            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            XPathNodeIterator NodeIter;
            String zip;
            zip = "//code";

            NodeIter = nav.Select(zip);

            while (NodeIter.MoveNext())
            {
                TextBox2.Text += NodeIter.Current.SelectSingleNode("postalcode").Value + " - " + NodeIter.Current.SelectSingleNode("name").Value;
                TextBox2.Text += "\n";
            }
            
        }
    }
}