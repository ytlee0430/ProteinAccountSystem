using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Common.Entity;
using Common.Enum;
using Common.Interface.Controller;
using Common.Utils;
using CommonUtility.Enum;

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
            foreach (var pair in Enums.BrandEnum)
                cbxBrands.Items.Add(pair.Value.Description);

            foreach (var pair in Enums.FlavorEnum)
                cbxFlavors.Items.Add(pair.Value.Description);

            foreach (var pair in Enums.PackageEnum)
                cbxPackages.Items.Add(pair.Value.Description);

            foreach (var pair in Enums.ProductionDetailEnum)
                cbxProductDetail.Items.Add(pair.Value.Description);

            foreach (var pair in Enums.ProductionEnum)
                cbxType.Items.Add(pair.Value.Description);


            foreach (var pair in Enums.PlatEnum)
                cbsSaleWays.Items.Add(pair.Value.Description);

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
            var Brand = cbxBrands.SelectedIndex;
            var Flavor = cbxFlavors.SelectedIndex;
            var Package = cbxPackages.SelectedIndex;
            var ProductionType = cbxType.SelectedIndex;
            var ProductionDetailType = cbxProductDetail.SelectedIndex;
            var showZero = ckbShowCountZero.Checked;
            var storages = _controller.GetStorage(Brand, Flavor, Package, ProductionType, ProductionDetailType, showZero);
            dgvStorage.DataSource = storages;
            dgvStorage.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var item = new Item
            {
                Brand = cbxBrands.SelectedIndex,
                Flavor = cbxFlavors.SelectedIndex,
                Package = cbxPackages.SelectedIndex,
                ProductionType = cbxType.SelectedIndex,
                ProductionDetailType = cbxProductDetail.SelectedIndex,
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
            var model = _controller.CreateSale(Convert.ToInt32(tbxShippingFee), tbxReceipyNumber.Text, cbsSaleWays.SelectedIndex);

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
            searchModel.Brand = cbxBrands.SelectedIndex;
            searchModel.Flavor = cbxFlavors.SelectedIndex;
            searchModel.Package = cbxPackages.SelectedIndex;
            searchModel.ProductionType = cbxType.SelectedIndex;
            searchModel.ProductionDetailType = cbxProductDetail.SelectedIndex;
            var result = _controller.GetSalesRecords(searchModel);
            //TODO:Create Excel
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchModel searchModel = new SearchModel();
            searchModel.KeyWord = txtKeyWord.Text;
            searchModel.StartTime = dtpStart.Value;
            searchModel.EndTime = dtpEnd.Value;
            searchModel.Brand = cbxBrands.SelectedIndex;
            searchModel.Flavor = cbxFlavors.SelectedIndex;
            searchModel.Package = cbxPackages.SelectedIndex;
            searchModel.ProductionType = cbxType.SelectedIndex;
            searchModel.ProductionDetailType = cbxProductDetail.SelectedIndex;
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

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            var list = (List<ItemViewModel>)dgvStorage.DataSource;
            try
            {
                _controller.UpdateDBItems(list);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            MessageBox.Show("更新完成!");
        }

        private void ckbEnableChange_CheckedChanged(object sender, EventArgs e)
        {
            dgvStorage.ReadOnly = !ckbEnableChange.Checked;
        }
    }
}
