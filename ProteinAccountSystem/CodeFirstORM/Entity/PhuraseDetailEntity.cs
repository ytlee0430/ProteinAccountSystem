
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstORM
{
    public class PhuraseDetailEntity
    {
        [Key]
        public int Key { get; set; }


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
        public string Products { get; set; }


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
        /// 購買平台 0:shopee 1:Rakuten
        /// </summary>
        public int Plat { get; set; } = 0;

        /// <summary>
        /// 備註
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 發票號碼
        /// </summary>
        public string ReceiptNumber { get; set; }
    }
}
