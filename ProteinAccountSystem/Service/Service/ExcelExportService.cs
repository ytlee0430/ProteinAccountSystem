using Common.Interface.Service;
using CommonUtility.Utils;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Common.Log;

namespace Service.Service
{
    public class ExcelExportService : IExcelExportService
    {
        public bool ExportExcel<T>(IEnumerable<T> list, string path) where T : class
        {
            try
            {
                Workbook book = new Workbook();
                Worksheet sheet = book.Worksheets[0];
                var dataTable = list.ToDataTable<T>();
                sheet.InsertDataTable(dataTable, true, 1, 1);
                book.SaveToFile(path, ExcelVersion.Version2013);
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex.StackTrace);
                LogUtil.Error(ex.ToString());
                LogUtil.Error($"Export Excel Error! Type:{list.GetType()}");
                return false;
            }
            return true;
        }
    }
}