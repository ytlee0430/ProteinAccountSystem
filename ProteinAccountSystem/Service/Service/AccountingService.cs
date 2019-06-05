using AutoMapper;
using CodeFirstORM.DBLayer;
using CodeFirstORM.Entity;
using Common.Entity;
using Common.Interface.Service;
using System.Collections.Generic;

namespace Service.Service
{
    public class AccountingService : IAccountingService
    {
        public bool UpdateSalesRecords(List<PhuraseDetailModel> details)
        {
            var repo = new PhuraseDetailRepository();
            return repo.Update(Mapper.Map<List<PhuraseDetailEntity>>(details));
        }

        /// <summary>
        /// 取得匯入帳號訂單號碼，將銷帳紀錄改為已銷帳
        /// </summary>
        /// <returns></returns>
        public bool WriteOffMoney(List<string> orderNumbers)
        {
            var repo = new PhuraseDetailRepository();
            return repo.Update(r => orderNumbers.Contains(r.OrderNumber), u => new PhuraseDetailEntity { IsWriteOffMoney = true });
        }
    }
}