using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonUtility.Entity;
using CommonUtility.Enum;
using CommonUtility.Interface;
using CommonUtility.Utils;

namespace ProteinAccountSystem
{
    public partial class MainForm : Form
    {
        private IController _controller;

        List<PhuraseProductModel> _phurases = new List<PhuraseProductModel>();
        List<OrderDisplayItem>  _displayItems = new List<OrderDisplayItem>();

        public MainForm(IController controller)
        {
            InitializeComponent();
            _controller = controller;

            foreach (var brand in Enum.GetValues(typeof(BrandEnum)))
                cbxBrands.Items.Add(brand.ToString());
            foreach (var flavor in Enum.GetValues(typeof(FlavorEnum)))
                cbxFlavors.Items.Add(flavor.ToString());
            foreach (var package in Enum.GetValues(typeof(PackageEnum)))
                cbxPackages.Items.Add(package.ToString());
            foreach (var item in Enum.GetValues(typeof(ProductionDetail)))
                cbxProductDetail.Items.Add(item.ToString());
            foreach (var item in Enum.GetValues(typeof(ProductionType)))
                cbxType.Items.Add(item.ToString());
        }

        /// <summary>
        /// 匯入蝦皮excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var path = openFileDialog1.FileName;
            _controller.importShipDataProcess(path);
        }

        private void btnCreateShippmentTicket_Click(object sender, EventArgs e)
        {
            var result = _controller.CreateShippmentTickets();
        }

        private void btnShowStorage_Click(object sender, EventArgs e)
        {
            var Brand = (BrandEnum) cbxBrands.SelectedIndex;
            var Flavor = (FlavorEnum) cbxFlavors.SelectedIndex;
            var Package = (PackageEnum) cbxPackages.SelectedIndex;
            var ProductionType = (ProductionType) cbxType.SelectedIndex;
            var ProductionDetailType = (ProductionDetail) cbxProductDetail.SelectedIndex;
            var storages = _controller.GetStorage(Brand,Flavor,Package, ProductionType, ProductionDetailType);
            dgvStorage.DataSource = storages;
            dgvStorage.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var item = new Item
            {
                Brand = (BrandEnum)cbxBrands.SelectedIndex,
                Flavor = (FlavorEnum)cbxFlavors.SelectedIndex,
                Package = (PackageEnum)cbxPackages.SelectedIndex,
                ProductionType = (ProductionType)cbxType.SelectedIndex,
                ProductionDetailType = (ProductionDetail)cbxProductDetail.SelectedIndex,
            };
            item.ItemCode = ProductUtilities.GetItemCodes(item);

            _phurases.Add(new PhuraseProductModel()
            {
                ItemCode = item.ItemCode,
                Count = (int)nudCount.Value,
                ProductMoney = Convert.ToInt32(tbxSalePrice),
                ProductMoneyWithoutTax = Convert.ToInt32(Convert.ToInt32(tbxSalePrice) / 1.05),
            });
            _displayItems.Add(new OrderDisplayItem
            {
                Brand = item.Brand,
                Flavor = item.Flavor,
                Package = item.Package,
                ProductionType = item.ProductionType,
                ProductionDetailType = item.ProductionDetailType,
                ItemCode = item.ItemCode,
                Count = (int)nudCount.Value,
                Price = Convert.ToInt32(tbxSalePrice),
            });

            dgvNewOrder.DataSource = _displayItems;
            dgvNewOrder.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            var model = new PhuraseDetailModel();
            model.Products = _phurases;
            model.TotalMoney = _phurases.Sum(x => x.ProductMoney * x.Count) + Convert.ToInt32(tbxShippingFee);
            model.TransferMoney = Convert.ToInt32(tbxShippingFee);
            model.TotalTax = Convert.ToInt32((_phurases.Sum(x => x.ProductMoneyWithoutTax*x.Count) + Convert.ToInt32(tbxShippingFee)) * 0.05);
            model.ReceiptNumber = tbxReceipyNumber.Text;

            _controller.AddDBlientPhuraseRecord(new List<PhuraseDetailModel>() { model });
            _controller.UpdateDBStorage(new List<PhuraseDetailModel>() { model });

            _phurases.Clear();
            _displayItems.Clear();
            dgvNewOrder.DataSource = _displayItems;
            dgvNewOrder.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void btnExportStockExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
