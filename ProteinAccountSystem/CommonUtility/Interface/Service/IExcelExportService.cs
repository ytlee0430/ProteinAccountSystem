using System.Collections.Generic;

namespace Common.Interface.Service
{
    public interface IExcelExportService
    {
        bool ExportExcel<T>(IEnumerable<T> list, string path) where T : class;
    }
}