using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using ProteinSystem.Interface.Controller;
using ProteinSystem.Interface.Service;
using ProteinSystem.Interface.View;
using ProteinSystem.Log;
using ProteinSystem.Service;
using ProteinSystem.Service.AutoMapper;
using ProteinSystem.Service.Service;
using ProteinSystem.Service.Service.ExportSheetService;
using ProteinSystem.StockController.Controller;
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
            DataBaseInitializer.InitailizeEnumDatabase();

            EnumService.EnumInitialize();

            //first run
            DataBaseInitializer.InitializeItemsDataBase();

            //first run
            EnumService.EnumParentTypeInitail();

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
            services.AddTransient<IExportSheetService, GoogleSheetExportSheetService>();
            services.AddTransient<IEnumService, EnumService>();
            services.AddTransient<IMainFormController, MainFormController>();
            services.AddTransient<IMainForm, MainForm>();

            services.AddSingleton<ExportSheetServiceResolver>((ExportSheetType type) => {
                return type switch
                {
                    ExportSheetType.Excel => new ExportExcelService(),
                    ExportSheetType.GoogleSheet => new GoogleSheetExportSheetService(),
                    _ => throw new ArgumentOutOfRangeException(type.ToString()),
                };
            });

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}