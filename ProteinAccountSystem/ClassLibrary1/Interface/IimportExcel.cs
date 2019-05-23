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
        List<string> AnalyzeShipData(string filePath);
    }
}
