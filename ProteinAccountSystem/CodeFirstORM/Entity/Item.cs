using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstORM
{
    public class ItemEntity
    {
        [Key]
        public int Key{ get; set; }

        /// <summary>
        /// 庫存
        /// </summary>
        public int Storage { get; set; }

        /// <summary>
        /// 商品編號
        /// </summary>
        public int ItemCode { get; set; }

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

    }
}
