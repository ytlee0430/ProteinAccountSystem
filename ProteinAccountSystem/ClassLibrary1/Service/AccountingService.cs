using CodeFirstORM;
using CodeFirstORM.DBLayer;
using CommonUtility.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Service
{
    public class AccountingService
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
                var ordernum = item.OrderNumber;

                Expression<Func<PhuraseDetailEntity, bool>> itemWhere = c => true;

                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.OrderNumber == item.OrderNumber;
                var a = repo.GetList(itemWhere).First();
                a.IsWriteOffMoney = true;
                result.Add(a);
            }

            return repo.UpdateItems(result);
        }


    }
}
