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

namespace Trending
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Feed()
        {
            try
            {
                // get an xpath navigator   
                DataTable dt = new DataTable();
                dt.Columns.Add("Title", typeof(string));
                dt.Columns.Add("Link", typeof(string));
                try
                {

                    
                  XmlDocument RSSXml = new XmlDocument();
                  RSSXml.Load(textBox1.Text);
                  this.Cursor = Cursors.Default;
                 XmlNodeList RSSNodeList = RSSXml.SelectNodes("rss/channel/item");
                XmlNode RSSDesc = RSSXml.SelectSingleNode("rss/channel/title");

                StringBuilder sb = new StringBuilder();

                foreach (XmlNode RSSNode in RSSNodeList)
                {
                    int i=0;
                    XmlNode RSSSubNode;
                    RSSSubNode = RSSNode.SelectSingleNode("title");
                    string title = RSSSubNode != null ? RSSSubNode.InnerText : "";

                    RSSSubNode = RSSNode.SelectSingleNode("link");
                    string link = RSSSubNode != null ? RSSSubNode.InnerText : "";

                    RSSSubNode = RSSNode.SelectSingleNode("description");
                    string desc = RSSSubNode != null ? RSSSubNode.InnerText : "";

                    DataRow dr = dt.NewRow();
                    dr["Title"] = title;
                    dr["Link"] = link;
                    dt.Rows.Add(dr);
                    

                }
                dataGridView1.DataSource = dt;
                   


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "RSS Feed Load Error");
                }

                // restore the cursor
                this.Cursor = Cursors.Default;
               // tvwRss.ExpandAll();

            }
            catch (Exception ex2)
            {
                // snitch
                MessageBox.Show(ex2.ToString(), "RSS Feed Initialization Failure");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Feed();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            webBrowser1.Navigate(row.Cells[1].Value.ToString());
        }
    }
}
