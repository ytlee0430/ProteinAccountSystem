using System;
using System.Collections.Generic;
using Common.Interface.Service;
using CommonUtility.Utils;
using Spire.Xls;

namespace Service.Service
{
    public class ExcelExportService : IExcelExportService
    {
        public bool ExportExcel<T>(IEnumerable<T> list, string path)
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
                return false;
            }
            return true;
        }
    }
}
