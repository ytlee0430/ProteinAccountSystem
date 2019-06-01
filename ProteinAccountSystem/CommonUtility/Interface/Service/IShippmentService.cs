using System.Collections.Generic;
using Common.Entity;

namespace Common.Interface.Service
{
    public interface IShippmentService
    {
        /// <summary>
        /// 產生寄件單
        /// </summary>
        bool CreateShippmentTicket(List<PhuraseDetailModel> models,string path);
    }
}
