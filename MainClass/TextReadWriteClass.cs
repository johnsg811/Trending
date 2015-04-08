using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Trending.MainClass
{
   public class TextReadWriteClass
    {
       private  string TextFeedFilePath;
        public TextReadWriteClass()
        {
            TextFeedFilePath = Resource1.TextFeedFilePath;
            if (!File.Exists(TextFeedFilePath))
            {
                StreamWriter temp = File.CreateText(TextFeedFilePath);
                temp.Close();  
            }                      
        }

        public void AddFeed(string TextFeedFilePath, string RSSFeedDesc)
        {
            StreamWriter tw = File.AppendText(TextFeedFilePath);
            tw.WriteLine(TextFeedFilePath);
            tw.WriteLine(RSSFeedDesc);
            tw.Close();
        }

        public bool IsFeedPresent(string RSSFeedPath)
        {
            TextReader TR = new StreamReader(TextFeedFilePath);
            string NextLine = TR.ReadLine();
            while (NextLine != null)
            {
                if (NextLine == TextFeedFilePath)
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
