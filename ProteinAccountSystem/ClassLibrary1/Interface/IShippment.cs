﻿using CommonUtility.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Interface
{
    public interface IShippment
    {
        /// <summary>
        /// 產生寄件單
        /// </summary>
        FileStream CreateShippmentTicket(PhuraseProductModel model);

        /// <summary>
        /// 批量產生寄件單
        /// </summary>
        FileStream CreateShippmentTicket(List<PhuraseProductModel> model);
    }
}
