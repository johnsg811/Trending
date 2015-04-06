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
using System.Text.RegularExpressions;

namespace TrendingNews
{
    public partial class Form1 : Form
    {
        bool m_bFromRSSButton = false;
        bool m_bFromLoadEvent = false;
        private FeedManager FM;

        public Form1()
        {
            InitializeComponent();
            tmrTrackHistory.Enabled = true;
            m_bFromLoadEvent = true;
            FM = new FeedManager();
            string sFeedListHTML = FM.GetFeedListAsHTML();
            //RSSList.DocumentText = sFeedListHTML;
            dataGridView1.DataSource = FM.GetFeedListAsDT();
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 350;
            dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.MediumBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Navy;
        }
       
       private void RSSFeed(bool Status)
       {
            //Check if already subscribed
           if (FM.IsFeedPresent(txtURL.Text) && Status==false)
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
                    RSSSubNode = RSSNode.SelectSingleNode("enclosure");
                    string img = RSSSubNode != null ? RSSSubNode.OuterXml : "";

                    if (img != "")
                    {
                        string[] words = img.Split(' ', '"');
                        string Url, imgUrl = string.Empty;
                        Url = words[2].ToString();
                        sb.Append("<img src='" + Url + "'/>");
                    }

                    RSSSubNode = RSSNode.SelectSingleNode("title");
                    string title = RSSSubNode != null ? RSSSubNode.InnerText : "";

                    RSSSubNode = RSSNode.SelectSingleNode("link");
                    string link = RSSSubNode != null ? RSSSubNode.InnerText : "";

                    RSSSubNode = RSSNode.SelectSingleNode("description");
                    string desc = RSSSubNode != null ? RSSSubNode.InnerText : "";


                    RSSSubNode = RSSNode.SelectSingleNode("pubDate");
                    string pubDate = RSSSubNode != null ? RSSSubNode.InnerText : "";

                    

                    sb.Append("<font face='arial'><p><b><a href='");
                    sb.Append(link);
                    sb.Append("'>");
                    sb.Append(title);
                    sb.Append("</a></b><br/>");
                    if (pubDate!="")
                    sb.Append(pubDate);
                    sb.Append(desc);
                                      
                    sb.Append("</p></font>");


                }
                m_bFromRSSButton = true;
                RSSBrowser.DocumentText = sb.ToString();

                //Add the new RSS feed
               // if (sender.GetType().ToString() == typeof(Button).ToString())
               // {
                  //  FM.AddFeed(txtURL.Text, RSSDesc.InnerText);
                   // m_bFromLoadEvent = true;
                   // string sFeedListHTML = FM.GetFeedListAsHTML();
                    //RSSList.DocumentText = sFeedListHTML;
                   // dataGridView1.DataSource = FM.GetFeedListAsDT();

               // }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), null);// "RSS Feed Initialization Failure");
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
               // btnFetchRSS_Click(this, new EventArgs());
            }
            else
            {
                m_bFromLoadEvent = false;
            }
        }

        private void tsFileAddNews_Click(object sender, EventArgs e)
        {
            frmAddNews fAddNew = new frmAddNews();
            fAddNew.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

       

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            txtURL.Text = row.Cells[1].Value.ToString();
            RSSFeed(true);  
            //RSSBrowser.Navigate(row.Cells[1].Value.ToString());
        }

        private void NetBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {

            if ((int)e.CurrentProgress > 0)
            {
                toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
                if (toolStripProgressBar1.Maximum == (int)e.MaximumProgress)
                    toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Value = (int)e.CurrentProgress;
            }


        }
    }
}

