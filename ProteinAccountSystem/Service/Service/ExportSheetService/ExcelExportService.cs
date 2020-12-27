using System;
using System.Collections.Generic;
using ProteinSystem.Interface.Service;
using ProteinSystem.Log;
using ProteinSystem.Utils;
using Spire.Xls;

namespace ProteinSystem.Service.Service.ExportSheetService
{
    public class ExportSheetService : IExportSheetService
    {
        public bool ExportExcel<T>(IEnumerable<T> list, string path) where T : class
        {
            try
            {
                Workbook book = new Workbook();
                Worksheet sheet = book.Worksheets[0];

                var dataTable = list.ToDisplayDataTable();
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