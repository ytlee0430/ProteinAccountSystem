using Common.Entity;
using System.Collections.Generic;

namespace Common.Interface.Service
{
    public interface IAnalyzeExcelService
    {
        List<PhuraseDetailModel> AnalyzeShipData(string filePath);
    }
}