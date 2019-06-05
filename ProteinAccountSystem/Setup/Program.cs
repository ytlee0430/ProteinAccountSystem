using Common.Interface.Service;
using Common.Log;
using Controller.Controller;
using Service.AutoMapper;
using Service.Service;
using System;
using System.Windows.Forms;
using View;

namespace Setup
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        private static void Main()
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
            IEnumService enumService = new EnumService();
            AutoMapperConfig.Configure();

            //first run
            //DataBaseInitializer.InitailizeEnumDatabase();

            EnumService.EnumInitialize();

            //first run
            //DataBaseInitializer.InitializeItemsDataBase();

            //first run
            //EnumService.EnumParentTypeInitail();

            try
            {
                Application.Run(new MainForm(new MainFormController(
                    analyzeExcelService, stockService,
                    shippmentService, createSaleService, accountingService,
                    excelExportService, enumService)));
            }
            catch (Exception e)
            {
                LogUtil.Fatal(e.StackTrace);
                LogUtil.Fatal(e.ToString());
                MessageBox.Show($"Unhandle Exception Occur! Message:{e.Message}");
                Application.Exit();
            }
        }
    }
}