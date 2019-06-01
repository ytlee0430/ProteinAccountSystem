using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entity
{
    public class ItemViewModel
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
        public string Flavor { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// 商品分類
        /// </summary>
        public string ProductionType { get; set; }

        /// <summary>
        /// 商品細項分類
        /// </summary>
        public string ProductionDetailType { get; set; }

        /// <summary>
        /// 包裝
        /// </summary>
        public string Package { get; set; }

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
