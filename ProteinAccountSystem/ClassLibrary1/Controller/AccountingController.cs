using CommonUtility.Entity;
using Controller.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AccountingController : IAccountingController
    {
        /// <summary>
        /// 將匯入的excel  銷帳
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public bool WriteOffMoney(List<PhuraseDetailModel> models)
        {
            throw new NotImplementedException();
        }
    }
}
