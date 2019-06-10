using AutoMapper;
using CodeFirstORM.DBLayer;
using CodeFirstORM.Entity;
using Common.Entity;
using Common.Entity.Dto;
using Common.Interface.Service;
using Common.Constants;
using Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public bool AddDBStorage(Item item)
        {
            var repo = new ItemRepository();
            return repo.Add(Mapper.Map<ItemEntity>(item));
        }

        public bool AddDBStorages(List<Item> list)
        {
            var repo = new ItemRepository();
            return repo.Add(Mapper.Map<List<ItemEntity>>(list));
        }

        public List<PhuraseDetailModel> AddSalesRecordIfNotExist(List<PhuraseDetailModel> phuraseDetailModels)
        {
            var repo = new PhuraseDetailRepository();
            var map = Mapper.Map<List<PhuraseDetailEntity>>(phuraseDetailModels);
            //TODO:原本邏輯有誤，修改後待測
            var orders = phuraseDetailModels.GroupBy(p => p.OrderNumber).Select(s => s.First()).Select(p => p.OrderNumber);
            var result = repo.AddIfNotExists(map, x => orders.Contains(x.OrderNumber));

            return Mapper.Map<List<PhuraseDetailModel>>(result);
        }

        public void GenerateProductItemCode(List<PhuraseDetailModel> models)
        {
            foreach (var model in models)
            {
                var products = model.Products;
                foreach (var item in products)
                {
                    var name = item.ProductName.ToLower();
                    var itemcode = "";

                    foreach (var pair in Enums.ProductionEnum.OrderByDescending(p => p.Value.KeyWord.Length))
                    {
                        if (name.Contains(pair.Value.KeyWord))
                        {
                            itemcode += pair.Key.ToString("00");
                            break;
                        }
                    }

                    foreach (var pair in Enums.BrandEnum.OrderByDescending(p => p.Value.KeyWord.Length))
                    {
                        if (name.Contains(pair.Value.KeyWord))
                        {
                            itemcode += pair.Key.ToString("00");
                            break;
                        }
                    }

                    foreach (var pair in Enums.ProductionDetailEnum.OrderByDescending(p => p.Value.KeyWord.Length))
                    {
                        if (name.Contains(pair.Value.KeyWord))
                        {
                            itemcode += pair.Key.ToString("00");
                            break;
                        }
                    }

                    foreach (var pair in Enums.PackageEnum.OrderByDescending(p => p.Value.KeyWord.Length))
                    {
                        if (name.Contains(pair.Value.KeyWord))
                        {
                            itemcode += pair.Key.ToString("00");
                            break;
                        }
                    }

                    foreach (var pair in Enums.FlavorEnum.OrderByDescending(p => p.Value.KeyWord.Length))
                    {
                        if (name.Contains(pair.Value.KeyWord))
                        {
                            itemcode += pair.Key.ToString("00");
                            break;
                        }
                    }
                    item.ItemCode = itemcode;
                }
            }
        }

        /// <summary>
        /// 取得庫存
        /// </summary>
        /// <returns></returns>
        public List<ItemViewModel> GetDBStorage(int brand, int flavor, int package, int productionType, int productionDetailType, bool showZero)
        {
            var repo = new ItemRepository();
            var ex = repo.GetItemExp(brand, flavor, package, productionType, productionDetailType, showZero);
            return Mapper.Map<List<ItemViewModel>>(repo.Get(ex).OrderByDescending(o => o.Key));
        }

        public SaleRecordPagingDto GetSalesRecords(SearchModel searchModel, int pageIndex)
        {
            var repo = new PhuraseDetailRepository();
            var exp = repo.GetDetailExp(searchModel.Brand, searchModel.Package, searchModel.Package,
                searchModel.ProductionType, searchModel.ProductionDetailType,
                searchModel.IsWriteOffMoney, searchModel.KeyWord, searchModel.StartTime, searchModel.EndTime);
            var pageSize = Constant.PageSize;
            var details = Mapper.Map<List<PhuraseDetailModel>>(repo.Get(exp).OrderByDescending(o => o.OrderCreateTime).Skip((pageIndex - 1) * pageSize).Take(pageSize)).ToList();
            var count = repo.GetRowCount(exp);
            return new SaleRecordPagingDto
            {
                Details = details,
                TotalCount = count
            };
        }

        public List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel)
        {
            var repo = new PhuraseDetailRepository();
            var itemWhere = repo.GetDetailExp(searchModel.Brand, searchModel.Flavor, searchModel.Package,
                searchModel.ProductionType, searchModel.ProductionDetailType,
                searchModel.IsWriteOffMoney, searchModel.KeyWord, searchModel.StartTime, searchModel.EndTime);
            return Mapper.Map<List<PhuraseDetailModel>>(repo.Get(itemWhere)).OrderByDescending(o => o.OrderCreateTime).ToList();
        }

        public bool UpdateDBItems(List<ItemViewModel> list)
        {
            var repo = new ItemRepository();
            List<ItemEntity> updateList;
            try
            {
                updateList = Mapper.Map<List<ItemEntity>>(list);
            }
            catch
            {
                throw new ArgumentException("請勿輸入錯誤格式!");
            }
            return repo.Update(updateList);
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
                        codeToNumDic[product.ItemCode] = product.Count;
                    else
                        codeToNumDic[product.ItemCode] = num + product.Count;
                }

            var repo = new ItemRepository();
            var items = repo.Get(p => codeToNumDic.Keys.Contains(p.ItemCode)).OrderBy(o => o.ExpiredDate).GroupBy(g => g.ItemCode).Select(s => s.FirstOrDefault());
            foreach (var item in items)
                item.Storage -= codeToNumDic[item.ItemCode];
            return repo.Update(items);
        }
    }
}