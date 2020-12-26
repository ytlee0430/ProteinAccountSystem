﻿using System;
using System.Collections.Generic;
using System.Reflection;
using ProteinSystem.Entity;
using ProteinSystem.Interface.Service;
using ProteinSystem.Log;
using MSWord = Microsoft.Office.Interop.Word;

namespace ProteinSystem.Service.Service
{
    public class ShippmentService : IShippmentService
    {
        public bool CreateShippmentTicket(List<PhuraseDetailModel> models, string path)
        {
            MSWord.Application wordApp = new MSWord.Application();
            //Word應用程序變量
            MSWord.Document wordDoc;//Word文檔變量
            object savePath = path;//路徑變數 ，需使用object
            //初始化
            try
            {
                var result = models;
                wordApp.Visible = false;
                Object nothing = Missing.Value;
                wordDoc = wordApp.Documents.Add(ref nothing, ref nothing, ref nothing, ref nothing);
                //頁面設置
                wordDoc.PageSetup.PaperSize = MSWord.WdPaperSize.wdPaperA5;//設置紙張樣式為A5紙
                wordDoc.PageSetup.Orientation = MSWord.WdOrientation.wdOrientPortrait;//排列方式為垂直方向
                wordDoc.PageSetup.TopMargin = 10.0f;
                wordDoc.PageSetup.BottomMargin = 10.0f;
                wordDoc.PageSetup.LeftMargin = 15.0f;
                wordDoc.PageSetup.RightMargin = 15.0f;
                wordDoc.PageSetup.HeaderDistance = 30.0f;//頁眉位置
                //var strContent = "";
                wordApp.Selection.ParagraphFormat.LineSpacing = 20f;//设置文档的行间距

                foreach (var item in result)
                {
                    var strContent = "";
                    strContent += "                  送貨單-列印時間:" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "\n";
                    strContent += "=============================" + "\n";
                    strContent += "帳號:" + item.Account + "  收件人:" + item.RecipientName+"\n";   //TODO: ADD NAME
                    strContent += "訂單編號 :" + item.OrderNumber + "  寄件編號 :" + item.DeliveryNumber + "\n";
                    strContent += "發票號碼 :" + item.ReceiptNumber + "\n";
                    strContent += "詳細項目:" + "\n";
                    strContent += ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>" + "\n";
                    var index = 1;
                    foreach (var product in item.Products)
                    {
                        strContent += index + "." + product.ProductName + "\n" + "數量:" + product.Count + "    " + "金額:" + product.ProductMoney + "\n";
                        index++;
                    }

                    strContent += index + "." + "運費" + "\n" + "數量:" + "1" + "    " + "金額:" + item.TransferMoney + "\n";
                    strContent += ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>" + "\n";
                    strContent += "訂單總額:" + item.TotalMoney + "\n";
                    strContent += "備註:" + item.Remark + "\n";
                    strContent += "\n" + "----------------------------------------" + "\n";
                    wordDoc.Paragraphs.Last.Range.Text = strContent;
                    wordDoc.Words.Last.InsertBreak(MSWord.WdBreakType.wdPageBreak);
                }
                //WdSaveFormat為Word 2003文檔的保存格式 // office 2007就是wdFormatDocumentDefault
                object format = MSWord.WdSaveFormat.wdFormatDocument;
                //將wordDoc文檔對象的內容保存為DOCX文檔
                wordDoc.SaveAs(ref savePath, ref format, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing);

                wordDoc.Close(ref nothing, ref nothing, ref nothing);
                //關閉wordApp組件對象
                wordApp.Quit(ref nothing, ref nothing, ref nothing);
            }
            catch (Exception e)
            {
                LogUtil.Error(e.StackTrace);
                LogUtil.Error(e.ToString());
                LogUtil.Error("CreateShippmentTicket Fail!");
                return false;
            }
            return true;
        }
    }
}