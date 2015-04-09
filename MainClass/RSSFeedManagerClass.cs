using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;

namespace Trending.MainClass
{
    public class RSSFeedManagerClass:TextReadWriteClass
    {
        private string TextFeedFilePath;
        public RSSFeedManagerClass()
        {
            TextFeedFilePath = Resource1.TextFeedFilePath;
        }
  
            

        public DataTable GetFeedListAsDT()
        {
            string[] aryFeedList = GetRSSFeedList();
            StringBuilder sb = new StringBuilder();
                       DataTable dt = new DataTable();
                dt.Columns.Add("Title", typeof(string));
                dt.Columns.Add("Link", typeof(string));
            if (aryFeedList == null) return null;
            for (int i = 0; i < aryFeedList.Length; i += 2)
            {
                    DataRow dr = dt.NewRow();
                    dr["Title"] = aryFeedList[i+1];
                    dr["Link"] = aryFeedList[i];
                    dt.Rows.Add(dr);
            }
            return dt;
        }

        public string[] GetRSSFeedList()
        {
            string[] arryRssFeed=null;
            int NumLines = 0;
            TextReader TR = new StreamReader(TextFeedFilePath);
            string NextLine = TR.ReadLine();
            while (NextLine != null)
            {
                NumLines++;
                NextLine = TR.ReadLine();
            }
            TR.Close();
            if (NumLines > 0)
            {
                arryRssFeed = new string[NumLines];
                TR = new StreamReader(TextFeedFilePath);
                NumLines = 0;
                NextLine = TR.ReadLine();
                while (NextLine != null)
                {
                    arryRssFeed[NumLines] = NextLine;
                    NumLines++;
                    NextLine = TR.ReadLine();
                }
                TR.Close();
            }

            return arryRssFeed;
        }
    }
}
