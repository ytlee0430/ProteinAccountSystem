using System.Collections.Generic;
using ProteinSystem.Entity;

namespace ProteinSystem.Interface.Service
{
    public interface IShippmentService
    {
        /// <summary>
        /// 產生寄件單
        /// </summary>
        bool CreateShippmentTicket(List<PhuraseDetailModel> models, string path);
    }
}