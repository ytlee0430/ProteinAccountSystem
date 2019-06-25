using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Common.Entity;
using Common.Interface.Controller;
using Common.Interface.View;
using Common.Utils;
using Common.Constants;
using Common.Enum;

namespace View
{
    public partial class MainForm : Form, IMainForm
    {
        private readonly IMainFormController _controller;
        private readonly List<OrderDisplayItem> _displayItems = new List<OrderDisplayItem>();
        private readonly SearchModel _searchModel = new SearchModel();
        private readonly List<PhuraseProductModel> _phurases = new List<PhuraseProductModel>();

        public MainForm(IMainFormController controller)
        {
            _controller = controller;

            InitializeComponent();

            InitialEnumCbx();

            dtpSaleStart.Value = DateTime.Now.AddMonths(-1);
            dtpSaleEnd.Value = DateTime.Now;
            dtpExpireDate.Value = DateTime.Now.AddYears(1);

            cbxIsWriteOffMoney.SelectedIndex = 0;

            dgvSaleRecords.CellClick += DgvSaleRecords_CellClick;
            dgvNewOrder.CellClick += DgvNewOrder_CellClick;
            dtpSaleTime.Value = DateTime.Now;

            dgvSaleRecords.Columns.Clear();
            DataGridViewCheckBoxColumn dgvck = new DataGridViewCheckBoxColumn();
            dgvck.TrueValue = true;
            dgvck.FalseValue = false;

            dgvNewOrder.Columns.Add(dgvck);
        }

        private void DgvNewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
            var brand = cbxBrands.SelectedIndex;
            var flavor = cbxFlavors.SelectedIndex;
            var package = cbxPackages.SelectedIndex;
            var productionType = cbxType.SelectedIndex;
            var productionDetailType = cbxProductDetail.SelectedIndex;
            var showZero = ckbShowCountZero.Checked;
            var storages = _controller.GetStorage(brand, flavor, package, productionType, productionDetailType, showZero);
            dgvStorage.DataSource = storages;
            dgvStorage.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                #region check Input

                if (cbxBrands.SelectedIndex == 0)
                {
                    MessageBox.Show("輸入品牌有誤，請重新確認", "新增銷售項目");
                    return;
                }

                if (cbxType.SelectedIndex == 0)
                {
                    MessageBox.Show("輸入商品分類，請重新確認", "新增銷售項目");
                    return;
                }

                if (cbxProductDetail.SelectedIndex == 0)
                {
                    MessageBox.Show("輸入商品細項，請重新確認", "新增銷售項目");
                    return;
                }

                if (cbxFlavors.SelectedIndex == 0)
                {
                    MessageBox.Show("輸入口味有誤，請重新確認", "新增銷售項目");
                    return;
                }

                if (nudCount.Value == 0)
                {
                    MessageBox.Show("輸入數量為 0，請重新確認", "新增銷售項目");
                    return;
                }

                if (String.IsNullOrEmpty(tbxSalePrice.Text))
                {
                    MessageBox.Show("輸入金額為 0，請重新確認", "新增銷售項目");
                    return;
                }

                #endregion

                var item = new Item
                {
                    Brand = cbxBrands.SelectedIndex,
                    Flavor = cbxFlavors.SelectedIndex,
                    Package = cbxPackages.SelectedIndex,
                    ProductionType = cbxType.SelectedIndex,
                    ProductionDetailType = cbxProductDetail.SelectedIndex,
                };
                item.ItemCode = ProductUtilities.GetItemCodes(item);

                if (item.ItemCode == "0000000000")
                {
                    MessageBox.Show("輸入參數有錯，請重新確認", "新增銷售項目");
                    return;
                }

