using CommonUtility.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Interface
{
    public interface ICreateSaleController
    {
       void AddPhuraseProduct(Item model);

        List<PhuraseDetailModel> CreateSale();
    }
}
