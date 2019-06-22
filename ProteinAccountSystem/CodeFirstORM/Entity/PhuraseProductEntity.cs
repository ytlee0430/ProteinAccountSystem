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
        [Required]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品名稱
        /// </summary>
        [Required]
        public string ProductName { get; set; }

        /// <summary>
        /// 購買數量
        /// </summary>
        [Required]
        public int Count { get; set; }

        /// <summary>
        /// 商品售價(含稅)
        /// </summary>
        [Required]
        public int ProductMoney { get; set; }

        /// <summary>
        /// 商品售價(未稅)
        /// </summary>
        [Required]
        public int ProductMoneyWithoutTax { get; set; }

        public int? PhuraseDetailEntityKey { get; set; }

        public virtual PhuraseDetailEntity PhuraseDetail { get; set; }

        /// <summary>
        /// 商品口味
        /// </summary>
        [Required]
        public int Flavor { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        [Required]
        public int Brand { get; set; }

        /// <summary>
        /// 商品分類
        /// </summary>
        [Required]
        public int ProductionType { get; set; }

        /// <summary>
        /// 包裝
        /// </summary>
        [Required]
        public int Package { get; set; }

        /// <summary>
        /// 商品細項分類
        /// </summary>
        [Required]
        public int ProductionDetailType { get; set; }
    }
}