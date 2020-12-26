using System.Collections.Generic;

namespace ProteinSystem.Entity.Dto
{
    public class SaleRecordPagingDto
    {
        public List<PhuraseDetailModel> Details { get; set; }
        public int TotalCount { get; set; }
    }
}