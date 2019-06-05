using Common.Entity;
using System.Collections.Generic;

namespace Common.Interface.Service
{
    public interface IAccountingService
    {
        bool UpdateSalesRecords(List<PhuraseDetailModel> details);

        /// <summary>
        /// 將匯入的excel  銷帳
        /// </summary>
        /// <returns></returns>
        bool WriteOffMoney(List<string> orderNumbers);
    }
}