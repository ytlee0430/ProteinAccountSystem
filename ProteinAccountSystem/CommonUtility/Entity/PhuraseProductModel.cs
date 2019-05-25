using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtility.Entity
{
    public class PhuraseProductModel
    {

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

    }
}
