using CommonUtility.Entity;
using Controller.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSWord = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace Controller.Service
{
    public class ShippmentService : IShippment
    {
        //Word應用程序變量 
        MSWord.Document wordDoc;                  //Word文檔變量
        MSWord.Application wordApp = new MSWord.Application();//初始化

        //TODO: 路徑要給
        object _savePath = "";//路徑變數 ，需使用object

        public bool CreateShippmentTicket(List<PhuraseDetailModel> models)
        {
            //TODO: 例外處理

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

            foreach (var item in result)
            {
                wordDoc.Paragraphs.Last.Range.Font.Size = 15;
                var strContent = item.Account + "\n";
                //wordApp.Selection.EndKey(ref unite, ref Nothing);
                foreach (var product in item.Products)
                {
                    strContent += product.ProductName + "       " + " 數量 : " + product.Count + "\n";
                }
                strContent += "寄件編號 :" + item.DeliveryNumber;
                //wordDoc.Paragraphs.Last.Range.Font.Name = "新細明體";
                wordDoc.Paragraphs.Last.Range.Text = strContent;
            }

            //WdSaveFormat為Word 2003文檔的保存格式 // office 2007就是wdFormatDocumentDefault
            object format = MSWord.WdSaveFormat.wdFormatDocument;
            //將wordDoc文檔對象的內容保存為DOCX文檔
            wordDoc.SaveAs(ref _savePath, ref format, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
            //關閉wordDoc文檔對象

            //列印
            //wordDoc.PrintOut();

            wordDoc.Close(ref Nothing, ref Nothing, ref Nothing);
            //關閉wordApp組件對象
            wordApp.Quit(ref Nothing, ref Nothing, ref Nothing);


            return true;
        }

        private List<PhuraseDetailModel> GetPhuraseDetailModels(List<string> model)
        {
            return null;
        }
    }
}
