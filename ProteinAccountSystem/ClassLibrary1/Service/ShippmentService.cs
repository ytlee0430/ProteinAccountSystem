using CommonUtility.Entity;
using Controller.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Service
{
    public class ShippmentService : IShippment
    {
        public FileStream CreateShippmentTicket(PhuraseProductModel model)
        {
            throw new NotImplementedException();
        }

        public FileStream CreateShippmentTicket(List<PhuraseProductModel> model)
        {
            throw new NotImplementedException();
        }
    }
}
