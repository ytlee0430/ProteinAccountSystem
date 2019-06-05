using System.Collections.Generic;

namespace Common.Entity.Dto
{
    public class SaleRecordPagingDto
    {
        public List<PhuraseDetailModel> Details { get; set; }
        public int TotalCount { get; set; }
    }
}