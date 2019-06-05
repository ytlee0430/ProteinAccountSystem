using Common.Entity;
using System.Collections.Generic;

namespace Common.Interface.Service
{
    public interface IShippmentService
    {
        /// <summary>
        /// 產生寄件單
        /// </summary>
        bool CreateShippmentTicket(List<PhuraseDetailModel> models, string path);
    }
}