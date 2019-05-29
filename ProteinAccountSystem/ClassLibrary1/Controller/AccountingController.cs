using CommonUtility.Entity;
using Controller.Interface;
using Controller.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AccountingController : IAccountingController
    {
        private ImportExcelSevice _ImportExcelSevice;
        private AccountingService _accountingservice;
        public AccountingController()
        {
            _ImportExcelSevice = new ImportExcelSevice();
            _accountingservice = new AccountingService();
        }
        /// <summary>
        /// 銷帳流程
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool importWirteOffMoneyDataProcess(string path)
        {
            var datas = _ImportExcelSevice.AnalyzeShipData(path);
            return WriteOffMoney(datas);
        }

        /// <summary>
        /// 將匯入的excel  銷帳
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public bool WriteOffMoney(List<PhuraseDetailModel> models)
        {
            return _accountingservice.WriteOffMoney(models);
        }
    }
}
