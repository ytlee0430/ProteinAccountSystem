using System;

namespace Common.Entity
{
    public class SearchModel
    {
        /// <summary>
        /// 商品口味
        /// </summary>
        public int Flavor { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        public int Brand { get; set; }

        /// <summary>
        /// 商品分類
        /// </summary>
        public int ProductionType { get; set; }

        /// <summary>
        /// 商品細項分類
        /// </summary>
        public int ProductionDetailType { get; set; }

        /// <summary>
        /// 包裝
        /// </summary>
        public int Package { get; set; }

        /// <summary>
        /// 起始時間
        /// </summary>
        public DateTime SaleStartTime { get; set; } = DateTime.MinValue;

        /// <summary>
        /// 結束時間
        /// </summary>
        public DateTime SaleEndTime { get; set; } = DateTime.MaxValue;

        /// <summary>
        /// -1全部 0未銷帳 1已銷帳
        /// </summary>
        public int IsWriteOffMoney { get; set; } = -1;

        /// <summary>
        /// 帳號/姓名
        /// </summary>
        public string KeyWord { get; set; }

        /// <summary>
        /// 銷帳起始時間
        /// </summary>
        public DateTime WriteOffMoneyStartTime { get; set; } = DateTime.MinValue;
        /// <summary>
        /// 銷帳結束時間
        /// </summary>
        public DateTime WriteOffMoneyEndTime { get; set; } = DateTime.MaxValue;
        
        /// <summary>
        /// 發票號碼
        /// </summary>
        public string receiptNumber { get; set; }
    }
}