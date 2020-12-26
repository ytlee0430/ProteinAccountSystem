using System;

namespace ProteinSystem.Entity
{
    public class Item
    {
        public int Key { get; set; }

        /// <summary>
        /// 庫存
        /// </summary>
        public int Storage { get; set; }

        /// <summary>
        /// 商品編號
        /// </summary>
        public string ItemCode { get; set; }

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
        /// 商品訂價
        /// </summary>
        public int NetPrice { get; set; }

        /// <summary>
        /// in precentage
        /// </summary>
        public double Discount { get; set; }

        /// <summary>
        /// 商品成本
        /// </summary>
        public int Cost { get; set; }

        /// <summary>
        /// 稅金
        /// </summary>
        public int Tax { get; set; }

        /// <summary>
        /// 保存期限
        /// </summary>
        public DateTime ExpiredDate { get; set; }
    }
}