using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Interface.Service;
using Controller.Controller;
using Service.AutoMapper;
using Service.Service;
using View;

namespace Setup
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //TODO: dirty work here , use DI
            IAnalyzeExcelService analyzeExcelService = new AnalyzeShopeeExcelSevice();
            IStockService stockService = new StockServiceService();
            IShippmentService shippmentService = new ShippmentService();
            ICreateSaleService createSaleService = new CreateSaleService();
            IAccountingService accountingService = new AccountingService();
            IExcelExportService excelExportService = new ExcelExportService();

            AutoMapperConfig.Configure();

            //first run
            //DataBaseInitializer.InitailizeEnumDatabase();

            EnumService.EnumInitialize();

            //first run
            //DataBaseInitializer.InitializeItemsDataBase();

            Application.Run(new MainForm(new ShopeeController(
                analyzeExcelService, stockService, 
                shippmentService, createSaleService, accountingService,
                excelExportService)));

        }
    }
}
