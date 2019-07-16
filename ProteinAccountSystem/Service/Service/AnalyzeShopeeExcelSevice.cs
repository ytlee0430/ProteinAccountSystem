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
            int countIndex = 0;
            int deliveryIndex = 0;
            int itemIndex = 0;
            int flavorIndex = 0;
            int productPriceIndex = 0;
            int productSalePriceIndex = 0;
            int orderStataIndex = 0;
            int receiptNameIndex = 0;
            int customerRemarkIndex = 0;
            int salerRemarkIndex = 0;
            int orderNumberIndex = 0;
            int accountIndex = 0;
            int orderCreatimeIndex = 0;
            int shippingfFeeIndex = 0;
            int orderCostIndex = 0;
            int orderCostWithEventIndex = 0;

            for (int i = 0; i < sheet.Rows[0].Cells.Count(); i++)
            {
                switch (sheet.Rows[0].Cells[i].DisplayedText)
                {
                    case "訂單編號 (單)":
                        orderNumberIndex = i;
                        break;
                    case "買家帳號 (單)":
                        accountIndex = i;
                        break;
                    case "訂單成立時間 (單)":
                        orderCreatimeIndex = i;
                        break;
                    case "買家支付的運費 (單)":
                        shippingfFeeIndex = i;
                        break;
                    case "訂單小計 (單)":
                        orderCostIndex = i;
                        break;
                    case "訂單總金額 (單)":
                        orderCostWithEventIndex = i;
                        break;
                    case "數量":
                        countIndex = i;
                        break;
                    case "包裹查詢號碼 (單)":
                        deliveryIndex = i; ;
                        break;
                    case "商品名稱 (品)":
                        itemIndex = i;
                        break;
                    case "商品選項名稱 (品)":
                        flavorIndex = i;
                        break;
                    case "商品原價 (品)":
                        productPriceIndex = i;
                        break;
                    case "商品活動價格 (品)":
                        productSalePriceIndex = i;
                        break;
                    case "訂單狀態 (單)":
                        orderStataIndex = i;
                        break;
                    case "收件者姓名 (單)":
                        receiptNameIndex = i;
                        break;
                    case "買家備註 (單)":
                        customerRemarkIndex = i;
                        break;
                    case "備註 (單)":
                        salerRemarkIndex = i;
                        break;
                    default:
                        break;
                }
            }

            for (int i = 1; i < sheet.Rows.Count(); i++)
            {
                var cells = sheet.Rows[i].Cells;
                if (string.IsNullOrEmpty(cells[0].DisplayedText))
                    break;
                var data = new PhuraseDetailModel();
                data.OrderNumber = cells[orderNumberIndex].DisplayedText;

                data.OrderState = (OrderState)cells[orderStataIndex].DisplayedText.ConvertDescriptionToEnum(OrderState.待出貨);

                //[現貨] 英國官方授權經銷 MYPROTEIN 濃縮乳清蛋白 2.5 KG  開立發票、紙箱包裝  台肌店-口味:藍莓起司蛋糕
                var name = string.IsNullOrEmpty(cells[flavorIndex].DisplayedText) ? cells[itemIndex].DisplayedText + "-口味:無口味" : cells[itemIndex].DisplayedText + "-口味:" + cells[flavorIndex].DisplayedText;
                var productPrice = string.IsNullOrEmpty(cells[productSalePriceIndex].DisplayedText) ? cells[productPriceIndex].DisplayedText : cells[productSalePriceIndex].DisplayedText;

                if (!result.TryGetValue(data.OrderNumber, out var currenData))
                {
                    data.Account = cells[accountIndex].DisplayedText;
                    data.OrderCreateTime = Convert.ToDateTime(cells[orderCreatimeIndex].DisplayedText);
                    Double.TryParse(cells[shippingfFeeIndex].DisplayedText, out Double money);
                    data.TransferMoney = (int)money;
                    data.TotalMoney = Convert.ToInt32(Convert.ToDouble(cells[orderCostWithEventIndex].DisplayedText));
                    data.TotalTax = Convert.ToInt32(Convert.ToDouble(cells[orderCostWithEventIndex].DisplayedText) * 0.05);
                    data.TransferMoneyWithoutTax = Convert.ToInt32(Convert.ToDouble(cells[shippingfFeeIndex].DisplayedText) / 1.05);
                    data.SubMoney = Convert.ToInt32(Convert.ToDouble(cells[orderCostIndex].DisplayedText) / 1.05) * Convert.ToInt32(cells[countIndex].DisplayedText);

                    data.Products = new List<PhuraseProductModel>(){
                        new PhuraseProductModel()
                    {
                        ProductName=name, // 需要再蝦皮編輯商品貨號
                        Count=Convert.ToInt32(cells[countIndex].DisplayedText),
                        ProductMoney=Convert.ToInt32(Convert.ToDouble( productPrice)),
                        ProductMoneyWithoutTax=Convert.ToInt32( Convert.ToDouble( productPrice)/1.05),
                    } };
                    data.DeliveryNumber = cells[deliveryIndex].DisplayedText;
                    data.RecipientName = cells[receiptNameIndex].DisplayedText;

                    var remark = string.IsNullOrEmpty(cells[customerRemarkIndex].DisplayedText) ? string.Empty : $"買家:{cells[customerRemarkIndex].DisplayedText} ;";
                    remark = string.IsNullOrEmpty(cells[salerRemarkIndex].DisplayedText) ? remark : $"{remark}賣家:{cells[salerRemarkIndex].DisplayedText}";
                    data.Remark = remark;

                    result.Add(data.OrderNumber, data);
                }
                else
                {
                    currenData.Products.Add(new PhuraseProductModel()
                    {
                        ProductName = name, // 需要再蝦皮編輯商品貨號
                        Count = Convert.ToInt32(Convert.ToDouble(cells[countIndex].DisplayedText)),
                        ProductMoney = Convert.ToInt32(Convert.ToDouble(productPrice)),
                        ProductMoneyWithoutTax = Convert.ToInt32(Convert.ToDouble(productPrice) / 1.05),
                    });
                }
            }
            return result.Values.ToList();
        }
    }
}