﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Common.Entity
{
    public class PhuraseDetailModel
    {
        public int Key { get; set; }

        /// <summary>
        /// 訂單編號
        /// </summary>
        [DisplayName("訂單編號")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// 購買帳號
        /// </summary>
        [DisplayName("購買帳號")]
        public string Account { get; set; }

        /// <summary>
        /// 寄送編號
        /// </summary>
        [DisplayName("寄送編號")]
        public string DeliveryNumber { get; set; }

        /// <summary>
        /// 運費(含稅)
        /// </summary>
        [DisplayName("運費(含稅)")]
        public int TransferMoney { get; set; }

        /// <summary>
        /// 購買商品
        /// </summary>
        [DisplayName("購買商品")]
        public List<PhuraseProductModel> Products { get; set; }

        /// <summary>
        /// 運費(未稅)
        /// </summary>
        [DisplayName("運費(未稅)")]
        public int TransferMoneyWithoutTax { get; set; }

        /// <summary>
        /// 總稅金
        /// </summary>
        [DisplayName("總稅金")]
        public int TotalTax { get; set; }

        /// <summary>
        /// 訂單金額
        /// </summary>
        [DisplayName("訂單金額")]
        public int TotalMoney { get; set; }

        /// <summary>
        /// 購買平台
        /// </summary>
        [DisplayName("購買平台")]
        public int Plat { get; set; } = 1;

        /// <summary>
        /// 備註
        /// </summary>
        [DisplayName("備註")]
        public string Remark { get; set; }

        /// <summary>
        /// 發票號碼
        /// </summary>
        [DisplayName("發票號碼")]
        public string ReceiptNumber { get; set; }

        /// <summary>
        /// 是否銷帳
        /// </summary>
        [DisplayName("是否銷帳")]
        public bool IsWriteOffMoney { get; set; } = false;

        /// <summary>
        /// 銷售時間(訂單成立時間)
        /// </summary>
        [DisplayName("銷售時間(訂單成立時間)")]
        public DateTime OrderCreateTime { get; set; }

        /// <summary>
        /// 經手人
        /// </summary>
        [DisplayName("經手人")]
        public string Manager { get; set; }

        /// <summary>
        /// 公司抬頭
        /// </summary>
        [DisplayName("公司抬頭")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 公司統一編號
        /// </summary>
        [DisplayName("公司統一編號")]
        public string CompanyInvoiceNumber { get; set; }
    }
}