                var name = Enums.BrandEnum[item.Brand].Description + " " + Enums.ProductionEnum[item.ProductionType].Description + " " + Enums.ProductionDetailEnum[item.ProductionDetailType].Description + " " + Enums.FlavorEnum[item.Flavor].Description + " " + Enums.PackageEnum[item.Package].Description;
                _phurases.Add(new PhuraseProductModel()
                {
                    ItemCode = item.ItemCode,
                    Count = (int)nudCount.Value,
                    ProductMoney = Convert.ToInt32(tbxSalePrice.Text),
                    ProductMoneyWithoutTax = Convert.ToInt32(Convert.ToInt32(tbxSalePrice.Text) / 1.05),
                    Brand = item.Brand,
                    Flavor = item.Flavor,
                    Package = item.Package,
                    ProductionDetailType = item.ProductionDetailType,
                    ProductionType = item.ProductionType,
                    ProductName = name,
                });

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
            catch (Exception ex)
            {
                MessageBox.Show("輸入參數有錯，請重新確認", "新增銷售項目");
            }
        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("是否確認新增訂單? ", "新增訂單", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var time = dtpSaleTime.Value.Date == DateTime.Now ? DateTime.Now : dtpSaleTime.Value.Date;

                if (_phurases.Count == 0)
                {
                    MessageBox.Show("尚未新增銷售項目，請再次確認", "新增訂單");
                    return;
                }

                _controller.CreateSale(Convert.ToInt32(tbxShippingFee.Text), tbxReceiptNumber.Text, cbxSaleWays.SelectedIndex,
                    tbxCompanyName.Text, tbxInvoiceNumber.Text, time, txtCustomerName.Text, _phurases);

                _displayItems.Clear();
                _phurases.Clear();
                dgvNewOrder.DataSource = _displayItems;
                dgvNewOrder.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
        }

        private void btnExportStockExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            var path = saveFileDialog1.FileName;

            var brand = cbxBrands.SelectedIndex;
            var flavor = cbxFlavors.SelectedIndex;
            var package = cbxPackages.SelectedIndex;
            var productionType = cbxType.SelectedIndex;
            var productionDetailType = cbxProductDetail.SelectedIndex;
            var showZero = ckbShowCountZero.Checked;
            var storages = _controller.GetStorage(brand, flavor, package, productionType, productionDetailType, showZero);
            var result = _controller.ExportStockExcel(storages, path);
            MessageBox.Show(!result ? "匯出失敗!" : "匯出成功!", "匯出庫存結果");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _searchModel.KeyWord = txtKeyWord.Text;
            _searchModel.SaleStartTime = dtpSaleStart.Value.Date;
            _searchModel.SaleEndTime = dtpSaleEnd.Value.Date.AddDays(1);
            _searchModel.Brand = cbxBrands.SelectedIndex;
            _searchModel.Flavor = cbxFlavors.SelectedIndex;
            _searchModel.Package = cbxPackages.SelectedIndex;
            _searchModel.ProductionType = cbxType.SelectedIndex;
            _searchModel.ProductionDetailType = cbxProductDetail.SelectedIndex;
            _searchModel.IsWriteOffMoney = cbxIsWriteOffMoney.SelectedIndex - 1;

            if (cbxIsSearchWriteOffMoneyTime.Checked)
            {
                _searchModel.WriteOffMoneyStartTime = dtpWriteOffMoneyStartTime.Value.Date;
                _searchModel.WriteOffMoneyEndTime = dtpWriteOffMoneyEndTime.Value.Date.AddDays(1);
            }

            _searchModel.receiptNumber = tbxReceiptNumber.Text;

            SearchSaleRecord();
        }

        private void SearchSaleRecord()
        {
            int pageIndex = Convert.ToInt32(lblNowPage.Text);

            var result = _controller.GetSalesRecords(_searchModel, pageIndex);
            lblDataCount.Text = result.TotalCount.ToString();
            dgvSaleRecords.Columns.Clear();

            //create check box
            DataGridViewCheckBoxColumn dgvck = new DataGridViewCheckBoxColumn();
            dgvck.HeaderText = "欲取消項目";
            dgvck.TrueValue = true;
            dgvck.FalseValue = false;
            dgvSaleRecords.Columns.Add(dgvck);

            //create button
            DataGridViewButtonColumn dgvbt = new DataGridViewButtonColumn();
            dgvbt.HeaderText = "顯示詳細銷貨資訊";
            dgvbt.Text = "顯示詳細銷貨資訊";
            dgvbt.UseColumnTextForButtonValue = true;
            dgvSaleRecords.Columns.Add(dgvbt);

            dgvSaleRecords.DataSource = result.Details;
            dgvSaleRecords.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

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

            dgvSaleRecords.Columns["Key"].Visible = false;
        }

