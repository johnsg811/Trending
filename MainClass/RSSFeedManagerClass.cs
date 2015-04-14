using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;

namespace Trending.MainClass
{
    /// <summary>
    /// 
    /// </summary>
    //public static class GetSet
    //{
    //    public static string _RssFeedLink;

    //    public static string RssFeedLink
    //    {
    //        get { return _RssFeedLink; }
    //        set { _RssFeedLink = value; }
    //    }
    //}
    public class RSSFeedManagerClass:TextReadWriteClass             //inheritence
    {
       
        private string TextFeedFilePath;
        public RSSFeedManagerClass()
        {
            TextFeedFilePath = Resource1.TextFeedFilePath;
        }



        public DataTable GetFeedListAsDT()
        {
            string[] aryFeedList = GetRSSFeedList();
            //Create data table
            DataTable dt = new DataTable();
            //Define the column of data table
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Link", typeof(string));
            //check array list is blank or not. if balnk then only data table structure is return.
            if (aryFeedList == null) return dt;
            //read array list and insert the data in both the coulmns
            for (int i = 0; i < aryFeedList.Length; i += 2)
            {
                DataRow dr = dt.NewRow();
                dr["Link"] = Convert.ToString(aryFeedList[i]);
                dr["Title"] = Convert.ToString(aryFeedList[i + 1]);
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public string[] GetRSSFeedList()
        {
            string[] arryRssFeed=null;
            int NumLines = 0;
            TextReader TR = new StreamReader(TextFeedFilePath);
            string NextLine = TR.ReadLine(); // Read data from text feed file
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
