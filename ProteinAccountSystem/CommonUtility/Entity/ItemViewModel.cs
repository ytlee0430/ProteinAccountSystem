using System;
using System.ComponentModel;

namespace Common.Entity
{
    public class ItemViewModel
    {
        [DisplayName("Key")]
        public int Key { get; set; }

        /// <summary>
        /// 庫存
        /// </summary>
        [DisplayName("庫存")]
        public int Storage { get; set; }

        /// <summary>
        /// 商品編號
        /// </summary>
        [DisplayName("商品編號")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品口味
        /// </summary>
        [DisplayName("商品口味")]
        public string Flavor { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        [DisplayName("商品品牌")]
        public string Brand { get; set; }

        /// <summary>
        /// 商品分類
        /// </summary>
        [DisplayName("商品分類")]
        public string ProductionType { get; set; }

        /// <summary>
        /// 商品細項分類
        /// </summary>
        [DisplayName("商品細項分類")]
        public string ProductionDetailType { get; set; }

        /// <summary>
        /// 包裝
        /// </summary>
        [DisplayName("包裝")]
        public string Package { get; set; }

        /// <summary>
        /// 商品訂價
        /// </summary>
        [DisplayName("商品訂價")]
        public int NetPrice { get; set; }

        /// <summary>
        /// in precentage
        /// </summary>
        [DisplayName("折扣")]
        public double Discount { get; set; }

        /// <summary>
        /// 商品成本
        /// </summary>
        [DisplayName("商品成本")]
        public int Cost { get; set; }

        /// <summary>
        /// 稅金
        /// </summary>
        [DisplayName("稅金")]
        public int Tax { get; set; }

        /// <summary>
        /// 保存期限
        /// </summary>
        [DisplayName("保存期限")]
        public DateTime ExpiredDate { get; set; }
    }
}