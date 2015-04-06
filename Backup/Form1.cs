using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.IO;

namespace CaptureRSS
{
    public partial class Form1 : Form
    {
        bool m_bFromRSSButton = false;
        bool m_bFromLoadEvent = false;
        private FeedManager m_oFeedManager;
        
        public Form1()
        {
            InitializeComponent();
            tmrTrackHistory.Enabled = true;
            m_bFromLoadEvent = true;
            m_oFeedManager = new FeedManager();
            string sFeedListHTML = m_oFeedManager.GetFeedListAsHTML();
            RSSList.DocumentText = sFeedListHTML;
        }
        
        private void btnFetchRSS_Click(object sender, EventArgs e)
        {
            //Check if already subscribed
            if (m_oFeedManager.IsFeedPresent(txtURL.Text) && sender.GetType().ToString()==typeof(Button).ToString())
            {
                MessageBox.Show("Already Subscribed", "RSS Feed Initialization Failure");
                return;
            }

            try
            {
                //Fetch the subscribed RSS Feed
                XmlDocument RSSXml = new XmlDocument();
                RSSXml.Load(txtURL.Text);

                XmlNodeList RSSNodeList = RSSXml.SelectNodes("rss/channel/item");
                XmlNode RSSDesc = RSSXml.SelectSingleNode("rss/channel/title");

                StringBuilder sb = new StringBuilder();

                foreach (XmlNode RSSNode in RSSNodeList)
                {
                    XmlNode RSSSubNode;
                    RSSSubNode = RSSNode.SelectSingleNode("title");
                    string title = RSSSubNode != null ? RSSSubNode.InnerText : "";

                    RSSSubNode = RSSNode.SelectSingleNode("link");
                    string link = RSSSubNode != null ? RSSSubNode.InnerText : "";

                    RSSSubNode = RSSNode.SelectSingleNode("description");
                    string desc = RSSSubNode != null ? RSSSubNode.InnerText : "";

                    sb.Append("<font face='arial'><p><b><a href='");
                    sb.Append(link);
                    sb.Append("'>");
                    sb.Append(title);
                    sb.Append("</a></b><br/>");
                    sb.Append(desc);
                    sb.Append("</p></font>");
                }
                m_bFromRSSButton = true;
                RSSBrowser.DocumentText = sb.ToString();

                //Add the new RSS feed
                if (sender.GetType().ToString() == typeof(Button).ToString())
                {
                    m_oFeedManager.AddFeed(txtURL.Text, RSSDesc.InnerText);
                    m_bFromLoadEvent = true;
                    string sFeedListHTML = m_oFeedManager.GetFeedListAsHTML();
                    RSSList.DocumentText = sFeedListHTML;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),null);// "RSS Feed Initialization Failure");
            }
        }

        private void RSSBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (!m_bFromRSSButton)
            {
                e.Cancel = true;
                NetBrowser.Navigate(e.Url);
            }
            else
            {
                m_bFromRSSButton = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (NetBrowser.CanGoBack)
            {
                NetBrowser.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (NetBrowser.CanGoForward)
            {
                NetBrowser.GoForward();
            }
        }

        private void tmrTrackHistory_Tick(object sender, EventArgs e)
        {
            if (NetBrowser.CanGoForward)
            {
                btnForward.Enabled = true;
            }
            else
            {
                btnForward.Enabled = false;
            }

            if (NetBrowser.CanGoBack)
            {
                btnBack.Enabled = true;
            }
            else
            {
                btnBack.Enabled = false;
            }
        }

        private void RSSList_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (!m_bFromLoadEvent)
            {
                e.Cancel = true;
                txtURL.Text = e.Url.ToString();
                btnFetchRSS_Click(this, new EventArgs());
            }
            else
            {
                m_bFromLoadEvent = false;
            }
        }
    }
}