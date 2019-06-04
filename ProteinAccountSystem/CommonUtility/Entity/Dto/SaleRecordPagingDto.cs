using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entity;

namespace Common.Entity.Dto
{
    public class SaleRecordPagingDto
    {
        public List<PhuraseDetailModel> Details { get; set; }
        public int TotalCount { get; set; }
    }
}
