using CodeFirstORM.DBLayer;
using CommonUtility.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Service
{
    public class AccountingService
    {

        public bool WriteOffMoney(List<PhuraseDetailModel> models)
        {
            var repo = new PhuraseDetailRepository();
            return repo.AddItems(stockData);
        }


    }
}
