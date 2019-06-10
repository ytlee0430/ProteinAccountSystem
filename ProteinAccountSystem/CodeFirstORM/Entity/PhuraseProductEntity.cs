using CodeFirstORM.RepositoryBase;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstORM.Entity
{
    public class PhuraseProductEntity : IEntity
    {
        [Key]
        public int Key { get; set; }

        /// <summary>
        /// 商品編號
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品名稱
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 購買數量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 商品售價(含稅)
        /// </summary>
        public int ProductMoney { get; set; }

        /// <summary>
        /// 商品售價(未稅)
        /// </summary>
        public int ProductMoneyWithoutTax { get; set; }

        public int? PhuraseDetailEntityKey { get; set; }

        public PhuraseDetailEntity PhuraseDetail { get; set; }

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
        /// 包裝
        /// </summary>
        public int Package { get; set; }

        /// <summary>
        /// 商品細項分類
        /// </summary>
        public int ProductionDetailType { get; set; }
    }
}