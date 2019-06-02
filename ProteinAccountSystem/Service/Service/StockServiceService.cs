using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CodeFirstORM.DBLayer;
using CodeFirstORM.Entity;
using Common.Entity;
using Common.Enum;
using Common.Interface.Service;
using Common.Utils;
using CommonUtility.Enum;
using Service.AutoMapper;

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
            var items = repo.Get(p => codeToNumDic.Keys.Contains(p.ItemCode)).OrderBy(o => o.ExpiredDate).GroupBy(g => g.ItemCode).Select(s => s.FirstOrDefault());
            foreach (var item in items)
                item.Storage -= codeToNumDic[item.ItemCode];
            return repo.Update(items);
        }

        /// <summary>
        /// 取得庫存
        /// </summary>
        /// <returns></returns>
        public List<ItemViewModel> GetStorage(int brand, int flavor, int package, int productionType, int productionDetailType,bool showZero)
        {
            var repo = new ItemRepository();
            var ex = repo.GetItemExp(brand, flavor, package, productionType, productionDetailType, showZero);
            return Mapper.Map<List<ItemViewModel>>(repo.Get(ex).OrderByDescending(o => o.Key));
        }

        public List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel)
        {
            var repo = new PhuraseDetailRepository();
            var itemWhere = repo.GetDetailExp(searchModel.Brand, searchModel.Package, searchModel.Package,
                searchModel.ProductionType, searchModel.ProductionDetailType,
                searchModel.IsWriteOffMoney, searchModel.KeyWord);
            return Mapper.Map<List<PhuraseDetailModel>>(repo.Get(itemWhere));
        }

        public List<PhuraseDetailModel> UpdateProductItemCode(List<PhuraseDetailModel> models)
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
                            itemcode += ((int)pair.Key).ToString("00");
                            break;
                        }
                    }

                    foreach (var pair in Enums.BrandEnum.OrderByDescending(p => p.Value.KeyWord.Length))
                    {
                        if (name.Contains(pair.Value.KeyWord))
                        {
                            itemcode += ((int)pair.Key).ToString("00");
                            break;
                        }
                    }

                    foreach (var pair in Enums.ProductionDetailEnum.OrderByDescending(p => p.Value.KeyWord.Length))
                    {
                        if (name.Contains(pair.Value.KeyWord))
                        {
                            itemcode += ((int)pair.Key).ToString("00");
                            break;
                        }
                    }

                    foreach (var pair in Enums.PackageEnum.OrderByDescending(p => p.Value.KeyWord.Length))
                    {
                        if (name.Contains(pair.Value.KeyWord))
                        {
                            itemcode += ((int)pair.Key).ToString("00");
                            break;
                        }
                    }

                    foreach (var pair in Enums.FlavorEnum.OrderByDescending(p => p.Value.KeyWord.Length))
                    {
                        if (name.Contains(pair.Value.KeyWord))
                        {
                            itemcode += ((int)pair.Key).ToString("00");
                            break;
                        }
                    }
                    item.ItemCode = itemcode;
                }
            }
            return models;
        }

        public bool UpdateDBItems(List<ItemViewModel> list)
        {
            var repo = new ItemRepository();
            var updateList = new List<ItemEntity>();
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

        public bool AddStorage(Item item)
        {
            var repo = new ItemRepository();
            return repo.Add(Mapper.Map<ItemEntity>(item));
        }
    }
}
