using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Trending.MainClass
{
    /// <summary>
    /// <author> Johns George</author>
    /// <date> 26/03/2015</date>
    /// <purpose></purpose>
    /// </summary>
   public class TextReadWriteClass
    {
       private  string FeedFilePath;// Path of feed file 
        public TextReadWriteClass()
        {
            FeedFilePath = Resource1.TextFeedFilePath; // Feed file path in Resource file 
            if (!File.Exists(FeedFilePath))
            {
                StreamWriter SW = File.CreateText(FeedFilePath);
                SW.Close();  
            }    
                  
        }

        public void AddFeed(string TextFeedFileLink, string RSSFeedDesc)    //method for storing RSS feed in text file
        {
            StreamWriter tw = File.AppendText(FeedFilePath);
            tw.WriteLine(TextFeedFileLink);
            tw.WriteLine(RSSFeedDesc);
            tw.Close();
        }

        public bool IsFeedPresent(string RSSFeedPath)                       //method for checking if that rssfeed already exits
        {
            TextReader TR = new StreamReader(FeedFilePath);
            string NextLine = TR.ReadLine();
            while (NextLine != null)
            {
                if (NextLine == RSSFeedPath)
                {
                    TR.Close();
                    return true;
                }
                NextLine = TR.ReadLine();
            }
            TR.Close();
            return false;
        }
    }
}
