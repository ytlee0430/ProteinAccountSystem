using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enum;

namespace Common.Entity
{
    public class Item
    {
        public int Storage { get; set; }

        public int ItemCode { get; set; }

        public FlavorEnum Flavor { get; set; }

        public BrandEnum Brand { get; set; }

        public ProductionType ProductionType { get; set; }

        public string Name { get; set; }

        public  int  FixedPrice{ get; set; }

        /// <summary>
        /// in precentage
        /// </summary>
        public double Discount { get; set; }
    }
}
