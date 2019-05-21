using Controller.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Service
{
    public class ImportExcelSevice : IAnalyzeExcel
    {
        /// <summary>
        /// 更新需出貨excel
        /// </summary>
        /// <param name="filePath"></param>
        public List<List<string>> AnalyzeShipData(string filePath)
        {
            var dt = new DataTable();
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            //StreamReader sr = new StreamReader(fs, encoding);
            //string fileContent = sr.ReadToEnd();
            //記錄每次讀取的一行記錄
            string strLine = "";
            //記錄每行記錄中的各字段內容
            string[] aryLine = null;
            string[] tableHead = null;
            //標示列數
            int columnCount = 0;
            //標示是否是讀取的第一行
            bool IsFirst = true;
            //逐行讀取CSV中的數據
            while ((strLine = sr.ReadLine()) != null)
            {
                if (IsFirst == true)
                {
                    tableHead = strLine.Split(',');
                    IsFirst = false;
                    columnCount = tableHead.Length;
                    //創建列
                    for (int i = 0; i < columnCount; i++)
                    {
                        tableHead[i] = tableHead[i].Replace("\"", "");
                        DataColumn dc = new DataColumn(tableHead[i]);
                        dt.Columns.Add(dc);
                    }
                }
                else
                {
                    aryLine = strLine.Split(',');
                    DataRow dr = dt.NewRow();
                    for (int j = 0; j < columnCount; j++)
                    {
                        dr[j] = aryLine[j].Replace("\"", "");
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (aryLine != null && aryLine.Length > 0)
            {
                dt.DefaultView.Sort = tableHead[2] + " " + "DESC";
            }

            sr.Dispose();
            fs.Dispose();


            return new List<List<string>>();
        }
    }
}
