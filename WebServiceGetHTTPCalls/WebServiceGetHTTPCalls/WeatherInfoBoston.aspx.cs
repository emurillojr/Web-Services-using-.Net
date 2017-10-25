using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;

namespace WebServiceGetHTTPCalls
{
    public partial class WeatherInfoBoston : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;

            //Create Request
            String WeatherURL = "http://api.wunderground.com/api/8eb0cec557955d5f/conditions/q/MA/Boston.xml";

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

            XPathNodeIterator NodeIter, NodeIter1, NodeIter2;
            String latlon, feelsLike;
            latlon = "//observation_location";
            feelsLike = "//current_observation";

            NodeIter = nav.Select(latlon);
            NodeIter1 = nav.Select(feelsLike);

            while (NodeIter.MoveNext())
            {
                TextBox5.Text += "Latitude:" + NodeIter.Current.SelectSingleNode("latitude").Value + "  " + "Longitude:" + NodeIter.Current.SelectSingleNode("longitude").Value;
                TextBox5.Text += "\n";
            }

            while (NodeIter1.MoveNext())
            {
                TextBox5.Text += "Feels Like: " + NodeIter1.Current.SelectSingleNode("feelslike_string");
            };
        }
    }
}