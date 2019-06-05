using Common.Entity;
using Common.Interface.Service;
using System;
using System.Collections.Generic;
using System.Reflection;
using Common.Log;
using MSWord = Microsoft.Office.Interop.Word;

namespace Service.Service
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
                Object Nothing = Missing.Value;
                wordDoc = wordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                //頁面設置
                wordDoc.PageSetup.PaperSize = MSWord.WdPaperSize.wdPaperA4;//設置紙張樣式為A4紙
                wordDoc.PageSetup.Orientation = MSWord.WdOrientation.wdOrientPortrait;//排列方式為垂直方向
                wordDoc.PageSetup.TopMargin = 57.0f;
                wordDoc.PageSetup.BottomMargin = 57.0f;
                wordDoc.PageSetup.LeftMargin = 57.0f;
                wordDoc.PageSetup.RightMargin = 57.0f;
                wordDoc.PageSetup.HeaderDistance = 30.0f;//頁眉位置
                object unite = MSWord.WdUnits.wdStory;
                var strContent = "";
                wordDoc.Paragraphs.Last.Range.Font.Size = 15;
                foreach (var item in result)
                {
                    strContent += "帳號:" + item.Account + "\n";
                    foreach (var product in item.Products)
                    {
                        strContent += product.ProductName + "       " + " 數量 : " + product.Count + "\n";
                    }
                    strContent += "寄件編號 :" + item.DeliveryNumber + "\n";
                    strContent += "--------------------------------------------------------------------------------------------------------" + "\n";
                }
                wordDoc.Paragraphs.Last.Range.Text = strContent;

                //WdSaveFormat為Word 2003文檔的保存格式 // office 2007就是wdFormatDocumentDefault
                object format = MSWord.WdSaveFormat.wdFormatDocument;
                //將wordDoc文檔對象的內容保存為DOCX文檔
                wordDoc.SaveAs(ref savePath, ref format, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);

                wordDoc.Close(ref Nothing, ref Nothing, ref Nothing);
                //關閉wordApp組件對象
                wordApp.Quit(ref Nothing, ref Nothing, ref Nothing);
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