namespace View
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabStorage = new System.Windows.Forms.TabPage();
            this.btnBulkStorage = new System.Windows.Forms.Button();
            this.ckbShowCountZero = new System.Windows.Forms.CheckBox();
            this.ckbEnableChange = new System.Windows.Forms.CheckBox();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.dgvStorage = new System.Windows.Forms.DataGridView();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnShowStorage = new System.Windows.Forms.Button();
            this.btnExportStockExcel = new System.Windows.Forms.Button();
            this.tabFunction = new System.Windows.Forms.TabPage();
            this.btnCreateShippmentTicket = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabAddOrder = new System.Windows.Forms.TabPage();
            this.btnCreateSale = new System.Windows.Forms.Button();
            this.dgvNewOrder = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabSaleRecord = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.lblDataCount = new System.Windows.Forms.Label();
            this.lblNowPage = new System.Windows.Forms.Label();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.cbxIsWriteOffMoney = new System.Windows.Forms.ComboBox();
            this.btnUpdateSalesRecords = new System.Windows.Forms.Button();
            this.btnImportExcelWirteOffMoney = new System.Windows.Forms.Button();
            this.dgvSaleRecords = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreateSaleRecord = new System.Windows.Forms.Button();
            this.tabClassEnum = new System.Windows.Forms.TabPage();
            this.nudAddEnumParent = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbxAddEnumKeyWord = new System.Windows.Forms.TextBox();
            this.btnAddEnum = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxAddEnumDes = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxClassEnum = new System.Windows.Forms.ComboBox();
            this.dgvEnums = new System.Windows.Forms.DataGridView();
            this.tbxShippingFee = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxReceipyNumber = new System.Windows.Forms.TextBox();
            this.cbxSaleWays = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSalePrice = new System.Windows.Forms.TextBox();
            this.cbxPackages = new System.Windows.Forms.ComboBox();
            this.cbxFlavors = new System.Windows.Forms.ComboBox();
            this.cbxBrands = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxProductDetail = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpExpireDate = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbxInvoiceNumber = new System.Windows.Forms.TextBox();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.tabStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            this.tabFunction.SuspendLayout();
            this.tabController.SuspendLayout();
            this.tabAddOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewOrder)).BeginInit();
            this.tabSaleRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleRecords)).BeginInit();
            this.tabClassEnum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddEnumParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabStorage
            // 
            this.tabStorage.BackColor = System.Drawing.Color.LightGray;
            this.tabStorage.Controls.Add(this.btnBulkStorage);
            this.tabStorage.Controls.Add(this.ckbShowCountZero);
            this.tabStorage.Controls.Add(this.ckbEnableChange);
            this.tabStorage.Controls.Add(this.btnUpdateItem);
            this.tabStorage.Controls.Add(this.dgvStorage);
            this.tabStorage.Controls.Add(this.btnAddNewItem);
            this.tabStorage.Controls.Add(this.btnShowStorage);
            this.tabStorage.Controls.Add(this.btnExportStockExcel);
            this.tabStorage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabStorage.Location = new System.Drawing.Point(4, 34);
            this.tabStorage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabStorage.Name = "tabStorage";
            this.tabStorage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabStorage.Size = new System.Drawing.Size(2270, 1036);
            this.tabStorage.TabIndex = 1;
            this.tabStorage.Text = "庫存";
            // 
            // btnBulkStorage
            // 
            this.btnBulkStorage.BackColor = System.Drawing.Color.White;
            this.btnBulkStorage.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBulkStorage.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBulkStorage.Location = new System.Drawing.Point(318, 9);
            this.btnBulkStorage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBulkStorage.Name = "btnBulkStorage";
            this.btnBulkStorage.Size = new System.Drawing.Size(296, 72);
            this.btnBulkStorage.TabIndex = 11;
            this.btnBulkStorage.Text = "批量所有口味";
            this.btnBulkStorage.UseVisualStyleBackColor = false;
            this.btnBulkStorage.Click += new System.EventHandler(this.btnBulkStorage_Click);
            // 
            // ckbShowCountZero
            // 
            this.ckbShowCountZero.AutoSize = true;
            this.ckbShowCountZero.Checked = true;
            this.ckbShowCountZero.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbShowCountZero.Location = new System.Drawing.Point(1536, 52);
            this.ckbShowCountZero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbShowCountZero.Name = "ckbShowCountZero";
            this.ckbShowCountZero.Size = new System.Drawing.Size(228, 28);
            this.ckbShowCountZero.TabIndex = 10;
            this.ckbShowCountZero.Text = "顯示庫存為零品項";
            this.ckbShowCountZero.UseVisualStyleBackColor = true;
            // 
            // ckbEnableChange
            // 
            this.ckbEnableChange.AutoSize = true;
            this.ckbEnableChange.Location = new System.Drawing.Point(1536, 10);
            this.ckbEnableChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbEnableChange.Name = "ckbEnableChange";
            this.ckbEnableChange.Size = new System.Drawing.Size(156, 28);
            this.ckbEnableChange.TabIndex = 9;
            this.ckbEnableChange.Text = "可更新資料";
            this.ckbEnableChange.UseVisualStyleBackColor = true;
            this.ckbEnableChange.CheckedChanged += new System.EventHandler(this.ckbEnableChange_CheckedChanged);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.BackColor = System.Drawing.Color.White;
            this.btnUpdateItem.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnUpdateItem.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdateItem.Location = new System.Drawing.Point(1232, 10);
            this.btnUpdateItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(296, 72);
            this.btnUpdateItem.TabIndex = 8;
            this.btnUpdateItem.Text = "更新庫存資料";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // dgvStorage
            // 
            this.dgvStorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStorage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Location = new System.Drawing.Point(14, 90);
            this.dgvStorage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.ReadOnly = true;
            this.dgvStorage.RowTemplate.Height = 24;
            this.dgvStorage.Size = new System.Drawing.Size(2223, 910);
            this.dgvStorage.TabIndex = 0;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.BackColor = System.Drawing.Color.White;
            this.btnAddNewItem.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAddNewItem.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddNewItem.Location = new System.Drawing.Point(14, 9);
            this.btnAddNewItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(296, 72);
            this.btnAddNewItem.TabIndex = 7;
            this.btnAddNewItem.Text = "建立庫存";
            this.btnAddNewItem.UseVisualStyleBackColor = false;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // btnShowStorage
            // 
            this.btnShowStorage.BackColor = System.Drawing.Color.White;
            this.btnShowStorage.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnShowStorage.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowStorage.Location = new System.Drawing.Point(622, 9);
            this.btnShowStorage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowStorage.Name = "btnShowStorage";
            this.btnShowStorage.Size = new System.Drawing.Size(296, 72);
            this.btnShowStorage.TabIndex = 6;
            this.btnShowStorage.Text = "顯示庫存";
            this.btnShowStorage.UseVisualStyleBackColor = false;
            this.btnShowStorage.Click += new System.EventHandler(this.btnShowStorage_Click);
            // 
            // btnExportStockExcel
            // 
            this.btnExportStockExcel.BackColor = System.Drawing.Color.White;
            this.btnExportStockExcel.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnExportStockExcel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExportStockExcel.Location = new System.Drawing.Point(927, 9);
            this.btnExportStockExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportStockExcel.Name = "btnExportStockExcel";
            this.btnExportStockExcel.Size = new System.Drawing.Size(296, 72);
            this.btnExportStockExcel.TabIndex = 4;
            this.btnExportStockExcel.Text = "匯出庫存成Excel";
            this.btnExportStockExcel.UseVisualStyleBackColor = false;
            this.btnExportStockExcel.Click += new System.EventHandler(this.btnExportStockExcel_Click);
            // 
            // tabFunction
            // 
            this.tabFunction.BackColor = System.Drawing.Color.LightGray;
            this.tabFunction.Controls.Add(this.btnCreateShippmentTicket);
            this.tabFunction.Controls.Add(this.btnImportExcel);
            this.tabFunction.Location = new System.Drawing.Point(4, 34);
            this.tabFunction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabFunction.Name = "tabFunction";
            this.tabFunction.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabFunction.Size = new System.Drawing.Size(2270, 1036);
            this.tabFunction.TabIndex = 0;
            this.tabFunction.Text = "首頁";
            // 
            // btnCreateShippmentTicket
            // 
            this.btnCreateShippmentTicket.BackColor = System.Drawing.Color.White;
            this.btnCreateShippmentTicket.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCreateShippmentTicket.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateShippmentTicket.Location = new System.Drawing.Point(698, 32);
            this.btnCreateShippmentTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateShippmentTicket.Name = "btnCreateShippmentTicket";
            this.btnCreateShippmentTicket.Size = new System.Drawing.Size(596, 72);
            this.btnCreateShippmentTicket.TabIndex = 1;
            this.btnCreateShippmentTicket.Text = "產生寄件資訊單";
            this.btnCreateShippmentTicket.UseVisualStyleBackColor = false;
            this.btnCreateShippmentTicket.Click += new System.EventHandler(this.btnCreateShippmentTicket_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.Color.White;
            this.btnImportExcel.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnImportExcel.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnImportExcel.Location = new System.Drawing.Point(4, 32);
            this.btnImportExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(596, 72);
            this.btnImportExcel.TabIndex = 0;
            this.btnImportExcel.Text = "匯入蝦皮出貨資料並更新庫存";
            this.btnImportExcel.UseVisualStyleBackColor = false;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabFunction);
            this.tabController.Controls.Add(this.tabStorage);
            this.tabController.Controls.Add(this.tabAddOrder);
            this.tabController.Controls.Add(this.tabSaleRecord);
            this.tabController.Controls.Add(this.tabClassEnum);
            this.tabController.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabController.Location = new System.Drawing.Point(0, 270);
            this.tabController.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(2278, 1028);
            this.tabController.TabIndex = 0;
            this.tabController.SelectedIndexChanged += new System.EventHandler(this.tabController_SelectedIndexChanged);
            // 
            // tabAddOrder
            // 
            this.tabAddOrder.BackColor = System.Drawing.Color.LightGray;
            this.tabAddOrder.Controls.Add(this.btnCreateSale);
            this.tabAddOrder.Controls.Add(this.dgvNewOrder);
            this.tabAddOrder.Controls.Add(this.button1);
            this.tabAddOrder.Location = new System.Drawing.Point(4, 34);
            this.tabAddOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAddOrder.Name = "tabAddOrder";
            this.tabAddOrder.Size = new System.Drawing.Size(2270, 1036);
            this.tabAddOrder.TabIndex = 2;
            this.tabAddOrder.Text = "新增訂單";
            // 
            // btnCreateSale
            // 
            this.btnCreateSale.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateSale.Location = new System.Drawing.Point(1870, 945);
            this.btnCreateSale.Name = "btnCreateSale";
            this.btnCreateSale.Size = new System.Drawing.Size(372, 70);
            this.btnCreateSale.TabIndex = 7;
            this.btnCreateSale.Text = "確認訂單";
            this.btnCreateSale.UseVisualStyleBackColor = true;
            this.btnCreateSale.Click += new System.EventHandler(this.btnCreateSale_Click);
            // 
            // dgvNewOrder
            // 
            this.dgvNewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewOrder.Location = new System.Drawing.Point(8, 84);
            this.dgvNewOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNewOrder.Name = "dgvNewOrder";
            this.dgvNewOrder.RowTemplate.Height = 24;
            this.dgvNewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNewOrder.Size = new System.Drawing.Size(2228, 854);
            this.dgvNewOrder.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(8, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(396, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "新增項目";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // tabSaleRecord
            // 
            this.tabSaleRecord.Controls.Add(this.label18);
            this.tabSaleRecord.Controls.Add(this.lblDataCount);
            this.tabSaleRecord.Controls.Add(this.lblNowPage);
            this.tabSaleRecord.Controls.Add(this.btnNextPage);
            this.tabSaleRecord.Controls.Add(this.btnPreviousPage);
            this.tabSaleRecord.Controls.Add(this.cbxIsWriteOffMoney);
            this.tabSaleRecord.Controls.Add(this.btnUpdateSalesRecords);
            this.tabSaleRecord.Controls.Add(this.btnImportExcelWirteOffMoney);
            this.tabSaleRecord.Controls.Add(this.dgvSaleRecords);
            this.tabSaleRecord.Controls.Add(this.label13);
            this.tabSaleRecord.Controls.Add(this.dtpEnd);
            this.tabSaleRecord.Controls.Add(this.dtpStart);
            this.tabSaleRecord.Controls.Add(this.label12);
            this.tabSaleRecord.Controls.Add(this.label11);
            this.tabSaleRecord.Controls.Add(this.txtKeyWord);
            this.tabSaleRecord.Controls.Add(this.btnSearch);
            this.tabSaleRecord.Controls.Add(this.btnCreateSaleRecord);
            this.tabSaleRecord.Location = new System.Drawing.Point(4, 34);
            this.tabSaleRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSaleRecord.Name = "tabSaleRecord";
            this.tabSaleRecord.Size = new System.Drawing.Size(2270, 990);
            this.tabSaleRecord.TabIndex = 4;
            this.tabSaleRecord.Text = "檢視銷貨紀錄";
            this.tabSaleRecord.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1443, 951);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 24);
            this.label18.TabIndex = 56;
            this.label18.Text = "筆資料";
            // 
            // lblDataCount
            // 
            this.lblDataCount.AutoSize = true;
            this.lblDataCount.Location = new System.Drawing.Point(1340, 951);
            this.lblDataCount.Name = "lblDataCount";
            this.lblDataCount.Size = new System.Drawing.Size(21, 24);
            this.lblDataCount.TabIndex = 55;
            this.lblDataCount.Text = "1";
            // 
            // lblNowPage
            // 
            this.lblNowPage.AutoSize = true;
            this.lblNowPage.Location = new System.Drawing.Point(1048, 951);
            this.lblNowPage.Name = "lblNowPage";
            this.lblNowPage.Size = new System.Drawing.Size(21, 24);
            this.lblNowPage.TabIndex = 54;
            this.lblNowPage.Text = "1";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(1094, 946);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(140, 34);
            this.btnNextPage.TabIndex = 53;
            this.btnNextPage.Text = "下一頁";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(876, 946);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(152, 34);
            this.btnPreviousPage.TabIndex = 52;
            this.btnPreviousPage.Text = "前一頁";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // cbxIsWriteOffMoney
            // 
            this.cbxIsWriteOffMoney.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxIsWriteOffMoney.FormattingEnabled = true;
            this.cbxIsWriteOffMoney.Items.AddRange(new object[] {
            "全部",
            "未銷帳",
            "已銷帳"});
            this.cbxIsWriteOffMoney.Location = new System.Drawing.Point(992, 27);
            this.cbxIsWriteOffMoney.Name = "cbxIsWriteOffMoney";
            this.cbxIsWriteOffMoney.Size = new System.Drawing.Size(139, 48);
            this.cbxIsWriteOffMoney.TabIndex = 48;
            // 
            // btnUpdateSalesRecords
            // 
            this.btnUpdateSalesRecords.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdateSalesRecords.Location = new System.Drawing.Point(1936, 21);
            this.btnUpdateSalesRecords.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdateSalesRecords.Name = "btnUpdateSalesRecords";
            this.btnUpdateSalesRecords.Size = new System.Drawing.Size(285, 56);
            this.btnUpdateSalesRecords.TabIndex = 51;
            this.btnUpdateSalesRecords.Text = "更新銷售紀錄";
            this.btnUpdateSalesRecords.UseVisualStyleBackColor = true;
            this.btnUpdateSalesRecords.Click += new System.EventHandler(this.btnUpdateSalesRecords_Click);
            // 
            // btnImportExcelWirteOffMoney
            // 
            this.btnImportExcelWirteOffMoney.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnImportExcelWirteOffMoney.Location = new System.Drawing.Point(1372, 22);
            this.btnImportExcelWirteOffMoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImportExcelWirteOffMoney.Name = "btnImportExcelWirteOffMoney";
            this.btnImportExcelWirteOffMoney.Size = new System.Drawing.Size(262, 56);
            this.btnImportExcelWirteOffMoney.TabIndex = 50;
            this.btnImportExcelWirteOffMoney.Text = "匯入Excel銷帳";
            this.btnImportExcelWirteOffMoney.UseVisualStyleBackColor = true;
            this.btnImportExcelWirteOffMoney.Click += new System.EventHandler(this.btnImportExcelWirteOffMoney_Click);
            // 
            // dgvSaleRecords
            // 
            this.dgvSaleRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSaleRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSaleRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleRecords.Location = new System.Drawing.Point(16, 106);
            this.dgvSaleRecords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSaleRecords.Name = "dgvSaleRecords";
            this.dgvSaleRecords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSaleRecords.RowTemplate.Height = 24;
            this.dgvSaleRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSaleRecords.Size = new System.Drawing.Size(3626, 1228);
            this.dgvSaleRecords.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(724, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 40);
            this.label13.TabIndex = 48;
            this.label13.Text = "-";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(762, 33);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(214, 36);
            this.dtpEnd.TabIndex = 47;
            this.dtpEnd.Value = new System.DateTime(2019, 6, 4, 0, 0, 0, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(496, 33);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(214, 36);
            this.dtpStart.TabIndex = 46;
            this.dtpStart.Value = new System.DateTime(2019, 6, 4, 0, 7, 13, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(399, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 32);
            this.label12.TabIndex = 45;
            this.label12.Text = "時間 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(10, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 32);
            this.label11.TabIndex = 44;
            this.label11.Text = "帳號/姓名 :";
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtKeyWord.Location = new System.Drawing.Point(179, 29);
            this.txtKeyWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(217, 45);
            this.txtKeyWord.TabIndex = 44;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(1144, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(219, 56);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCreateSaleRecord
            // 
            this.btnCreateSaleRecord.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateSaleRecord.Location = new System.Drawing.Point(1642, 24);
            this.btnCreateSaleRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateSaleRecord.Name = "btnCreateSaleRecord";
            this.btnCreateSaleRecord.Size = new System.Drawing.Size(285, 56);
            this.btnCreateSaleRecord.TabIndex = 0;
            this.btnCreateSaleRecord.Text = "匯出Excel銷售紀錄";
            this.btnCreateSaleRecord.UseVisualStyleBackColor = true;
            this.btnCreateSaleRecord.Click += new System.EventHandler(this.btnCreateSaleRecord_Click);
            // 
            // tabClassEnum
            // 
            this.tabClassEnum.Controls.Add(this.nudAddEnumParent);
            this.tabClassEnum.Controls.Add(this.label21);
            this.tabClassEnum.Controls.Add(this.label20);
            this.tabClassEnum.Controls.Add(this.tbxAddEnumKeyWord);
            this.tabClassEnum.Controls.Add(this.btnAddEnum);
            this.tabClassEnum.Controls.Add(this.label19);
            this.tabClassEnum.Controls.Add(this.tbxAddEnumDes);
            this.tabClassEnum.Controls.Add(this.label17);
            this.tabClassEnum.Controls.Add(this.cbxClassEnum);
            this.tabClassEnum.Controls.Add(this.dgvEnums);
            this.tabClassEnum.Location = new System.Drawing.Point(4, 34);
            this.tabClassEnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabClassEnum.Name = "tabClassEnum";
            this.tabClassEnum.Size = new System.Drawing.Size(2270, 990);
            this.tabClassEnum.TabIndex = 5;
            this.tabClassEnum.Text = "管理分類";
            this.tabClassEnum.UseVisualStyleBackColor = true;
            // 
            // nudAddEnumParent
            // 
            this.nudAddEnumParent.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nudAddEnumParent.Location = new System.Drawing.Point(1425, 26);
            this.nudAddEnumParent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudAddEnumParent.Name = "nudAddEnumParent";
            this.nudAddEnumParent.Size = new System.Drawing.Size(180, 56);
            this.nudAddEnumParent.TabIndex = 48;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label21.Location = new System.Drawing.Point(1216, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(197, 40);
            this.label21.TabIndex = 54;
            this.label21.Text = "大項分類 :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(843, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(157, 40);
            this.label20.TabIndex = 52;
            this.label20.Text = "關鍵字 :";
            // 
            // tbxAddEnumKeyWord
            // 
            this.tbxAddEnumKeyWord.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxAddEnumKeyWord.Location = new System.Drawing.Point(1010, 26);
            this.tbxAddEnumKeyWord.Name = "tbxAddEnumKeyWord";
            this.tbxAddEnumKeyWord.Size = new System.Drawing.Size(178, 55);
            this.tbxAddEnumKeyWord.TabIndex = 53;
            // 
            // btnAddEnum
            // 
            this.btnAddEnum.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddEnum.Location = new System.Drawing.Point(1694, 32);
            this.btnAddEnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEnum.Name = "btnAddEnum";
            this.btnAddEnum.Size = new System.Drawing.Size(219, 56);
            this.btnAddEnum.TabIndex = 51;
            this.btnAddEnum.Text = "加入";
            this.btnAddEnum.UseVisualStyleBackColor = true;
            this.btnAddEnum.Click += new System.EventHandler(this.btnAddEnum_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(440, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(197, 40);
            this.label19.TabIndex = 48;
            this.label19.Text = "加入描述 :";
            // 
            // tbxAddEnumDes
            // 
            this.tbxAddEnumDes.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxAddEnumDes.Location = new System.Drawing.Point(657, 26);
            this.tbxAddEnumDes.Name = "tbxAddEnumDes";
            this.tbxAddEnumDes.Size = new System.Drawing.Size(178, 55);
            this.tbxAddEnumDes.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(24, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 40);
            this.label17.TabIndex = 48;
            this.label17.Text = "分類 :";
            // 
            // cbxClassEnum
            // 
            this.cbxClassEnum.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxClassEnum.FormattingEnabled = true;
            this.cbxClassEnum.Location = new System.Drawing.Point(165, 32);
            this.cbxClassEnum.Name = "cbxClassEnum";
            this.cbxClassEnum.Size = new System.Drawing.Size(266, 48);
            this.cbxClassEnum.TabIndex = 48;
            this.cbxClassEnum.SelectedIndexChanged += new System.EventHandler(this.cbxClassEnum_SelectedIndexChanged);
            // 
            // dgvEnums
            // 
            this.dgvEnums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEnums.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEnums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnums.Location = new System.Drawing.Point(28, 105);
            this.dgvEnums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEnums.Name = "dgvEnums";
            this.dgvEnums.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEnums.RowTemplate.Height = 24;
            this.dgvEnums.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEnums.Size = new System.Drawing.Size(2210, 865);
            this.dgvEnums.TabIndex = 50;
            // 
            // tbxShippingFee
            // 
            this.tbxShippingFee.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxShippingFee.Location = new System.Drawing.Point(492, 198);
            this.tbxShippingFee.Name = "tbxShippingFee";
            this.tbxShippingFee.Size = new System.Drawing.Size(178, 55);
            this.tbxShippingFee.TabIndex = 38;
            this.tbxShippingFee.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(492, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 40);
            this.label9.TabIndex = 37;
            this.label9.Text = "運費 :";
            // 
            // tbxReceipyNumber
            // 
            this.tbxReceipyNumber.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxReceipyNumber.Location = new System.Drawing.Point(27, 198);
            this.tbxReceipyNumber.Name = "tbxReceipyNumber";
            this.tbxReceipyNumber.Size = new System.Drawing.Size(178, 55);
            this.tbxReceipyNumber.TabIndex = 36;
            // 
            // cbxSaleWays
            // 
            this.cbxSaleWays.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxSaleWays.FormattingEnabled = true;
            this.cbxSaleWays.Location = new System.Drawing.Point(260, 204);
            this.cbxSaleWays.Name = "cbxSaleWays";
            this.cbxSaleWays.Size = new System.Drawing.Size(178, 48);
            this.cbxSaleWays.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(260, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 40);
            this.label8.TabIndex = 34;
            this.label8.Text = "銷售方式 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(27, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 40);
            this.label7.TabIndex = 33;
            this.label7.Text = "發票號碼 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(1552, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 40);
            this.label5.TabIndex = 30;
            this.label5.Text = "數量 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(1798, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 40);
            this.label4.TabIndex = 29;
            this.label4.Text = "金額 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(596, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 40);
            this.label3.TabIndex = 28;
            this.label3.Text = "包裝 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(279, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 40);
            this.label2.TabIndex = 27;
            this.label2.Text = "口味 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "品牌 :";
            // 
            // tbxSalePrice
            // 
            this.tbxSalePrice.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxSalePrice.Location = new System.Drawing.Point(1804, 68);
            this.tbxSalePrice.Name = "tbxSalePrice";
            this.tbxSalePrice.Size = new System.Drawing.Size(178, 55);
            this.tbxSalePrice.TabIndex = 24;
            // 
            // cbxPackages
            // 
            this.cbxPackages.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxPackages.FormattingEnabled = true;
            this.cbxPackages.Location = new System.Drawing.Point(596, 68);
            this.cbxPackages.Name = "cbxPackages";
            this.cbxPackages.Size = new System.Drawing.Size(178, 48);
            this.cbxPackages.TabIndex = 23;
            // 
            // cbxFlavors
            // 
            this.cbxFlavors.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxFlavors.FormattingEnabled = true;
            this.cbxFlavors.Location = new System.Drawing.Point(278, 68);
            this.cbxFlavors.Name = "cbxFlavors";
            this.cbxFlavors.Size = new System.Drawing.Size(280, 48);
            this.cbxFlavors.TabIndex = 22;
            // 
            // cbxBrands
            // 
            this.cbxBrands.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxBrands.FormattingEnabled = true;
            this.cbxBrands.Location = new System.Drawing.Point(27, 68);
            this.cbxBrands.Name = "cbxBrands";
            this.cbxBrands.Size = new System.Drawing.Size(178, 48);
            this.cbxBrands.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(855, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 40);
            this.label6.TabIndex = 40;
            this.label6.Text = "細項 :";
            // 
            // cbxProductDetail
            // 
            this.cbxProductDetail.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxProductDetail.FormattingEnabled = true;
            this.cbxProductDetail.Location = new System.Drawing.Point(856, 68);
            this.cbxProductDetail.Name = "cbxProductDetail";
            this.cbxProductDetail.Size = new System.Drawing.Size(284, 48);
            this.cbxProductDetail.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(1179, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 40);
            this.label10.TabIndex = 42;
            this.label10.Text = "分類 :";
            // 
            // cbxType
            // 
            this.cbxType.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(1182, 68);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(294, 48);
            this.cbxType.TabIndex = 41;
            // 
            // nudCount
            // 
            this.nudCount.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nudCount.Location = new System.Drawing.Point(1560, 68);
            this.nudCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(180, 56);
            this.nudCount.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(724, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 40);
            this.label14.TabIndex = 31;
            this.label14.Text = "折扣(%) :";
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxDiscount.Location = new System.Drawing.Point(724, 198);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(178, 55);
            this.tbxDiscount.TabIndex = 30;
            this.tbxDiscount.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(957, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 40);
            this.label15.TabIndex = 33;
            this.label15.Text = "成本 :";
            // 
            // tbxCost
            // 
            this.tbxCost.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxCost.Location = new System.Drawing.Point(957, 198);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(178, 55);
            this.tbxCost.TabIndex = 32;
            this.tbxCost.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(2844, 220);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(197, 40);
            this.label16.TabIndex = 45;
            this.label16.Text = "有效期限 :";
            // 
            // dtpExpireDate
            // 
            this.dtpExpireDate.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpExpireDate.Location = new System.Drawing.Point(2854, 297);
            this.dtpExpireDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpExpireDate.Name = "dtpExpireDate";
            this.dtpExpireDate.Size = new System.Drawing.Size(445, 51);
            this.dtpExpireDate.TabIndex = 47;
            this.dtpExpireDate.Value = new System.DateTime(2019, 6, 3, 0, 45, 27, 0);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label22.Location = new System.Drawing.Point(1566, 147);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(177, 40);
            this.label22.TabIndex = 48;
            this.label22.Text = "統一編號";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label23.Location = new System.Drawing.Point(1195, 147);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(177, 40);
            this.label23.TabIndex = 49;
            this.label23.Text = "公司抬頭";
            // 
            // tbxInvoiceNumber
            // 
            this.tbxInvoiceNumber.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxInvoiceNumber.Location = new System.Drawing.Point(1573, 197);
            this.tbxInvoiceNumber.Name = "tbxInvoiceNumber";
            this.tbxInvoiceNumber.Size = new System.Drawing.Size(267, 55);
            this.tbxInvoiceNumber.TabIndex = 50;
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxCompanyName.Location = new System.Drawing.Point(1193, 197);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.Size = new System.Drawing.Size(305, 55);
            this.tbxCompanyName.TabIndex = 51;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2297, 1311);
            this.Controls.Add(this.tbxCompanyName);
            this.Controls.Add(this.tbxInvoiceNumber);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dtpExpireDate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.tbxCost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbxDiscount);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxProductDetail);
            this.Controls.Add(this.tbxShippingFee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxReceipyNumber);
            this.Controls.Add(this.cbxSaleWays);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSalePrice);
            this.Controls.Add(this.cbxPackages);
            this.Controls.Add(this.cbxFlavors);
            this.Controls.Add(this.cbxBrands);
            this.Controls.Add(this.tabController);
            this.Name = "MainForm";
            this.tabStorage.ResumeLayout(false);
            this.tabStorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            this.tabFunction.ResumeLayout(false);
            this.tabController.ResumeLayout(false);
            this.tabAddOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewOrder)).EndInit();
            this.tabSaleRecord.ResumeLayout(false);
            this.tabSaleRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleRecords)).EndInit();
            this.tabClassEnum.ResumeLayout(false);
            this.tabClassEnum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddEnumParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabStorage;
        private System.Windows.Forms.Button btnExportStockExcel;
        private System.Windows.Forms.TabPage tabFunction;
        private System.Windows.Forms.Button btnCreateShippmentTicket;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.DataGridView dgvStorage;
        private System.Windows.Forms.Button btnShowStorage;
        private System.Windows.Forms.TextBox tbxShippingFee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxReceipyNumber;
        private System.Windows.Forms.ComboBox cbxSaleWays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSalePrice;
        private System.Windows.Forms.ComboBox cbxPackages;
        private System.Windows.Forms.ComboBox cbxFlavors;
        private System.Windows.Forms.ComboBox cbxBrands;
        private System.Windows.Forms.TabPage tabAddOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvNewOrder;
        private System.Windows.Forms.Button btnCreateSale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxProductDetail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.TabPage tabSaleRecord;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCreateSaleRecord;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvSaleRecords;
        private System.Windows.Forms.Button btnImportExcelWirteOffMoney;
        private System.Windows.Forms.Button btnUpdateSalesRecords;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.CheckBox ckbEnableChange;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.CheckBox ckbShowCountZero;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpExpireDate;
        private System.Windows.Forms.Button btnBulkStorage;
        private System.Windows.Forms.ComboBox cbxIsWriteOffMoney;
        private System.Windows.Forms.Label lblNowPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblDataCount;
        private System.Windows.Forms.TabPage tabClassEnum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxClassEnum;
        private System.Windows.Forms.DataGridView dgvEnums;
        private System.Windows.Forms.Button btnAddEnum;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxAddEnumDes;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbxAddEnumKeyWord;
        private System.Windows.Forms.NumericUpDown nudAddEnumParent;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbxInvoiceNumber;
        private System.Windows.Forms.TextBox tbxCompanyName;
    }
}

