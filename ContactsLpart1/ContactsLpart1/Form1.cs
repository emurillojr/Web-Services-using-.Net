using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace ContactsLpart1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\contacts.xml";
            StringBuilder results = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(strFilename);
            XmlElement elm = xmlDoc.DocumentElement;
            XmlNodeList stocks = xmlDoc.GetElementsByTagName("LatestVers");
            XmlNodeList stocks2 = xmlDoc.GetElementsByTagName("CurrentVersion");

            foreach (XmlNode node in stocks)
            {
                Console.WriteLine(node.InnerText);
                results.AppendLine(node.InnerText);
            }

            foreach (XmlNode node in stocks2)
            {
                Console.WriteLine(node.InnerText);
                results.AppendLine(node.InnerText);
            }
            txtResults.Text = results.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\contacts.xml";
            StringBuilder results = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();
            
            xmlDoc.Load(strFilename);
            XmlElement elm = xmlDoc.DocumentElement;
            XmlNodeList stocks = xmlDoc.GetElementsByTagName("Contact");

            // Now you can check each node of the list
            foreach (XmlNode node in stocks)
            {
                string sex = node.Attributes["sex"].Value;
                Console.WriteLine("Sex: " + sex);
                results.AppendLine("Sex: " + sex);
                
                foreach (XmlElement nodeChild in node.ChildNodes)
                {
                    Console.WriteLine(nodeChild.InnerText);
                    results.AppendLine(nodeChild.InnerText);
                }

            }

            txtResults.Text = results.ToString();
        }
    }
}
