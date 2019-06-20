using CodeFirstORM.Entity;
using CodeFirstORM.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace CodeFirstORM.DBLayer
{
    public class PhuraseDetailRepository : RepositoryBase<PhuraseDetailEntity>
    {
        private readonly object _lock = new object();

        public PhuraseDetailRepository() : base(new ProteinDB())
        {
        }

        public Expression<Func<PhuraseDetailEntity, bool>> GetDetailExp(int brand, int flavor, int package, int productionType,
            int productionDetailType, int isWriteOffMoney, string keyWord, DateTime startTime, DateTime endTime, DateTime writeOffMoneyStartTime, DateTime writeOffMoneyEndTime, string receiptNumber)
        {
            Expression<Func<PhuraseDetailEntity, bool>> itemWhere = c => true;

            if (brand > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.Products.Any(x => x.Brand == brand));
            }
            if (flavor > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.Products.Any(x => x.Flavor == flavor));
            }
            if (package > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.Products.Any(x => x.Package == package));
            }
            if (productionType > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.Products.Any(x => x.ProductionType == productionType));
            }
            if (productionDetailType > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.Products.Any(x => x.ProductionDetailType == productionDetailType));
            }

            if (isWriteOffMoney != -1)
            {
                itemWhere = itemWhere.AndAlso(c => c.IsWriteOffMoney == (isWriteOffMoney == 1));
            }

            if (keyWord != "")
            {
                itemWhere = itemWhere.AndAlso(c => c.Account == keyWord || c.OrderNumber == keyWord || c.CompanyInvoiceNumber == keyWord || c.CompanyName == keyWord);
            }

            if (endTime != DateTime.MaxValue)
            {
                itemWhere = itemWhere.AndAlso(c => c.OrderCreateTime < endTime);
            }

            if (startTime != DateTime.MinValue)
            {
                itemWhere = itemWhere.AndAlso(c => c.OrderCreateTime > startTime);
            }

            if (writeOffMoneyEndTime != DateTime.MaxValue)
            {
                itemWhere = itemWhere.AndAlso(c => c.WriteOffMoneyTime < writeOffMoneyEndTime);
            }

            if (writeOffMoneyStartTime != DateTime.MinValue)
            {
                itemWhere = itemWhere.AndAlso(c => c.WriteOffMoneyTime > writeOffMoneyStartTime);
            }

            if (!string.IsNullOrEmpty(receiptNumber))
            {
                itemWhere = itemWhere.AndAlso(c => c.ReceiptNumber == receiptNumber);
            }
            return itemWhere;
        }
    }
}