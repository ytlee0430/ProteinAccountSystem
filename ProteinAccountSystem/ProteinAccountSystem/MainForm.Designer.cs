namespace ProteinAccountSystem
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
            this.btnShowStorage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvStorage = new System.Windows.Forms.DataGridView();
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
            this.dgvSaleRecords = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreateSaleRecord = new System.Windows.Forms.Button();
            this.tbxShippingFee = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxReceipyNumber = new System.Windows.Forms.TextBox();
            this.cbsSaleWays = new System.Windows.Forms.ComboBox();
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
            this.btnImportExcelWirteOffMoney = new System.Windows.Forms.Button();
            this.tabStorage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            this.tabFunction.SuspendLayout();
            this.tabController.SuspendLayout();
            this.tabAddOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewOrder)).BeginInit();
            this.tabSaleRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleRecords)).BeginInit();
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
            this.tabStorage.Controls.Add(this.btnShowStorage);
            this.tabStorage.Controls.Add(this.panel2);
            this.tabStorage.Controls.Add(this.btnExportStockExcel);
            this.tabStorage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabStorage.Location = new System.Drawing.Point(4, 26);
            this.tabStorage.Name = "tabStorage";
            this.tabStorage.Padding = new System.Windows.Forms.Padding(3);
            this.tabStorage.Size = new System.Drawing.Size(1361, 556);
            this.tabStorage.TabIndex = 1;
            this.tabStorage.Text = "庫存";
            // 
            // btnShowStorage
            // 
            this.btnShowStorage.BackColor = System.Drawing.Color.White;
            this.btnShowStorage.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnShowStorage.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowStorage.Location = new System.Drawing.Point(1084, 6);
            this.btnShowStorage.Name = "btnShowStorage";
            this.btnShowStorage.Size = new System.Drawing.Size(271, 48);
            this.btnShowStorage.TabIndex = 6;
            this.btnShowStorage.Text = "顯示庫存";
            this.btnShowStorage.UseVisualStyleBackColor = false;
            this.btnShowStorage.Click += new System.EventHandler(this.btnShowStorage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvStorage);
            this.panel2.Location = new System.Drawing.Point(9, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 650);
            this.panel2.TabIndex = 5;
            // 
            // dgvStorage
            // 
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStorage.Location = new System.Drawing.Point(0, 0);
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.RowTemplate.Height = 24;
            this.dgvStorage.Size = new System.Drawing.Size(1346, 650);
            this.dgvStorage.TabIndex = 0;
            // 
            // btnExportStockExcel
            // 
            this.btnExportStockExcel.BackColor = System.Drawing.Color.White;
            this.btnExportStockExcel.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnExportStockExcel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExportStockExcel.Location = new System.Drawing.Point(1084, 6);
            this.btnExportStockExcel.Name = "btnExportStockExcel";
            this.btnExportStockExcel.Size = new System.Drawing.Size(271, 48);
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
            this.tabFunction.Location = new System.Drawing.Point(4, 26);
            this.tabFunction.Name = "tabFunction";
            this.tabFunction.Padding = new System.Windows.Forms.Padding(3);
            this.tabFunction.Size = new System.Drawing.Size(1361, 556);
            this.tabFunction.TabIndex = 0;
            this.tabFunction.Text = "首頁";
            // 
            // btnCreateShippmentTicket
            // 
            this.btnCreateShippmentTicket.BackColor = System.Drawing.Color.White;
            this.btnCreateShippmentTicket.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCreateShippmentTicket.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateShippmentTicket.Location = new System.Drawing.Point(465, 21);
            this.btnCreateShippmentTicket.Name = "btnCreateShippmentTicket";
            this.btnCreateShippmentTicket.Size = new System.Drawing.Size(397, 48);
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
            this.btnImportExcel.Location = new System.Drawing.Point(3, 21);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(397, 48);
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
            this.tabController.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabController.Location = new System.Drawing.Point(0, 180);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(1369, 586);
            this.tabController.TabIndex = 0;
            // 
            // tabAddOrder
            // 
            this.tabAddOrder.BackColor = System.Drawing.Color.LightGray;
            this.tabAddOrder.Controls.Add(this.btnCreateSale);
            this.tabAddOrder.Controls.Add(this.dgvNewOrder);
            this.tabAddOrder.Controls.Add(this.button1);
            this.tabAddOrder.Location = new System.Drawing.Point(4, 26);
            this.tabAddOrder.Name = "tabAddOrder";
            this.tabAddOrder.Size = new System.Drawing.Size(1361, 556);
            this.tabAddOrder.TabIndex = 2;
            this.tabAddOrder.Text = "新增訂單";
            // 
            // btnCreateSale
            // 
            this.btnCreateSale.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateSale.Location = new System.Drawing.Point(1106, 499);
            this.btnCreateSale.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateSale.Name = "btnCreateSale";
            this.btnCreateSale.Size = new System.Drawing.Size(248, 47);
            this.btnCreateSale.TabIndex = 7;
            this.btnCreateSale.Text = "確認訂單";
            this.btnCreateSale.UseVisualStyleBackColor = true;
            this.btnCreateSale.Click += new System.EventHandler(this.btnCreateSale_Click);
            // 
            // dgvNewOrder
            // 
            this.dgvNewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewOrder.Location = new System.Drawing.Point(3, 70);
            this.dgvNewOrder.Name = "dgvNewOrder";
            this.dgvNewOrder.RowTemplate.Height = 24;
            this.dgvNewOrder.Size = new System.Drawing.Size(1351, 424);
            this.dgvNewOrder.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(1090, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "新增項目";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // tabSaleRecord
            // 
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
            this.tabSaleRecord.Location = new System.Drawing.Point(4, 26);
            this.tabSaleRecord.Name = "tabSaleRecord";
            this.tabSaleRecord.Size = new System.Drawing.Size(1361, 556);
            this.tabSaleRecord.TabIndex = 4;
            this.tabSaleRecord.Text = "檢視銷貨紀錄";
            this.tabSaleRecord.UseVisualStyleBackColor = true;
            // 
            // dgvSaleRecords
            // 
            this.dgvSaleRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleRecords.Location = new System.Drawing.Point(11, 74);
            this.dgvSaleRecords.Name = "dgvSaleRecords";
            this.dgvSaleRecords.RowTemplate.Height = 24;
            this.dgvSaleRecords.Size = new System.Drawing.Size(1335, 465);
            this.dgvSaleRecords.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(551, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 27);
            this.label13.TabIndex = 48;
            this.label13.Text = "~";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(584, 20);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 27);
            this.dtpEnd.TabIndex = 47;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(344, 20);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 27);
            this.dtpStart.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(275, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 21);
            this.label12.TabIndex = 45;
            this.label12.Text = "時間 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(7, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 21);
            this.label11.TabIndex = 44;
            this.label11.Text = "帳號/姓名 :";
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtKeyWord.Location = new System.Drawing.Point(116, 20);
            this.txtKeyWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(146, 33);
            this.txtKeyWord.TabIndex = 44;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(790, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(181, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCreateSaleRecord
            // 
            this.btnCreateSaleRecord.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateSaleRecord.Location = new System.Drawing.Point(1156, 16);
            this.btnCreateSaleRecord.Name = "btnCreateSaleRecord";
            this.btnCreateSaleRecord.Size = new System.Drawing.Size(190, 37);
            this.btnCreateSaleRecord.TabIndex = 0;
            this.btnCreateSaleRecord.Text = "匯出Excel銷售紀錄";
            this.btnCreateSaleRecord.UseVisualStyleBackColor = true;
            // 
            // tbxShippingFee
            // 
            this.tbxShippingFee.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxShippingFee.Location = new System.Drawing.Point(357, 132);
            this.tbxShippingFee.Margin = new System.Windows.Forms.Padding(2);
            this.tbxShippingFee.Name = "tbxShippingFee";
            this.tbxShippingFee.Size = new System.Drawing.Size(120, 39);
            this.tbxShippingFee.TabIndex = 38;
            this.tbxShippingFee.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(352, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 27);
            this.label9.TabIndex = 37;
            this.label9.Text = "運費 :";
            // 
            // tbxReceipyNumber
            // 
            this.tbxReceipyNumber.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxReceipyNumber.Location = new System.Drawing.Point(18, 132);
            this.tbxReceipyNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbxReceipyNumber.Name = "tbxReceipyNumber";
            this.tbxReceipyNumber.Size = new System.Drawing.Size(120, 39);
            this.tbxReceipyNumber.TabIndex = 36;
            // 
            // cbsSaleWays
            // 
            this.cbsSaleWays.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbsSaleWays.FormattingEnabled = true;
            this.cbsSaleWays.Location = new System.Drawing.Point(185, 136);
            this.cbsSaleWays.Margin = new System.Windows.Forms.Padding(2);
            this.cbsSaleWays.Name = "cbsSaleWays";
            this.cbsSaleWays.Size = new System.Drawing.Size(120, 35);
            this.cbsSaleWays.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(180, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 27);
            this.label8.TabIndex = 34;
            this.label8.Text = "銷售方式 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(20, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 27);
            this.label7.TabIndex = 33;
            this.label7.Text = "發票號碼 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(850, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 27);
            this.label5.TabIndex = 30;
            this.label5.Text = "數量 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(1016, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 29;
            this.label4.Text = "金額 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(352, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "包裝 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(186, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "口味 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "品牌 :";
            // 
            // tbxSalePrice
            // 
            this.tbxSalePrice.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxSalePrice.Location = new System.Drawing.Point(1020, 45);
            this.tbxSalePrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSalePrice.Name = "tbxSalePrice";
            this.tbxSalePrice.Size = new System.Drawing.Size(120, 39);
            this.tbxSalePrice.TabIndex = 24;
            // 
            // cbxPackages
            // 
            this.cbxPackages.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxPackages.FormattingEnabled = true;
            this.cbxPackages.Location = new System.Drawing.Point(352, 45);
            this.cbxPackages.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPackages.Name = "cbxPackages";
            this.cbxPackages.Size = new System.Drawing.Size(120, 35);
            this.cbxPackages.TabIndex = 23;
            // 
            // cbxFlavors
            // 
            this.cbxFlavors.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxFlavors.FormattingEnabled = true;
            this.cbxFlavors.Location = new System.Drawing.Point(185, 45);
            this.cbxFlavors.Margin = new System.Windows.Forms.Padding(2);
            this.cbxFlavors.Name = "cbxFlavors";
            this.cbxFlavors.Size = new System.Drawing.Size(120, 35);
            this.cbxFlavors.TabIndex = 22;
            // 
            // cbxBrands
            // 
            this.cbxBrands.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxBrands.FormattingEnabled = true;
            this.cbxBrands.Location = new System.Drawing.Point(18, 45);
            this.cbxBrands.Margin = new System.Windows.Forms.Padding(2);
            this.cbxBrands.Name = "cbxBrands";
            this.cbxBrands.Size = new System.Drawing.Size(120, 35);
            this.cbxBrands.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(518, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 27);
            this.label6.TabIndex = 40;
            this.label6.Text = "細項 :";
            // 
            // cbxProductDetail
            // 
            this.cbxProductDetail.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxProductDetail.FormattingEnabled = true;
            this.cbxProductDetail.Location = new System.Drawing.Point(519, 45);
            this.cbxProductDetail.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProductDetail.Name = "cbxProductDetail";
            this.cbxProductDetail.Size = new System.Drawing.Size(120, 35);
            this.cbxProductDetail.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(684, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 27);
            this.label10.TabIndex = 42;
            this.label10.Text = "分類 :";
            // 
            // cbxType
            // 
            this.cbxType.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(686, 45);
            this.cbxType.Margin = new System.Windows.Forms.Padding(2);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(120, 35);
            this.cbxType.TabIndex = 41;
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(855, 45);
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(120, 22);
            this.nudCount.TabIndex = 43;
            // 
            // btnImportExcelWirteOffMoney
            // 
            this.btnImportExcelWirteOffMoney.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnImportExcelWirteOffMoney.Location = new System.Drawing.Point(976, 16);
            this.btnImportExcelWirteOffMoney.Name = "btnImportExcelWirteOffMoney";
            this.btnImportExcelWirteOffMoney.Size = new System.Drawing.Size(175, 37);
            this.btnImportExcelWirteOffMoney.TabIndex = 50;
            this.btnImportExcelWirteOffMoney.Text = "匯入Excel銷帳";
            this.btnImportExcelWirteOffMoney.UseVisualStyleBackColor = true;
            this.btnImportExcelWirteOffMoney.Click += new System.EventHandler(this.btnImportExcelWirteOffMoney_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 778);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxProductDetail);
            this.Controls.Add(this.tbxShippingFee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxReceipyNumber);
            this.Controls.Add(this.cbsSaleWays);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.tabStorage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            this.tabFunction.ResumeLayout(false);
            this.tabController.ResumeLayout(false);
            this.tabAddOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewOrder)).EndInit();
            this.tabSaleRecord.ResumeLayout(false);
            this.tabSaleRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabStorage;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.ComboBox cbsSaleWays;
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
    }
}

