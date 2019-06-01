﻿using System.Collections.Generic;
using Common.Entity;
using Common.Enum;

namespace Common.Interface.Controller
{
    public interface IController
    {
        bool CreateInvoice(string itemCode, int number, int price, string EINNnumber = "");

        bool importShipDataProcess(string path);


        bool CreateShippmentTickets();

        List<ItemViewModel> GetStorage(int brand, int flavor, int package, int productionType, int productionDetailType, bool showZero);

        bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> phuraseDetailModels);

        bool UpdateDBStorage(List<PhuraseDetailModel> list);

        List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel);

        bool importWirteOffMoneyDataProcess(string path);
        void AddPhuraseProduct(string itemItemCode, int count, int saleMoney);
        PhuraseDetailModel CreateSale(int shopeeFee, string receiptnumber, int plat);
        bool UpdateDBItems(List<ItemViewModel> list);
    }
}
