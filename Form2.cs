using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Trending
{
    public partial class Form2 : Form
    {
        //Trending.Class.DataGroup dg = new Class.DataGroup();
        public Form2()
        {
            InitializeComponent();
        }

        private void BindBlogFeed()
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load("http://blogworkseverytime.wordpress.com/feed/");
            //XmlNamespaceManager xnm = new XmlNamespaceManager();
            //xnm.content = "http://purl.org/rss/1.0/modules/content/";
            //XNamespace media = "http://search.yahoo.com/mrss/";

            //var query = ( doc.Descendants("item")
            //             orderby DateTime.Parse(feed.Element("pubDate").Value) descending
            //             select new
            //             {
            //                 Title = feed.Element("title").Value,
            //                 Description = HttpUtility.HtmlDecode(feed.Element("description").Value),
            //                 Content = HttpUtility.HtmlDecode(feed.Element(content.GetName("encoded")).Value),
            //                 Image = (from img in feed.Elements(media.GetName("content"))
            //                          where img.Attribute("url").Value.Contains("gravatar") == false
            //                          select img.Attribute("url").Value).FirstOrDefault() ?? "",
            //                 Link = feed.Element("link").Value,
            //                 Date = DateTime.Parse(feed.Element("pubDate").Value).ToShortDateString()
            //             });

            //dataGridView1.DataSource = query.Take(1).ToList();
            //dataGridView1.DataBind();

            //lvRemainingBlogFeed.DataSource = query.Skip(1).ToList();
            //lvRemainingBlogFeed.DataBind();
        }
        
      
 
    }
}
