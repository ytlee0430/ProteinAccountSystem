using Controller.Interface;
using Spire.Xls;
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
        public List<string> AnalyzeShipData(string filePath)
        {
            //载入xls文档
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(filePath);
            //获取第一张工作表
            Worksheet sheet = workbook.Worksheets[0];

            var cell = sheet.Rows[0].Cells.First();

            //保存为csv格式
            sheet.SaveToFile(@"C:\Users\王志偉\Desktop\123.csv", ",", Encoding.UTF8);

            var result = new List<string>();
            FileStream fs = new FileStream(@"C:\Users\王志偉\Desktop\123.csv", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
          
            //記錄每行記錄中的各字段內容
            bool IsFirst = true;
            while (!sr.EndOfStream)
            {
                if (IsFirst == true)
                {
                    IsFirst = false;
                }
                else
                {
                    var line = sr.ReadLine();
                    result.Add(line);
                }
            }


            sr.Dispose();
            fs.Dispose();


            return result;
        }
    }
}
