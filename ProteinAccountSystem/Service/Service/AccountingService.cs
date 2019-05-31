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
        public bool WriteOffMoney(List<PhuraseDetailModel> models)
        {
            var repo = new PhuraseDetailRepository();
            var result = new List<PhuraseDetailModel>();
            foreach (var item in models)
            {
                var detail = repo.Get(c=>c.OrderNumber == item.OrderNumber).First();
                detail.IsWriteOffMoney = true;
                result.Add(Mapper.Map<PhuraseDetailModel>(detail));
            }

            return repo.Update(Mapper.Map<List<PhuraseDetailEntity>>(result));
        }

    }
}
