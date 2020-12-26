using System.ComponentModel;

namespace ProteinSystem.Entity
{
    public class PhuraseProductModel
    {
        public int Key { get; set; }

        /// <summary>
        /// 商品編號
        /// </summary>
        [DisplayName("商品編號")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品名稱
        /// </summary>
        [DisplayName("商品名稱")]
        public string ProductName { get; set; }

        /// <summary>
        /// 購買數量
        /// </summary>
        [DisplayName("購買數量")]
        public int Count { get; set; }

        /// <summary>
        /// 商品售價(含稅)
        /// </summary>
        [DisplayName("商品售價(含稅)")]
        public int ProductMoney { get; set; }

        /// <summary>
        /// 商品售價(未稅)
        /// </summary>
        [DisplayName("商品售價(未稅)")]
        public int ProductMoneyWithoutTax { get; set; }

        /// <summary>
        /// 商品口味
        /// </summary>
        [DisplayName("商品口味")]
        public int Flavor { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        [DisplayName("商品品牌")]
        public int Brand { get; set; }

        /// <summary>
        /// 商品分類
        /// </summary>
        [DisplayName("商品分類")]
        public int ProductionType { get; set; }

        /// <summary>
        /// 包裝
        /// </summary>
        [DisplayName("包裝")]
        public int Package { get; set; }

        /// <summary>
        /// 商品細項分類
        /// </summary>
        [DisplayName("商品細項分類")]
        public int ProductionDetailType { get; set; }
    }
}