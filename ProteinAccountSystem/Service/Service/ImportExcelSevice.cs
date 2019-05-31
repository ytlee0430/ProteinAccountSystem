using System;
using System.Collections.Generic;
using System.Linq;
using Common.Entity;
using Common.Interface.Service;
using Spire.Xls;

namespace Service.Service
{
    public class AnalyzeShopeeExcelSevice : IAnalyzeExcelService
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

            for (int i = 1; i < sheet.Rows.Count(); i++)
            {
                var cells = sheet.Rows[i].Cells;
                if (string.IsNullOrEmpty(cells[0].DisplayedText))
                    break;
                var data = new PhuraseDetailModel();
                data.OrderNumber = cells[0].DisplayedText;
                //[現貨] 英國官方授權經銷 MYPROTEIN 濃縮乳清蛋白 2.5 KG  開立發票、紙箱包裝  台肌店-口味:藍莓起司蛋糕
                var name = string.IsNullOrEmpty(cells[19].DisplayedText) ? cells[18].DisplayedText + "-口味:無口味" : cells[18].DisplayedText + "-口味:" + cells[19].DisplayedText;
                if (!result.TryGetValue(data.OrderNumber, out var currenData))
                {
                    data.Account = cells[3].DisplayedText;
                    data.OrderCreateTime = Convert.ToDateTime(cells[4].DisplayedText);
                    Double.TryParse(cells[6].DisplayedText, out Double money);
                    data.TransferMoney = (int)money;
                    data.TotalMoney = Convert.ToInt32(Convert.ToDouble(cells[7].DisplayedText));
                    data.TotalTax = Convert.ToInt32(Convert.ToDouble(cells[7].DisplayedText) * 0.05);
                    data.TransferMoneyWithoutTax = Convert.ToInt32(Convert.ToDouble(cells[6].DisplayedText) / 1.05);
                    data.Products = new List<PhuraseProductModel>(){
                    new PhuraseProductModel()
                    {
                        ProductName=name, // 需要再蝦皮編輯商品貨號 
                        Count=Convert.ToInt32(cells[24].DisplayedText),
                        ProductMoney=Convert.ToInt32(Convert.ToDouble( cells[5].DisplayedText)),
                        ProductMoneyWithoutTax=Convert.ToInt32( Convert.ToDouble(cells[5].DisplayedText)/1.05),
                    } };
                    data.DeliveryNumber = cells[40].DisplayedText;
                    data.Remark = "買家備註:" + cells[44].DisplayedText + "單備註" + cells[45].DisplayedText;
                    result.Add(data.OrderNumber, data);
                }
                else
                {
                    currenData.Products.Add(new PhuraseProductModel()
                    {
                        ProductName = name, // 需要再蝦皮編輯商品貨號 
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
