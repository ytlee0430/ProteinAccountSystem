using System.ComponentModel;

namespace Common.Entity
{
    public class OrderDisplayItem
    {
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
        public int Price { get; set; }

        /// <summary>
        /// 幾個
        /// </summary>
        [DisplayName("商品數量")]
        public int Count { get; set; }
    }
}