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
    public partial class GetForecast : System.Web.UI.Page
    {

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;

            //Create Request
            String WeatherURL = "http://api.wunderground.com/api/8eb0cec557955d5f/forecast//q/MA/Boston.xml";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(WeatherURL);
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
            String dayAndforecastDesc;
            dayAndforecastDesc = "//forecastday";
            NodeIter = nav.Select(dayAndforecastDesc);

            while (NodeIter.MoveNext())
            {
                TextBox1.Text += NodeIter.Current.SelectSingleNode("title");
                TextBox1.Text += "\n";
                TextBox1.Text += NodeIter.Current.SelectSingleNode("fcttext");
                TextBox1.Text += "\n";
                TextBox1.Text += "\n";

            }


        }
    }
}