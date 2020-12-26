using System.ComponentModel;

namespace ProteinSystem.Entity
{
    public class PhuraseProductViewModel
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
        /// 包裝
        /// </summary>
        [DisplayName("包裝")]
        public string Package { get; set; }

        /// <summary>
        /// 商品細項分類
        /// </summary>
        [DisplayName("商品細項分類")]
        public string ProductionDetailType { get; set; }
    }
}