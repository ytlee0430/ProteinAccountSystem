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
                var item = new Item
                {
                    Brand = cbxBrands.SelectedIndex,
                    Flavor = cbxFlavors.SelectedIndex,
                    Package = cbxPackages.SelectedIndex,
                    ProductionType = cbxType.SelectedIndex,
                    ProductionDetailType = cbxProductDetail.SelectedIndex,
                };
                item.ItemCode = ProductUtilities.GetItemCodes(item);

                _controller.AddPhuraseProduct(item, (int)nudCount.Value, Convert.ToInt32(tbxSalePrice.Text));

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
            catch (Exception)
            {
                MessageBox.Show("輸入參數有錯，請重新確認");
            }
        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("是否確認新增訂單? ", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var model = _controller.CreateSale(Convert.ToInt32(tbxShippingFee.Text), tbxReceipyNumber.Text, cbxSaleWays.SelectedIndex, tbxCompanyName.Text, tbxInvoiceNumber.Text);
                model.OrderCreateTime = DateTime.Now;
                _controller.AddDBlientPhuraseRecord(new List<PhuraseDetailModel>() { model });
                _controller.UpdateDBStorage(new List<PhuraseDetailModel>() { model });

                _displayItems.Clear();

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
            MessageBox.Show(!result ? "匯出失敗!" : "匯出成功!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _searchModel.KeyWord = txtKeyWord.Text;
            _searchModel.StartTime = dtpSaleStart.Value.Date;
            _searchModel.EndTime = dtpSaleEnd.Value.Date.AddDays(1);
            _searchModel.Brand = cbxBrands.SelectedIndex;
            _searchModel.Flavor = cbxFlavors.SelectedIndex;
            _searchModel.Package = cbxPackages.SelectedIndex;
            _searchModel.ProductionType = cbxType.SelectedIndex;
            _searchModel.ProductionDetailType = cbxProductDetail.SelectedIndex;
            _searchModel.IsWriteOffMoney = cbxIsWriteOffMoney.SelectedIndex - 1;
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
            dgvSaleRecords.Columns.Add(dgvck);
            
            //create button
            DataGridViewButtonColumn dgvbt = new DataGridViewButtonColumn();
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
        }

        private void DgvSaleRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
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

            if (e.ColumnIndex != 11 || e.RowIndex < 0)
                return;
            var y = e.RowIndex;
            var list = (List<PhuraseDetailModel>)dgvSaleRecords.DataSource;
            list[y].IsWriteOffMoney = !list[y].IsWriteOffMoney;
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
            catch (Exception )
            {
                MessageBox.Show("輸入資料有誤，請重新確認");
                throw;
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
            searchModel.StartTime = dtpSaleStart.Value;
            searchModel.EndTime = dtpSaleEnd.Value;
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
            MessageBox.Show("更新完成!");
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
            var enums = _controller.GetEnums(cbxClassEnum.SelectedIndex);
            dgvEnums.DataSource = enums;
        }

        private void btnAddEnum_Click(object sender, EventArgs e)
        {
            bool result = _controller.AddEnumValue(
                tbxAddEnumDes.Text,
                tbxAddEnumKeyWord.Text,
                cbxClassEnum.SelectedIndex,
                (int)nudAddEnumParent.Value
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
        }

        private void btnPrintTransferDatas_Click(object sender, EventArgs e)
        {

        }


    }
}