using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Trending
{
    public partial class frmAddNews : Form
    {
        public frmAddNews()
        {
            InitializeComponent();
        }

        private void frmAddNews_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFeed_Click(object sender, EventArgs e)
        {
            Trending.MainClass.GetSet._RssFeedLink = txtRssWeblink.Text;
            MainClass.RSSFeedManagerClass FMC = new MainClass.RSSFeedManagerClass();
            try
            {
                XmlDocument RSSXml = new XmlDocument();
                RSSXml.Load(txtRssWeblink.Text);
                XmlNode RSSDesc = RSSXml.SelectSingleNode("rss/channel/title");
                // Add the new RSS feed

                FMC.AddFeed(txtRssWeblink.Text, RSSDesc.InnerText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
