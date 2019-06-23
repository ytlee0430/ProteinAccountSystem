using Common.Entity;
using Common.Interface.Service;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Linq;
using Common.Enum;
using Common.Utils;

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
            var count = 0;
            var deliveryIndex = 0;
            var itemIndex = 0;
            var flavorIndex = 0;
            var productPriceIndex = 0;
            var productSalePriceIndex = 0;
            var orderStataIndex = 0;
            for (int i = 0; i < sheet.Rows[0].Cells.Count(); i++)
            {
                if (sheet.Rows[0].Cells[i].DisplayedText == "數量")
                    count = i;
                if (sheet.Rows[0].Cells[i].DisplayedText == "包裹查詢號碼 (單)")
                    deliveryIndex = i;

                if (sheet.Rows[0].Cells[i].DisplayedText == "商品名稱 (品)")
                    itemIndex = i;

                if (sheet.Rows[0].Cells[i].DisplayedText == "商品選項名稱 (品)")
                    flavorIndex = i;

                if (sheet.Rows[0].Cells[i].DisplayedText == "商品原價 (品)")
                    productPriceIndex = i;

                if (sheet.Rows[0].Cells[i].DisplayedText == "商品活動價格 (品)")
                    productSalePriceIndex = i;

                if (sheet.Rows[0].Cells[i].DisplayedText == "訂單狀態 (單)")
                    orderStataIndex = i;
            }

            for (int i = 1; i < sheet.Rows.Count(); i++)
            {
                var cells = sheet.Rows[i].Cells;
                if (string.IsNullOrEmpty(cells[0].DisplayedText))
                    break;
                var data = new PhuraseDetailModel();
                data.OrderNumber = cells[0].DisplayedText;

                data.OrderState = (OrderState)cells[orderStataIndex].DisplayedText.ConvertDescriptionToEnum(OrderState.待出貨);

                //[現貨] 英國官方授權經銷 MYPROTEIN 濃縮乳清蛋白 2.5 KG  開立發票、紙箱包裝  台肌店-口味:藍莓起司蛋糕
                var name = string.IsNullOrEmpty(cells[flavorIndex].DisplayedText) ? cells[itemIndex].DisplayedText + "-口味:無口味" : cells[itemIndex].DisplayedText + "-口味:" + cells[flavorIndex].DisplayedText;
                var productPrice = string.IsNullOrEmpty(cells[productSalePriceIndex].DisplayedText) ? cells[productPriceIndex].DisplayedText : cells[productSalePriceIndex].DisplayedText;

                if (!result.TryGetValue(data.OrderNumber, out var currenData))
                {
                    data.Account = cells[3].DisplayedText;
                    data.OrderCreateTime = Convert.ToDateTime(cells[4].DisplayedText);
                    Double.TryParse(cells[6].DisplayedText, out Double money);
                    data.TransferMoney = (int)money;
                    data.TotalMoney = Convert.ToInt32(Convert.ToDouble(cells[7].DisplayedText));
                    data.TotalTax = Convert.ToInt32(Convert.ToDouble(cells[7].DisplayedText) * 0.05);
                    data.TransferMoneyWithoutTax = Convert.ToInt32(Convert.ToDouble(cells[6].DisplayedText) / 1.05);
                    data.SubMoney = Convert.ToInt32(Convert.ToDouble(cells[5].DisplayedText) / 1.05) * Convert.ToInt32(cells[count].DisplayedText);

                    data.Products = new List<PhuraseProductModel>(){
                        new PhuraseProductModel()
                    {
                        ProductName=name, // 需要再蝦皮編輯商品貨號
                        Count=Convert.ToInt32(cells[count].DisplayedText),
                        ProductMoney=Convert.ToInt32(Convert.ToDouble( productPrice)),
                        ProductMoneyWithoutTax=Convert.ToInt32( Convert.ToDouble( productPrice)/1.05),
                    } };
                    data.DeliveryNumber = cells[deliveryIndex].DisplayedText;
                    var remark = string.IsNullOrEmpty(cells[44].DisplayedText) ? string.Empty : $"買家:{cells[44].DisplayedText} ;";
                    remark = string.IsNullOrEmpty(cells[45].DisplayedText) ? remark : $"{remark}賣家:{cells[45].DisplayedText}";
                    data.Remark = remark;
                    result.Add(data.OrderNumber, data);
                }
                else
                {
                    currenData.Products.Add(new PhuraseProductModel()
                    {
                        ProductName = name, // 需要再蝦皮編輯商品貨號
                        Count = Convert.ToInt32(Convert.ToDouble(cells[count].DisplayedText)),
                        ProductMoney = Convert.ToInt32(Convert.ToDouble(productPrice)),
                        ProductMoneyWithoutTax = Convert.ToInt32(Convert.ToDouble(productPrice) / 1.05),
                    });
                }
            }
            return result.Values.ToList();
        }
    }
}