using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace ReadingXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\MultipleStockOutput.xml";
            StringBuilder results = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(strFilename);
            XmlElement elm = xmlDoc.DocumentElement;
            XmlNodeList revDate = xmlDoc.GetElementsByTagName("RevisionDate");
            
            foreach (XmlNode node in revDate)
            {
                Console.WriteLine(node.InnerText);
                results.AppendLine(node.InnerText);
            }
            txtResults.Text = results.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\MultipleStockOutput.xml";
            StringBuilder results = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(strFilename);
            XmlElement elm = xmlDoc.DocumentElement;
            XmlNodeList stockName = xmlDoc.GetElementsByTagName("Symbol");

            foreach (XmlNode node in stockName)
            {
                Console.WriteLine(node.InnerText);
                results.AppendLine(node.InnerText);
            }
            txtResults.Text = results.ToString();
        }
    }
}
