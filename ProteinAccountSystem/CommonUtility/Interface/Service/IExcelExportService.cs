using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entity;

namespace Common.Interface.Service
{
    public interface IExcelExportService
    {
        bool ExportExcel<T>(IEnumerable<T> list, string path);
    }
}
