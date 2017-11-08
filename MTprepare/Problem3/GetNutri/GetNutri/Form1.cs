using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace GetNutri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter, NodeIter2, NodeIter3;

            String strExpression;
            strExpression = "//food[fiber > 2]";

            String strExpression2;
            strExpression2 = "//food[@type='meat']";

            String strExpression3;
            strExpression3 = "//food[@type='vegetable']";

            
            // Open the XML.
            string xmlFile = Application.StartupPath + "\\Nutrition.xml";
            docNav = new XPathDocument(xmlFile);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            NodeIter = nav.Select(strExpression);

            NodeIter2 = nav.Select(strExpression2);

            NodeIter3 = nav.Select(strExpression3);

            StringBuilder itemResult = new StringBuilder();
            while (NodeIter.MoveNext())
            {
                itemResult.AppendLine("Name: " + NodeIter.Current.SelectSingleNode("name").Value);
                itemResult.AppendLine("Calories: " + NodeIter.Current.SelectSingleNode("calories").GetAttribute("total", ""));
                itemResult.AppendLine(" ");
            };
            textBox1.Text = itemResult.ToString();


            StringBuilder itemResult2 = new StringBuilder();
            while (NodeIter2.MoveNext())
            {
                itemResult2.AppendLine("Name: " + NodeIter2.Current.SelectSingleNode("name").Value);
                itemResult2.AppendLine(" ");
            };
            textBox2.Text = itemResult2.ToString();


            StringBuilder itemResult3 = new StringBuilder();
            while (NodeIter3.MoveNext())
            {
                XPathNodeIterator vit, mins;
                itemResult3.AppendLine("Name: " + NodeIter3.Current.SelectSingleNode("name").Value);
                
                vit = NodeIter3.Current.Select("vitamins");
                while (vit.MoveNext())
                {
                    XPathNavigator custOptNav1 = vit.Current;
                    int count = vit.Current.SelectChildren(XPathNodeType.Element).Count;
                    if (count > 0)
                    {
                        itemResult3.AppendLine("Vitamins");
                        itemResult3.AppendLine("a: " + custOptNav1.SelectSingleNode("a").Value);
                        itemResult3.AppendLine("c: " + custOptNav1.SelectSingleNode("c").Value);
                    }
                }

                mins = NodeIter3.Current.Select("minerals");
                while (mins.MoveNext())
                {
                    XPathNavigator custOptNav2 = mins.Current;
                    int count = mins.Current.SelectChildren(XPathNodeType.Element).Count;
                    if (count > 0)
                    {
                        itemResult3.AppendLine("Minerals");
                        itemResult3.AppendLine("ca: " + custOptNav2.SelectSingleNode("ca").Value);
                        itemResult3.AppendLine("fe: " + custOptNav2.SelectSingleNode("fe").Value);
                    }
                }
                itemResult3.AppendLine(" ");
            };

            textBox3.Text = itemResult3.ToString();

        }
    }
}
