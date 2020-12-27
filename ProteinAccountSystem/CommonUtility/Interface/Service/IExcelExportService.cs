using System.Collections.Generic;

namespace ProteinSystem.Interface.Service
{
    public interface IExportSheetService
    {
        bool ExportExcel<T>(IEnumerable<T> list, string path) where T : class;
    }
}