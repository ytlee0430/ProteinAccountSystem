using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using CodeFirstORM.DBLayer;
using CodeFirstORM.Entity;
using Common.Entity;
using Common.Interface.Service;

namespace Service.Service
{
    public class AccountingService : IAccountingService
    {
        /// <summary>
        /// 取得匯入帳號訂單號碼，將銷帳紀錄改為已銷帳
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public bool WriteOffMoney(List<string> orderNumbers)
        {
            var repo = new PhuraseDetailRepository();
            return repo.Update(r => orderNumbers.Contains(r.OrderNumber), u => new PhuraseDetailEntity { IsWriteOffMoney = true });
        }

        public bool WriteOffMoney(List<PhuraseDetailModel> details)
        {
            var repo = new PhuraseDetailRepository();
            return repo.Update(Mapper.Map<PhuraseDetailEntity>(details));
        }
    }
}
