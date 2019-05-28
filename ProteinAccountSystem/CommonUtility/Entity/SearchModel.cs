using CommonUtility.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtility.Entity
{
    public class SearchModel
    {
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
        /// 起始時間
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 結束時間
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// -1全部 0未銷帳 1已銷帳 
        /// </summary>
        public int IsWriteOffMoney { get; set; }
        
        /// <summary>
        /// 帳號/姓名
        /// </summary>
        public string KeyWord { get; set; }
    }
}
