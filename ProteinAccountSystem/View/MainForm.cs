using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common.Entity;
using Common.Enum;
using Common.Interface.Controller;
using Common.Interface.Service;
using Common.Utils;

namespace View
{
    public partial class MainForm : Form
    {
        private IController _controller;
        List<OrderDisplayItem> _displayItems = new List<OrderDisplayItem>();

        public MainForm(IController controller)
        {
            _controller = controller;

            InitializeComponent();
         
            #region Import Combox Enum
            foreach (BrandEnum brand in Enum.GetValues(typeof(BrandEnum)))
            {
                var dis = brand.GetDescriptionText();
                cbxBrands.Items.Add(dis);
            }

            foreach (FlavorEnum flavor in Enum.GetValues(typeof(FlavorEnum)))
            {
                var dis = flavor.GetDescriptionText();
                cbxFlavors.Items.Add(dis);
            }

            foreach (PackageEnum package in Enum.GetValues(typeof(PackageEnum)))
            {
                var dis = package.GetDescriptionText();
                cbxPackages.Items.Add(dis);
            }

            foreach (ProductionDetail item in Enum.GetValues(typeof(ProductionDetail)))
            {
                var dis = item.GetDescriptionText();
                cbxProductDetail.Items.Add(dis);
            }

            foreach (ProductionType item in Enum.GetValues(typeof(ProductionType)))
            {
                var dis = item.GetDescriptionText();
                cbxType.Items.Add(dis);
            }

            foreach (PlatEnum item in Enum.GetValues(typeof(PlatEnum)))
            {
                var dis = item.GetDescriptionText();
                cbsSaleWays.Items.Add(dis);
            }
            #endregion
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
            var Brand = (BrandEnum)cbxBrands.SelectedIndex;
            var Flavor = (FlavorEnum)cbxFlavors.SelectedIndex;
            var Package = (PackageEnum)cbxPackages.SelectedIndex;
            var ProductionType = (ProductionType)cbxType.SelectedIndex;
            var ProductionDetailType = (ProductionDetail)cbxProductDetail.SelectedIndex;
            var storages = _controller.GetStorage(Brand, Flavor, Package, ProductionType, ProductionDetailType);
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

            _controller.AddPhuraseProduct(item.ItemCode, (int)nudCount.Value, Convert.ToInt32(tbxSalePrice));


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
            var model = _controller.CreateSale(Convert.ToInt32(tbxShippingFee), tbxReceipyNumber.Text, (PlatEnum)cbsSaleWays.SelectedIndex);

            _controller.AddDBlientPhuraseRecord(new List<PhuraseDetailModel>() { model });
            _controller.UpdateDBStorage(new List<PhuraseDetailModel>() { model });

            _displayItems.Clear();

            dgvNewOrder.DataSource = _displayItems;
            dgvNewOrder.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void btnExportStockExcel_Click(object sender, EventArgs e)
        {
            SearchModel searchModel = new SearchModel();
            searchModel.KeyWord = txtKeyWord.Text;
            searchModel.StartTime = dtpStart.Value;
            searchModel.EndTime = dtpEnd.Value;
            searchModel.Brand = (BrandEnum)cbxBrands.SelectedIndex;
            searchModel.Flavor = (FlavorEnum)cbxFlavors.SelectedIndex;
            searchModel.Package = (PackageEnum)cbxPackages.SelectedIndex;
            searchModel.ProductionType = (ProductionType)cbxType.SelectedIndex;
            searchModel.ProductionDetailType = (ProductionDetail)cbxProductDetail.SelectedIndex;
            var result = _controller.GetSalesRecords(searchModel);
            //TODO:Create Excel
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchModel searchModel = new SearchModel();
            searchModel.KeyWord = txtKeyWord.Text;
            searchModel.StartTime = dtpStart.Value;
            searchModel.EndTime = dtpEnd.Value;
            searchModel.Brand = (BrandEnum)cbxBrands.SelectedIndex;
            searchModel.Flavor = (FlavorEnum)cbxFlavors.SelectedIndex;
            searchModel.Package = (PackageEnum)cbxPackages.SelectedIndex;
            searchModel.ProductionType = (ProductionType)cbxType.SelectedIndex;
            searchModel.ProductionDetailType = (ProductionDetail)cbxProductDetail.SelectedIndex;
            var result = _controller.GetSalesRecords(searchModel);

            dgvSaleRecords.DataSource = result;

            for (int i = 0; i < result.Count; i++)
            {
                DataGridViewButtonColumn btnWriteOffMoney = new DataGridViewButtonColumn();
                btnWriteOffMoney.Name = "btnWriteOffMoney" + i.ToString();
                btnWriteOffMoney.Text = "銷帳";
                int columnIndex = i;
                if (dgvSaleRecords.Columns["btnWriteOffMoney"] == null)
                {
                    dgvSaleRecords.Columns.Insert(columnIndex, btnWriteOffMoney);
                }
                dgvSaleRecords.CellClick += DgvSaleRecords_CellClick;
            }

            dgvSaleRecords.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void DgvSaleRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            throw new NotImplementedException();
        }

        private void btnImportExcelWirteOffMoney_Click(object sender, EventArgs e)
        {
            // List<PhuraseDetailModel>
            openFileDialog1.ShowDialog();
            var path = openFileDialog1.FileName;
            _controller.importWirteOffMoneyDataProcess(path);
        }
    }
}
