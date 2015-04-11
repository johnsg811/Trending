using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Trending.MainClass
{
   public class TextReadWriteClass
    {
       private  string FeedFilePath;
        public TextReadWriteClass()
        {
            FeedFilePath = Resource1.TextFeedFilePath;
            if (!File.Exists(FeedFilePath))
            {
                StreamWriter temp = File.CreateText(FeedFilePath);
                temp.Close();  
            }                      
        }

        public void AddFeed(string TextFeedFilePath, string RSSFeedDesc)
        {
            StreamWriter tw = File.AppendText(FeedFilePath);
            tw.WriteLine(TextFeedFilePath);
            tw.WriteLine(RSSFeedDesc);
            tw.Close();
        }

        public bool IsFeedPresent(string RSSFeedPath)
        {
            TextReader TR = new StreamReader(FeedFilePath);
            string NextLine = TR.ReadLine();
            while (NextLine != null)
            {
                if (NextLine == FeedFilePath)
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
