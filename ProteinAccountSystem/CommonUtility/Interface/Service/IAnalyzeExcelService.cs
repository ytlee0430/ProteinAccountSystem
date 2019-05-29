using System.Collections.Generic;
using Common.Entity;

namespace Common.Interface.Service
{
    public interface IAnalyzeExcelService
    {
        List<PhuraseDetailModel> AnalyzeShipData(string filePath);
    }
}
