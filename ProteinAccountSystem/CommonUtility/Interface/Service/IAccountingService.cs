using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entity;

namespace Common.Interface.Service
{
    public interface IAccountingService
    {
        /// <summary>
        /// 將匯入的excel  銷帳
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        bool WriteOffMoney(List<string> orderNumbers);

        bool UpdateSalesRecords(List<PhuraseDetailModel> details);
    }
}
