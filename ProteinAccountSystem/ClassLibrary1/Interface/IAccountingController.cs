using CommonUtility.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Interface
{
    public interface IAccountingController
    {
        bool WriteOffMoney(List<PhuraseDetailModel> models);

    }
}
