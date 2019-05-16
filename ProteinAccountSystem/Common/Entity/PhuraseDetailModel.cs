﻿using Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Common.Entity
{
    public class PhuraseDetailModel
    {
        /// <summary>
        /// 訂單編號
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// 購買帳號
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 寄送編號
        /// </summary>
        public string DeliveryNumber { get; set; }

        /// <summary>
        /// 運費(含稅)
        /// </summary>
        public int TransferMoney { get; set; }

        /// <summary>
        /// 購買商品
        /// </summary>
        public List<PhuraseProductModel> Products { get; set; }


        /// <summary>
        /// 運費(未稅)
        /// </summary>
        public int TransferMoneyWithoutTax { get; set; }

        /// <summary>
        /// 總稅金
        /// </summary>
        public int TotalTax { get; set; }

        /// <summary>
        /// 訂單金額
        /// </summary>
        public int TotalMoney { get; set; }

        /// <summary>
        /// 購買平台    
        /// </summary>
        public PlatEnum Plat { get; set; } = PlatEnum.Shopee;
    }
}