        private void DgvSaleRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                var row = e.RowIndex;
                var datas = ((List<PhuraseDetailModel>)dgvSaleRecords.DataSource);
                var data = datas[row].Products;

                var details = new Form();
                details.Text = string.IsNullOrEmpty(datas[row].Account) ? "購買清單:" : "購買清單:" + datas[row].Account.ToString();

                var dgv = new DataGridView();
                dgv.Dock = DockStyle.Fill;
                dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                dgv.DataSource = data;
                dgv.ScrollBars = ScrollBars.Both;
                dgv.DefaultCellStyle.Font = new Font("新細明體", 16);
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("新細明體", 14);

                details.Controls.Add(dgv);
                details.Height = 300;
                details.Width = 1000;
                details.ShowDialog();
            }

            if (e.ColumnIndex == 15)
            {
                //銷帳
                var rowIndex = e.RowIndex;
                var list = (List<PhuraseDetailModel>)dgvSaleRecords.DataSource;
                list[rowIndex].IsWriteOffMoney = !list[rowIndex].IsWriteOffMoney;
                if (list[rowIndex].IsWriteOffMoney)
                    list[rowIndex].WriteOffMoneyTime = DateTime.Now;
                else
                    list[rowIndex].WriteOffMoneyTime = null;

                dgvSaleRecords.DataSource = list;
                dgvSaleRecords.Refresh();
                dgvSaleRecords.Update();
            }
        }

        private void btnImportExcelWirteOffMoney_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                var path = openFileDialog1.FileName;
                _controller.ImportWirteOffMoneyDataProcess(path);
            }
            catch (Exception)
            {
            }
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            var list = (List<ItemViewModel>)dgvStorage.DataSource;
            try
            {
                if (_controller.UpdateDBItems(list))
                    MessageBox.Show("更新完成!");
                else
                    MessageBox.Show("更新失敗!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                MessageBox.Show("更新失敗!");
            }

        }

        private void ckbEnableChange_CheckedChanged(object sender, EventArgs e)
        {
            dgvStorage.ReadOnly = !ckbEnableChange.Checked;
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                var brand = cbxBrands.SelectedIndex;
                var flavor = cbxFlavors.SelectedIndex;
                var package = cbxPackages.SelectedIndex;
                var productionType = cbxType.SelectedIndex;
                var productionDetailType = cbxProductDetail.SelectedIndex;
                var count = (int)nudCount.Value;
                var price = Convert.ToInt32(tbxSalePrice.Text);
                var discount = Convert.ToDouble(tbxDiscount.Text);
                var cost = Convert.ToInt32(tbxCost.Text);
                var expireDate = dtpExpireDate.Value;
                var item = new Item
                {
                    Brand = brand,
                    Flavor = flavor,
                    Package = package,
                    ProductionType = productionType,
                    ProductionDetailType = productionDetailType,
                    Storage = count,
                    NetPrice = price,
                    Discount = discount,
                    Cost = cost,
                    ExpiredDate = expireDate,
                };
                item.ItemCode = ProductUtilities.GetItemCodes(item);
                MessageBox.Show(!_controller.AddDBStorage(item) ? "更新失敗!" : "更新完成!");
            }
            catch (Exception)
            {
                MessageBox.Show("輸入資料有誤，請重新確認");
            }
        }

        private void btnUpdateSalesRecords_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("是否確定要更新訂單狀態", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(_controller.UpdateSalesRecords((List<PhuraseDetailModel>)dgvSaleRecords.DataSource)
                    ? "更新完成!"
                    : "更新失敗!");
            }
        }

        private void btnCreateSaleRecord_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            var path = saveFileDialog1.FileName;

            SearchModel searchModel = new SearchModel();
            searchModel.KeyWord = txtKeyWord.Text;
            searchModel.SaleStartTime = dtpSaleStart.Value;
            searchModel.SaleEndTime = dtpSaleEnd.Value.AddDays(1);
            searchModel.Brand = cbxBrands.SelectedIndex;
            searchModel.Flavor = cbxFlavors.SelectedIndex;
            searchModel.Package = cbxPackages.SelectedIndex;
            searchModel.ProductionType = cbxType.SelectedIndex;
            searchModel.ProductionDetailType = cbxProductDetail.SelectedIndex;
            var list = _controller.GetSalesRecords(searchModel);
            var result = _controller.ExportSaleRecordExcel(list, path);
            MessageBox.Show(!result ? "匯出失敗!" : "匯出成功!");
        }

        private void btnBulkStorage_Click(object sender, EventArgs e)
        {
            try
            {
                var brand = cbxBrands.SelectedIndex;
                var package = cbxPackages.SelectedIndex;
                var productionType = cbxType.SelectedIndex;
                var productionDetailType = cbxProductDetail.SelectedIndex;
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
                        Brand = brand,
                        Flavor = flavor.Key,
                        Package = package,
                        ProductionType = productionType,
                        ProductionDetailType = productionDetailType,
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
                MessageBox.Show("更新完成", "批量更新結果");
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新失敗", "批量更新結果");
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int pageIndex = Convert.ToInt32(lblNowPage.Text);
            pageIndex++;
            int pageSize = Constant.PageSize;
            int lastIndex = pageIndex * pageSize;
            if (lastIndex > Convert.ToInt32(lblDataCount.Text) + pageSize - 1)
                return;
            lblNowPage.Text = pageIndex.ToString();
            SearchSaleRecord();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int pageIndex = Convert.ToInt32(lblNowPage.Text);
            pageIndex--;
            int pageSize = Constant.PageSize;
            int firstIndex = (pageIndex - 1) * pageSize + 1;
            if (firstIndex < 1)
                return;
            lblNowPage.Text = pageIndex.ToString();
            SearchSaleRecord();
        }

        private void cbxClassEnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            var enums = _controller.GetEnums(cbxClassEnum.SelectedIndex + 1);
            dgvEnums.DataSource = enums;
        }

        private void btnAddEnum_Click(object sender, EventArgs e)
        {
            bool result = _controller.AddEnumValue(
                tbxAddEnumDes.Text,
                tbxAddEnumKeyWord.Text,
                cbxClassEnum.SelectedIndex + 1,
                cbxAddType.SelectedIndex
                );

            if (result)
            {
                var enums = _controller.GetEnums(cbxClassEnum.SelectedIndex);
                dgvEnums.DataSource = enums;
                InitialEnumCbx();
            }
            else
            {
                MessageBox.Show("新增失敗! 請檢查格式是否正確。");
            }
        }

        private void InitialEnumCbx()
        {
            cbxBrands.Items.Clear();
            foreach (var pair in Enums.BrandEnum)
                cbxBrands.Items.Add(pair.Value.Description);
            cbxBrands.SelectedIndex = 0;

            cbxFlavors.Items.Clear();
            foreach (var pair in Enums.FlavorEnum)
                cbxFlavors.Items.Add(pair.Value.Description);
            cbxFlavors.SelectedIndex = 0;

            cbxPackages.Items.Clear();
            foreach (var pair in Enums.PackageEnum)
                cbxPackages.Items.Add(pair.Value.Description);
            cbxPackages.SelectedIndex = 0;

            cbxProductDetail.Items.Clear();
            foreach (var pair in Enums.ProductionDetailEnum)
                cbxProductDetail.Items.Add(pair.Value.Description);
            cbxProductDetail.SelectedIndex = 0;

            cbxType.Items.Clear();
            foreach (var pair in Enums.ProductionEnum)
                cbxType.Items.Add(pair.Value.Description);
            cbxType.SelectedIndex = 0;

            cbxSaleWays.Items.Clear();
            foreach (var pair in Enums.PlatEnum)
                cbxSaleWays.Items.Add(pair.Value.Description);
            cbxSaleWays.SelectedIndex = 0;

            cbxClassEnum.Items.Clear();
            foreach (var pair in Enums.ClassEnum)
                cbxClassEnum.Items.Add(pair.Value.Description);
            cbxClassEnum.SelectedIndex = 0;

            cbxAddType.Items.Clear();
            foreach (var pair in Enums.ProductionEnum)
                cbxAddType.Items.Add(pair.Value.Description);
            cbxAddType.SelectedIndex = 0;
        }

        private void tabController_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxBrands.SelectedIndex = 0;
            cbxFlavors.SelectedIndex = 0;
            cbxPackages.SelectedIndex = 0;
            cbxType.SelectedIndex = 0;
            cbxProductDetail.SelectedIndex = 0;
            cbxIsWriteOffMoney.SelectedIndex = 0;
            txtKeyWord.Text = "";

            if (((TabControl)sender).SelectedIndex == 4)
            {
                var enums = _controller.GetEnums(cbxClassEnum.SelectedIndex + 1);
                dgvEnums.DataSource = enums;
            }
        }

        private void btnPrintTransferDatas_Click(object sender, EventArgs e)
        {
            var datas = ((List<PhuraseDetailModel>)dgvSaleRecords.DataSource);
            var outputList = new List<PhuraseDetailModel>();
            foreach (DataGridViewRow row in dgvSaleRecords.Rows)
            {
                var chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value != chk.TrueValue) continue;
                outputList.Add(datas[chk.RowIndex]);
            }

            if (!outputList.Any())
            {
                MessageBox.Show("尚未勾選要印出的單據");
                return;
            }

            if (outputList.Any(o => string.IsNullOrEmpty(o.ReceiptNumber)))
            {
                MessageBox.Show("該勾選項目，尚未填入發票號碼，請重新確認", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveFileDialog1.ShowDialog();

            var path = saveFileDialog1.FileName;

            MessageBox.Show(_controller.CreatShippmentTicks(outputList, path) ? "文件產生成功" : "文件產生失敗");
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            var phurasesCopy = _phurases.ToList();
            var displayItemsCopy = _displayItems.ToList();
            foreach (DataGridViewRow row in dgvNewOrder.Rows)
            {
                var chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value != chk.TrueValue) continue;
                _phurases.Remove(phurasesCopy[chk.RowIndex]);
                _displayItems.Remove(displayItemsCopy[chk.RowIndex]);
            }
            dgvNewOrder.DataSource = _displayItems.ToList();
        }

        private void cbxIsSearchWriteOffMoneyTime_CheckedChanged(object sender, EventArgs e)
        {
            var cbx = (CheckBox)sender;
            if (cbx.Checked)
            {
                dtpWriteOffMoneyStartTime.Enabled = true;
                dtpWriteOffMoneyEndTime.Enabled = true;
            }
            else
            {
                dtpWriteOffMoneyStartTime.Enabled = false;
                dtpWriteOffMoneyEndTime.Enabled = false;
                _searchModel.WriteOffMoneyStartTime = DateTime.MinValue;
                _searchModel.WriteOffMoneyEndTime = DateTime.MaxValue;
            }
        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("確認取消已勾選訂單", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.No)
                return;

            var datas = ((List<PhuraseDetailModel>)dgvSaleRecords.DataSource);
            foreach (DataGridViewRow row in dgvSaleRecords.Rows)
            {
                var chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value != chk.TrueValue) continue;
                datas[chk.RowIndex].OrderState = OrderState.已取消;
            }

            _controller.UpdateSalesRecords(datas);

            dgvSaleRecords.DataSource = datas.ToList();
        }


    }
}