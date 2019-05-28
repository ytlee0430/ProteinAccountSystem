using CommonUtility.Entity;
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
        public List<PhuraseDetailModel> AnalyzeShipData(string filePath)
        {
            var result = new Dictionary<string, PhuraseDetailModel>();

            //载入xls文档
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(filePath);
            //获取第一张工作表
            Worksheet sheet = workbook.Worksheets[0];

            var cell = sheet.Rows[1].Cells.First();

            for (int i = 2; i < sheet.Rows.Count(); i++)
            {
                var cells = sheet.Rows[i].Cells;
                var data = new PhuraseDetailModel();
                data.OrderNumber = cells[0].DisplayedText;

                if (!result.TryGetValue(data.OrderNumber, out var currenData))
                {
                    data.Account = cells[3].DisplayedText;
                    data.TransferMoney = Convert.ToInt32(Convert.ToDouble(cells[6].DisplayedText));
                    data.TotalMoney = Convert.ToInt32(Convert.ToDouble(cells[7].DisplayedText));
                    //TODO: 稅應該是*0.05吧 
                    data.TotalTax = Convert.ToInt32(Convert.ToDouble(cells[7].DisplayedText) / 1.05);
                    data.TransferMoneyWithoutTax = Convert.ToInt32(Convert.ToDouble(cells[6].DisplayedText) / 1.05);
                    data.Products = new List<PhuraseProductModel>(){
                    new PhuraseProductModel()
                    {
                        ProductName=cells[23].DisplayedText, // 需要再蝦皮編輯商品貨號 
                        Count=Convert.ToInt32(Convert.ToDouble( cells[24].DisplayedText)),
                        ProductMoney=Convert.ToInt32(Convert.ToDouble( cells[5].DisplayedText)),
                        ProductMoneyWithoutTax=Convert.ToInt32( Convert.ToDouble(cells[5].DisplayedText)/1.05),
                        //ItemCode=cells[22].ToString()+cells[23].ToString()
                    } };
                    data.DeliveryNumber = cells[40].DisplayedText;
                    data.Remark = "買家備註:" + cells[44].DisplayedText + "單備註" + cells[45].DisplayedText;
                    result.Add(data.OrderNumber, data);
                }
                else
                {
                    currenData.Products.Add(new PhuraseProductModel()
                    {
                        ProductName = cells[23].DisplayedText, // 需要再蝦皮編輯商品貨號 
                        Count = Convert.ToInt32(Convert.ToDouble(cells[24].DisplayedText)),
                        ProductMoney = Convert.ToInt32(Convert.ToDouble(cells[5].DisplayedText)),
                        ProductMoneyWithoutTax = Convert.ToInt32(Convert.ToDouble(cells[5].DisplayedText) / 1.05),
                        //ItemCode=cells[22].ToString()+cells[23].ToString()
                    });
                }
            }
            return result.Values.ToList();
        }
    }
}
