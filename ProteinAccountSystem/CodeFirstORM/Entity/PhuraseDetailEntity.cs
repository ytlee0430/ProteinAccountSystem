using CodeFirstORM.RepositoryBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstORM.Entity
{
    public class PhuraseDetailEntity : IEntity
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
        public virtual ICollection<PhuraseProductEntity> Products { get; set; }

        /// <summary>
        /// 運費(未稅)
        /// </summary>
        public int TransferMoneyWithoutTax { get; set; }

        /// <summary>
        /// 總稅金
        /// </summary>
        public int TotalTax { get; set; }
        
        /// <summary>
        /// 小計  稅前單價*數量
        /// </summary>
        public int SubMoney { get; set; }
     
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

        /// <summary>
        /// 是否銷帳
        /// </summary>
        public bool IsWriteOffMoney { get; set; } = false;

        /// <summary>
        /// 銷售時間(訂單成立時間)
        /// </summary>
        [Required]
        public DateTime OrderCreateTime { get; set; }

        /// <summary>
        /// 經手人
        /// </summary>
        public string Manager { get; set; }

        /// <summary>
        /// 公司抬頭
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 公司統一編號
        /// </summary>
        public string CompanyInvoiceNumber { get; set; }

        /// <summary>
        /// 銷帳時間
        /// </summary>
        public DateTime? WriteOffMoneyTime { get; set; }
    }
}