using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Common.Entity;
using Common.Interface.Controller;
using Common.Utils;
using CommonUtility.Constants;
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
            cbxBrands.SelectedIndex = 0;

            foreach (var pair in Enums.FlavorEnum)
                cbxFlavors.Items.Add(pair.Value.Description);
            cbxFlavors.SelectedIndex = 0;

            foreach (var pair in Enums.PackageEnum)
                cbxPackages.Items.Add(pair.Value.Description);
            cbxPackages.SelectedIndex = 0;

            foreach (var pair in Enums.ProductionDetailEnum)
                cbxProductDetail.Items.Add(pair.Value.Description);
            cbxProductDetail.SelectedIndex = 0;

            foreach (var pair in Enums.ProductionEnum)
                cbxType.Items.Add(pair.Value.Description);
            cbxType.SelectedIndex = 0;

            foreach (var pair in Enums.PlatEnum)
                cbxSaleWays.Items.Add(pair.Value.Description);
            cbxSaleWays.SelectedIndex = 0;
            #endregion

            dtpStart.Value = DateTime.Now.AddMonths(-1);
            dtpEnd.Value = DateTime.Now; ;
            dtpExpireDate.Value = DateTime.Now.AddYears(1);

            cbxIsWriteOffMoney.SelectedIndex = 0;
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
            MessageBox.Show(!_controller.ImportShipDataProcess(path) ? "匯入失敗!" : "匯入成功!");
        }

        private void btnCreateShippmentTicket_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            var path = saveFileDialog1.FileName;
            var result = _controller.CreateShippmentTickets(path);
            MessageBox.Show(!result ? "匯出失敗!" : "匯出成功!");
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

            _controller.AddPhuraseProduct(item.ItemCode, (int)nudCount.Value, Convert.ToInt32(tbxSalePrice.Text));

            _displayItems.Add(new OrderDisplayItem
            {
                Brand = Enums.BrandEnum[item.Brand].Description,
                Flavor = Enums.FlavorEnum[item.Flavor].Description,
                Package = Enums.PackageEnum[item.Package].Description,
                ProductionType = Enums.ProductionEnum[item.ProductionType].Description,
                ProductionDetailType = Enums.ProductionDetailEnum[item.ProductionDetailType].Description,
                ItemCode = item.ItemCode,
                Count = (int)nudCount.Value,
                Price = Convert.ToInt32(tbxSalePrice.Text),
            });
            dgvNewOrder.DataSource = _displayItems.ToList();
        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            var model = _controller.CreateSale(Convert.ToInt32(tbxShippingFee.Text), tbxReceipyNumber.Text, cbxSaleWays.SelectedIndex);
            model.OrderCreateTime = DateTime.Now;
            _controller.AddDBlientPhuraseRecord(new List<PhuraseDetailModel>() { model });
            _controller.UpdateDBStorage(new List<PhuraseDetailModel>() { model });

            _displayItems.Clear();

            dgvNewOrder.DataSource = _displayItems;
            dgvNewOrder.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void btnExportStockExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            var path = saveFileDialog1.FileName;

            var Brand = cbxBrands.SelectedIndex;
            var Flavor = cbxFlavors.SelectedIndex;
            var Package = cbxPackages.SelectedIndex;
            var ProductionType = cbxType.SelectedIndex;
            var ProductionDetailType = cbxProductDetail.SelectedIndex;
            var showZero = ckbShowCountZero.Checked;
            var storages = _controller.GetStorage(Brand, Flavor, Package, ProductionType, ProductionDetailType, showZero);
            var result = _controller.ExportStockExcel(storages, path);
            if (!result)
                MessageBox.Show("匯出失敗!");
            else
                MessageBox.Show("匯出成功!");
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

          
            DataGridViewButtonColumn dgvbt = new DataGridViewButtonColumn();
            dgvbt.Text = "顯示詳細銷貨資訊";
            dgvbt.UseColumnTextForButtonValue = true;
            dgvSaleRecords.Columns.Add(dgvbt);
            dgvSaleRecords.DataSource = result.OrderByDescending(r => r.OrderCreateTime).ToList();
            dgvSaleRecords.CellClick += DgvSaleRecords_CellClick;
            dgvSaleRecords.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            int pageIndex = Convert.ToInt32(lblNowPage.Text);
            int pageSize = Constant.PageSize;
            int firstIndex = (pageIndex - 1) * pageSize + 1;
            int lastIndex = pageIndex * pageSize;
            for (int i = 1; i < dgvSaleRecords.Rows.Count; i++)
            {
                if (i >= firstIndex && i <= lastIndex)
                {
                    dgvSaleRecords.Rows[i].Visible = true;
                    continue;
                }
                dgvSaleRecords.Rows[i].Visible = false;
            }

            lblDataCount.Text = dgvSaleRecords.Rows.Count.ToString();

            var minWidth = 100;
            var maxWidth = 200;
            foreach (DataGridViewColumn c in dgvSaleRecords.Columns)
            {
                if (c.Width > maxWidth)
                {
                    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    c.Width = maxWidth;
                }
                else if (c.Width < minWidth)
                {
                    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    c.Width = minWidth;
                }
            }
        }

        private void DgvSaleRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var row = e.RowIndex;
                var datas = ((List<PhuraseDetailModel>)dgvSaleRecords.DataSource);
                var data = datas[row].Products;
                //TODO: MAPPING ITEM CODE TO DETAILS
                var details = new Form();
                details.Text = "購買清單:" + datas[row].Account.ToString();
                var dgv = new DataGridView();
                dgv.Dock = DockStyle.Fill;
                dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                dgv.DataSource = data;
                dgv.ScrollBars = ScrollBars.Both;
                details.Controls.Add(dgv);
                details.Height = 300;
                details.Width = 1000;
                details.ShowDialog();
            }

            if (e.ColumnIndex != 11 || e.RowIndex < 0)
                return;
            var y = e.RowIndex;
            var list = (List<PhuraseDetailModel>)dgvSaleRecords.DataSource;
            list[y].IsWriteOffMoney = !list[y].IsWriteOffMoney;
        }

        private void btnImportExcelWirteOffMoney_Click(object sender, EventArgs e)
        {
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

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            var Brand = cbxBrands.SelectedIndex;
            var Flavor = cbxFlavors.SelectedIndex;
            var Package = cbxPackages.SelectedIndex;
            var ProductionType = cbxType.SelectedIndex;
            var ProductionDetailType = cbxProductDetail.SelectedIndex;
            var count = (int)nudCount.Value;
            var price = Convert.ToInt32(tbxSalePrice.Text);
            var discount = Convert.ToDouble(tbxDiscount.Text);
            var cost = Convert.ToInt32(tbxCost.Text);
            var expireDate = dtpExpireDate.Value;
            var item = new Item
            {
                Brand = Brand,
                Flavor = Flavor,
                Package = Package,
                ProductionType = ProductionType,
                ProductionDetailType = ProductionDetailType,
                Storage = count,
                NetPrice = price,
                Discount = discount,
                Cost = cost,
                ExpiredDate = expireDate,
            };
            item.ItemCode = ProductUtilities.GetItemCodes(item);

            _controller.AddDBStorage(item);
            MessageBox.Show("更新完成!");
        }

        private void btnWriteOffSelectedMoney_Click(object sender, EventArgs e)
        {
            _controller.WriteOffSelectedMoney((List<PhuraseDetailModel>)dgvSaleRecords.DataSource);
            MessageBox.Show("更新完成!");
        }

        private void btnCreateSaleRecord_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            var path = saveFileDialog1.FileName;

            SearchModel searchModel = new SearchModel();
            searchModel.KeyWord = txtKeyWord.Text;
            searchModel.StartTime = dtpStart.Value;
            searchModel.EndTime = dtpEnd.Value;
            searchModel.Brand = cbxBrands.SelectedIndex;
            searchModel.Flavor = cbxFlavors.SelectedIndex;
            searchModel.Package = cbxPackages.SelectedIndex;
            searchModel.ProductionType = cbxType.SelectedIndex;
            searchModel.ProductionDetailType = cbxProductDetail.SelectedIndex;
            var list = _controller.GetSalesRecords(searchModel);
            var result = _controller.ExportSaleRecordExcel(list, path);
            if (!result)
                MessageBox.Show("匯出失敗!");
            else
                MessageBox.Show("匯出成功!");
        }

        private void btnBulkStorage_Click(object sender, EventArgs e)
        {
            var Brand = cbxBrands.SelectedIndex;
            var Package = cbxPackages.SelectedIndex;
            var ProductionType = cbxType.SelectedIndex;
            var ProductionDetailType = cbxProductDetail.SelectedIndex;
            var count = (int)nudCount.Value;
            var price = Convert.ToInt32(tbxSalePrice.Text);
            var discount = Convert.ToDouble(tbxDiscount.Text);
            var cost = Convert.ToInt32(tbxCost.Text);
            var expireDate = dtpExpireDate.Value;
            var list = new List<Item>();
            foreach (var flavor in Enums.FlavorEnum.Where(x => x.Value.ParentType == 1))
            {
                var item = new Item
                {
                    Brand = Brand,
                    Flavor = flavor.Key,
                    Package = Package,
                    ProductionType = ProductionType,
                    ProductionDetailType = ProductionDetailType,
                    Storage = count,
                    NetPrice = price,
                    Discount = discount,
                    Cost = cost,
                    ExpiredDate = expireDate,
                };
                item.ItemCode = ProductUtilities.GetItemCodes(item);
                list.Add(item);
            }
            _controller.AddDBStorages(list);
            MessageBox.Show("更新完成!");
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int pageIndex = Convert.ToInt32(lblNowPage.Text);
            pageIndex++;
            int pageSize = Constant.PageSize;
            int firstIndex = (pageIndex - 1) * pageSize + 1;
            int lastIndex = pageIndex * pageSize;
            if (lastIndex > dgvSaleRecords.Rows.Count + pageSize - 1)
                return;

            lblNowPage.Text = pageIndex.ToString();

            for (int i = 1; i < dgvSaleRecords.Rows.Count; i++)
            {
                if (i >= firstIndex && i <= lastIndex)
                {
                    dgvSaleRecords.Rows[i].Visible = true;
                    continue;
                }
                dgvSaleRecords.Rows[i].Visible = false;
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int pageIndex = Convert.ToInt32(lblNowPage.Text);
            pageIndex--;
            int pageSize = Constant.PageSize;
            int firstIndex = (pageIndex - 1) * pageSize + 1;
            int lastIndex = pageIndex * pageSize;
            if (firstIndex < 1)
                return;

            lblNowPage.Text = pageIndex.ToString();

            for (int i = 1; i < dgvSaleRecords.Rows.Count; i++)
            {
                if (i >= firstIndex && i <= lastIndex)
                {
                    dgvSaleRecords.Rows[i].Visible = true;
                    continue;
                }
                dgvSaleRecords.Rows[i].Visible = false;
            }
        }
    }
}
