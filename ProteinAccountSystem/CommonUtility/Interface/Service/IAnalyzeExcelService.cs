using System.Collections.Generic;
using ProteinSystem.Entity;

namespace ProteinSystem.Interface.Service
{
    public interface IAnalyzeExcelService
    {
        List<PhuraseDetailModel> AnalyzeShipData(string filePath);
    }
}