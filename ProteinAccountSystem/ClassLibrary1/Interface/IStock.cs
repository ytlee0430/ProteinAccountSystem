﻿using CommonUtility.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Interface
{
    public interface IStock
    {
        bool UpdateDBStorage(List<PhuraseDetailModel> stockData);

        bool AddClientPhuraseRecord(List<PhuraseDetailModel> stockData);

        List<PhuraseDetailModel> GetPhuraseDetailModels(List<string> datas);
    }
}