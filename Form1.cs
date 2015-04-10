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
    public partial class Form1 : Form
    {
        bool RSSButton = false;
        bool LoadEvent = false;
        private MainClass.RSSFeedManagerClass FM;
       // private MainClass.TextReadWriteClass TRW;

        public Form1()
        {
            InitializeComponent();
            tmrTrackHistory.Enabled = true;
            LoadEvent = true;
            FM = new MainClass.RSSFeedManagerClass();
            //TRW = new MainClass.TextReadWriteClass();
            
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
                XmlNode RSSDesc = RSSXml.SelectSingleNode("rss/channel/title");

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
                        //sb.Append("<table><tr><td>" + title + "</td><td><img src='" + Url + "'/></td></tr>");
                        //sb.Append("<font face='arial'><b><a href='" + link + "'>" + title + "</a></b><br/>");
                       // sb.Append("<table><td><img src='" + Url + "' height="+ x+" width="+y+" /></td><td><font face='arial'><b><a href='" + link + "'>" + title + "</a></b><br/><p>" + desc + "</p></td><br/></table>");
                        sb.Append("<table><td><img src='" + Url + "' height=" + x + " width=" + y + " /></td><td><font face='arial'><b><a href='" + link + "'>" + title + "</a></b><br/><p>" + desc + "</p></td><br/></table>");
                        if (pubDate != "")
                        {
                            sb.Append(pubDate + "<br/><br/>");
                        }
                        sb.Append("<hr>");
                        //sb.Append("<p>" + desc + "</p>");
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



                    //RSSSubNode = RSSNode.SelectSingleNode("link");
                    //string link = RSSSubNode != null ? RSSSubNode.InnerText : "";

                    //RSSSubNode = RSSNode.SelectSingleNode("description");
                    //string desc = RSSSubNode != null ? RSSSubNode.InnerText : "";


                    //RSSSubNode = RSSNode.SelectSingleNode("pubDate");
                    //string pubDate = RSSSubNode != null ? RSSSubNode.InnerText : "";

                    //sb.Append("<tr><td><font face='arial'><b><a href='" + link + "'></font></td><td>" + desc + "</td></tr></table>");

                    //sb.Append("<font face='arial'><p><b><a href='");
                    //sb.Append(link);
                    //sb.Append("'>");
                    //sb.Append(title);
                    //sb.Append("</a></b><br/>");
                    //if (pubDate != "")
                    //  sb.Append(pubDate + "<br/><br/>");
                    //sb.Append(desc);

                    //sb.Append("</p></font>");


                }
                RSSButton = true;
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

        private void tsFileAddNews_Click(object sender, EventArgs e)
        {
            frmAddNews fAddNew = new frmAddNews();
            fAddNew.Show();
        }

        private void dataGridView1_CellMouseUp(object sender, EventArgs e)
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
           
                //if ((int)e.CurrentProgress > 0)
                //{
                //    toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
                //    if (toolStripProgressBar1.Maximum == (int)e.MaximumProgress)
                //        toolStripProgressBar1.Value = 0;
                //    toolStripProgressBar1.Value = (int)e.CurrentProgress;
                //}
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x,y;
            x = Screen.PrimaryScreen.Bounds.Width;
            y = Screen.PrimaryScreen.Bounds.Height;

            //MessageBox.Show("Hight of screen is  " + y + "Width of screen :" + x);
            if(!RSSButton)
            NetBrowser.Navigate("https://www.google.ie/");

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool available = NetworkInterface.GetIsNetworkAvailable();
            if(available == false)
            {
                MessageBox.Show("Internet Disconnected");
                timer1.Stop();
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/johns.george.5");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("www.dit.ie");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("www.github.com");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/johnsg811");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.Remove(row);
                }
                MessageBox.Show("Selected Website Removed");
            }
        }

        private void userGuildlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Add new websites == File -> Add New -> Provide RSS url for that site" + "\n" + "2. Select the webstie provided to read the news in short version" + "\n" + "3. Click on the particular new link to read the fulll news below", "User Guildline");
        }



    }
}

