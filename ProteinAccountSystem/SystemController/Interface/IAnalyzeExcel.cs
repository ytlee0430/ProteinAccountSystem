﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemController.Interface
{
    public interface IAnalyzeExcel
    {
        void AnalyzeShipData(string filePath);
    }
}