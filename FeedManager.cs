using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;

namespace TrendingNews
{
    class FeedManager
    {
        private string m_sFeedListPath;
        public FeedManager()
        {
            m_sFeedListPath = "./FeedList.txt";
            if (!File.Exists(m_sFeedListPath))
            {
                StreamWriter temp = File.CreateText(m_sFeedListPath);
                temp.Close();  
            }                      
        }

        public void AddFeed(string sFeedPath, string sFeedDesc)
        {
            StreamWriter tw = File.AppendText(m_sFeedListPath);
            tw.WriteLine(sFeedPath);
            tw.WriteLine(sFeedDesc);
            tw.Close();
        }

        public bool IsFeedPresent(string sFeedPath)
        {
            TextReader tr = new StreamReader(m_sFeedListPath);
            string sNextLine = tr.ReadLine();
            while (sNextLine != null)
            {
                if (sNextLine == sFeedPath)
                {
                    tr.Close();
                    return true;
                }
                sNextLine = tr.ReadLine();
            }
            tr.Close();
            return false;
        }

        public string GetFeedListAsHTML()
        {
            string[] aryFeedList = GetFeedList();
            StringBuilder sb=new StringBuilder();
            if (aryFeedList == null) return null;
            for (int i = 0; i < aryFeedList.Length; i += 2)
            {
                sb.Append("<font face='arial' size='2%'><a href='");
                sb.Append(aryFeedList[i]);
                sb.Append("'>");
                sb.Append(aryFeedList[i+1]);
                sb.Append("</a><br/></font>");
            }
            return sb.ToString();
        }

        public DataTable GetFeedListAsDT()
        {
            string[] aryFeedList = GetFeedList();
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

        public string[] GetFeedList()
        {
            string[] aryFeedList=null;
            int iNumLines = 0;
            TextReader tr = new StreamReader(m_sFeedListPath);
            string sNextLine = tr.ReadLine();
            while (sNextLine != null)
            {
                iNumLines++;
                sNextLine = tr.ReadLine();
            }
            tr.Close();
            if (iNumLines > 0)
            {
                aryFeedList = new string[iNumLines];
                tr = new StreamReader(m_sFeedListPath);
                iNumLines = 0;
                sNextLine = tr.ReadLine();
                while (sNextLine != null)
                {
                    aryFeedList[iNumLines] = sNextLine;
                    iNumLines++;
                    sNextLine = tr.ReadLine();
                }
                tr.Close();
            }
            
            return aryFeedList;
        }
    }
}
