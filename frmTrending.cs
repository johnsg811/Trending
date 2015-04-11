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
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace Trending
{
    public partial class frmTrending : Form
    {
        bool RSSButton = false;
        bool LoadEvent = false;
        private MainClass.RSSFeedManagerClass FM;
       // private MainClass.TextReadWriteClass TRW;

        public frmTrending()
        {
            InitializeComponent();
            tmrTrackHistory.Enabled = true;
            LoadEvent = true;
            FM = new MainClass.RSSFeedManagerClass();
                   
            dataGridView1.DataSource = FM.GetFeedListAsDT();
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 350;
            dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Purple;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;

        }

        private void RSSFeed(bool Status)
        {
            //Check if already subscribed
            if (FM.IsFeedPresent(txtURL.Text) && Status == false)
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
               

                StringBuilder sb = new StringBuilder();
                int x = 115, y = 150;

                foreach (XmlNode RSSNode in RSSNodeList)
                {
                    XmlNode RSSSubNode;
                    RSSSubNode = RSSNode.SelectSingleNode("title");
                    string title = RSSSubNode != null ? RSSSubNode.InnerText : "";

                    RSSSubNode = RSSNode.SelectSingleNode("enclosure");
                    string img = RSSSubNode != null ? RSSSubNode.OuterXml : "";

                    RSSSubNode = RSSNode.SelectSingleNode("link");
                    string link = RSSSubNode != null ? RSSSubNode.InnerText : "";

                    RSSSubNode = RSSNode.SelectSingleNode("description");
                    string desc = RSSSubNode != null ? RSSSubNode.InnerText : "";

                    RSSSubNode = RSSNode.SelectSingleNode("pubDate");
                    string pubDate = RSSSubNode != null ? RSSSubNode.InnerText : "";


                    if (img != "")
                    {
                        string[] words = img.Split(' ', '"');
                        string Url, imgUrl = string.Empty;
                        Url = words[2].ToString();
                       sb.Append("<table><td><img src='" + Url + "' height=" + x + " width=" + y + " /></td><td><font face='arial'><b><a href='" + link + "'>" + title + "</a></b><br/><p>" + desc + "</p></td><br/></table>");
                        if (pubDate != "")
                        {
                            sb.Append(pubDate + "<br/><br/>");
                        }
                        sb.Append("<hr>");
                    }
                    else
                    {
                        sb.Append("<font face='arial'><b><a href='" + link + "'>" + title + "</a></b><br/>");
                        sb.Append(desc + "<br/>");
                        if (pubDate != "")
                        {
                            sb.Append(pubDate + "<br/><br/>");
                        }
                        sb.Append("<hr>");
                    }
                }
                RSSButton = true;
                RSSBrowser.DocumentText = sb.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), null);// "RSS Feed Initialization Failure");
            }
        }

        private void RSSBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (!RSSButton)
            {
                e.Cancel = true;
                NetBrowser.Navigate(e.Url);
            }
            else
            {
                RSSButton = false;
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
            if (!LoadEvent)
            {
                e.Cancel = true;
                txtURL.Text = e.Url.ToString();
                // btnFetchRSS_Click(this, new EventArgs());
            }
            else
            {
                LoadEvent = false;
            }
        }

       

        private void dataGridView1_CellMouseUp(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            txtURL.Text = row.Cells[1].Value.ToString();
            RSSFeed(true);
            //RSSBrowser.Navigate(row.Cells[1].Value.ToString());
        }

        private void NetBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
           
                //if ((int)e.CurrentProgress > 0)
                //{
                //    toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
                //    if (toolStripProgressBar1.Maximum == (int)e.MaximumProgress)
                //        toolStripProgressBar1.Value = 0;
                //    toolStripProgressBar1.Value = (int)e.CurrentProgress;
            //    //}
            //if ((int)e.CurrentProgress > 0)
            //{
            //    if (e.CurrentProgress < e.MaximumProgress)
            //        toolStripProgressBar1.Value = (int)e.CurrentProgress;
            //    else toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
            //}
           


        }
        #region Form load
        private void frmTrending_Load(object sender, EventArgs e)
        {
            int x,y;
            x = Screen.PrimaryScreen.Bounds.Width;
            y = Screen.PrimaryScreen.Bounds.Height;

            //MessageBox.Show("Hight of screen is  " + y + "Width of screen :" + x);
            if (!string.IsNullOrEmpty(Trending.MainClass.GetSet._RssFeedLink))
                txtURL.Text = Trending.MainClass.GetSet._RssFeedLink;
             bool available = NetworkInterface.GetIsNetworkAvailable();
            if(available == false)
                MessageBox.Show("It seems internet is not working");
            if(!RSSButton)
            NetBrowser.Navigate("https://www.google.ie/");

        }
        #endregion

        //Refresh : after adding new RSS feed
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FM.GetFeedListAsDT();
        }

#region Reccomanded Web site
        private void pbFacebook_Click(object sender, EventArgs e)
        {
            NetBrowser.Navigate("https://www.facebook.com");
        }
        

        
        private void pbTwitter_Click(object sender, EventArgs e)
        {
            NetBrowser.Navigate("https://twitter.com");
            
        }

        private void pbDIT_Click(object sender, EventArgs e)
        {
            NetBrowser.Navigate("www.dit.ie");

        }
        private void pbGIHub_Click(object sender, EventArgs e)
        {
            NetBrowser.Navigate("www.github.com");
        }

        private void pgGmail_Click(object sender, EventArgs e)
        {
            NetBrowser.Navigate("https://mail.google.com/");
        }

        private void pbAIB_Click(object sender, EventArgs e)
        {
            NetBrowser.Navigate("http://personal.aib.ie/");
        }
       
#endregion

#region Navigation user input url

        private void URLNavigaion()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtWebURL.Text))
                    NetBrowser.Navigate(txtWebURL.Text);
                else
                    MessageBox.Show("Input right web link", "Wrong web address", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "URL link error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            URLNavigaion();
        }

        private void txtWebURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
                URLNavigaion();
        }

        private void tsAddFeed_Click(object sender, EventArgs e)
        {
            frmAddNews fAddNew = new frmAddNews();
            fAddNew.Show();
        }

#endregion

        private void tsAboutUs_Click(object sender, EventArgs e)
        {
            frmAboutUs fau = new frmAboutUs();
            fau.Show();

        }

        private void tsHelps_Click(object sender, EventArgs e)
        {
            frmHelp fh = new frmHelp();
            fh.Show();


        }






    }
}

