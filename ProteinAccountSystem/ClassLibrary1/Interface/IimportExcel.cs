using CommonUtility.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Interface
{
    public interface IAnalyzeExcel
    {
        List<PhuraseDetailModel> AnalyzeShipData(string filePath);
    }
}
