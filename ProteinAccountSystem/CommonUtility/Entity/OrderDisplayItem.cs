using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enum;


namespace Common.Entity
{
    public class OrderDisplayItem
    {
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
        public int Price { get; set; }

        /// <summary>
        /// 幾個
        /// </summary>
        public int Count { get; set; }
    }
}
