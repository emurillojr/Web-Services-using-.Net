using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;

namespace NEpatWebService
{
    public partial class GetPats : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //http://34.229.220.156/FootballWebService/Footballservice.asmx
            //http://34.229.220.156/FootballWebService/Footballservice.asmx?op=GetFootballTeam
            // xml 
            //http://34.229.220.156/FootballWebService/Footballservice.asmx/GetFootballTeam

            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;

            //Create Request
            String getPats = "http://34.229.220.156/FootballWebService/Footballservice.asmx/GetFootballTeam";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(getPats);
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
            String patsOver250;
            patsOver250 = "//Player[weight > 250]";

            NodeIter = nav.Select(patsOver250);

            while (NodeIter.MoveNext())
            {
                TextBox1.Text += "Name: " + NodeIter.Current.SelectSingleNode("name").Value + "  " +
                                "Weight: " + NodeIter.Current.SelectSingleNode("weight").Value + "  " +
                                "Position: " + NodeIter.Current.SelectSingleNode("position").Value;
                TextBox1.Text += "\n";
            }

        }
    }
}