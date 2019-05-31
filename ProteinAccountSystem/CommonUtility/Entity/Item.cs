using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enum;


namespace Common.Entity
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
        public FlavorEnum Flavor { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        public BrandEnum Brand { get; set; }

        /// <summary>
        /// 商品分類
        /// </summary>
        public ProductionType ProductionType { get; set; }

        /// <summary>
        /// 商品細項分類
        /// </summary>
        public ProductionDetail ProductionDetailType { get; set; }

        /// <summary>
        /// 包裝
        /// </summary>
        public PackageEnum Package { get; set; }

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
