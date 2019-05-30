using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CodeFirstORM.DBLayer;
using CodeFirstORM.Entity;
using Common.Entity;
using Common.Interface.Service;

namespace Service.Service
{
    public class StockServiceService : IStockService
    {
        /// <summary>
        /// 加入用戶購買紀錄到資料庫
        /// </summary>
        /// <param name="stockData"></param>
        /// <returns></returns>
        public bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> stockData)
        {
            var repo = new PhuraseDetailRepository();
            
            return repo.Add(Mapper.Map<List<PhuraseDetailEntity>>(stockData));
        }

        /// <summary>
        /// 更新db庫存數量
        /// </summary>
        /// <param name="stockData"></param>
        /// <returns></returns>
        public bool UpdateDBStorage(List<PhuraseDetailModel> stockData)
        {
            Dictionary<string, int> codeToNumDic = new Dictionary<string, int>();

            foreach (var detail in stockData)
                foreach (var product in detail.Products)
                {
                    if (!codeToNumDic.TryGetValue(product.ItemCode, out int num))
                        codeToNumDic[product.ItemCode] = 1;
                    else
                        codeToNumDic[product.ItemCode] = num + 1;
                }

            var repo = new ItemRepository();
            var items = repo.Get(p => codeToNumDic.ContainsKey(p.ItemCode)).OrderBy(o => o.ExpiredDate).GroupBy(g => g.ItemCode).Select(s => s.FirstOrDefault());
            foreach (var item in items)
                item.Storage -= codeToNumDic[item.ItemCode];
            return repo.Update(items);
        }

        /// <summary>
        /// 取得庫存
        /// </summary>
        /// <returns></returns>
        public List<Item> GetStorage(Common.Enum.BrandEnum brand, Common.Enum.FlavorEnum flavor, Common.Enum.PackageEnum package, Common.Enum.ProductionType productionType, Common.Enum.ProductionDetail productionDetailType)
        {
            var repo = new ItemRepository();
            var ex = repo.GetItemExp(brand, flavor, package, productionType, productionDetailType);
            return Mapper.Map< List<Item>>(repo.Get(ex));
        }

        public List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel)
        {
            var repo = new PhuraseDetailRepository();
            var result = new List<PhuraseDetailModel>();
            System.Linq.Expressions.Expression<Func<PhuraseDetailEntity, bool>> itemWhere = c => true;

            if (searchModel.Brand != Common.Enum.BrandEnum.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.Products.Any(x => x.Brand == (searchModel.Brand));
            }

            if (searchModel.StartTime != null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.OrderCreateTime >= searchModel.StartTime;
            }

            if (searchModel.EndTime != null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.OrderCreateTime <= searchModel.EndTime;
            }

            if (searchModel.Flavor != Common.Enum.FlavorEnum.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.Products.Any(x =>x.Flavor == (searchModel.Flavor));
            }

            if (searchModel.Package != Common.Enum.PackageEnum.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.Products.Any(x => x.Package == (searchModel.Package));
            }

            if (searchModel.ProductionDetailType != Common.Enum.ProductionDetail.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.Products.Any(x => x.ProductionDetailType == (searchModel.ProductionDetailType));
            }

            if (searchModel.ProductionType != Common.Enum.ProductionType.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.Products.Any(x => x.ProductionType == (searchModel.ProductionType));
            }

            if (searchModel.IsWriteOffMoney != -1)
            {
                var prefix = itemWhere.Compile();
                var b = searchModel.IsWriteOffMoney == 1 ? true : false;
                itemWhere = c => prefix(c) && c.IsWriteOffMoney == b;
            }

            //if (searchModel.KeyWord != "")
            //{
            //    var prefix = itemWhere.Compile();
            //    itemWhere = c => prefix(c) && c.);
            //}
            //TODO:keyword
           return Mapper.Map<List<PhuraseDetailModel>>(repo.Get(itemWhere));
        }
    }
}
