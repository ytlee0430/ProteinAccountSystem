using Common.Interface.Service;
using Common.Log;
using Service.AutoMapper;
using Service.Service;
using System;
using System.Windows.Forms;
using Common.Interface.Controller;
using Common.Interface.View;
using Controller.Controller;
using Microsoft.Extensions.DependencyInjection;
using Service;
using View;

namespace Setup
{
    internal static class Program
    {
        private static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AutoMapperConfig.Configure();

            //first run
            //DataBaseInitializer.InitailizeEnumDatabase();

            EnumService.EnumInitialize();

            //first run
            //DataBaseInitializer.InitializeItemsDataBase();

            //first run
            //EnumService.EnumParentTypeInitail();

            ConfigureServices();

            try
            {
                Application.Run((Form)ServiceProvider.GetService(typeof(IMainForm)));
            }
            catch (Exception e)
            {
                LogUtil.Fatal(e.StackTrace);
                LogUtil.Fatal(e.ToString());
                MessageBox.Show($"Unhandle Exception Occur! Message:{e.Message}");
                Application.Exit();
            }
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IDataAnalyzeService, DataAnalyzeService>();
            services.AddTransient<IAnalyzeExcelService, AnalyzeShopeeExcelSevice>();
            services.AddTransient<IStockService, StockServiceService>();
            services.AddTransient<IShippmentService, ShippmentService>();
            services.AddTransient<IAccountingService, AccountingService>();
            services.AddTransient<IExcelExportService, ExcelExportService>();
            services.AddTransient<IEnumService, EnumService>();
            services.AddTransient<IMainFormController, MainFormController>();
            services.AddTransient<IMainForm, MainForm>();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}