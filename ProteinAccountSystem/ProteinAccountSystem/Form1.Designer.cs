namespace ProteinAccountSystem
{
    partial class Form1
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExportStockExcel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnCreateShippmentTicket = new System.Windows.Forms.Button();
            this.btnCreateNewSale = new System.Windows.Forms.Button();
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabController.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.btnExportStockExcel);
            this.tabPage2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1361, 736);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "庫存";
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(9, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 650);
            this.panel2.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.btnCreateNewSale);
            this.tabPage1.Controls.Add(this.btnCreateShippmentTicket);
            this.tabPage1.Controls.Add(this.btnImportExcel);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1361, 736);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "首頁";
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
            // btnCreateNewSale
            // 
            this.btnCreateNewSale.BackColor = System.Drawing.Color.White;
            this.btnCreateNewSale.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCreateNewSale.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateNewSale.Location = new System.Drawing.Point(3, 96);
            this.btnCreateNewSale.Name = "btnCreateNewSale";
            this.btnCreateNewSale.Size = new System.Drawing.Size(397, 48);
            this.btnCreateNewSale.TabIndex = 2;
            this.btnCreateNewSale.Text = "新增銷售";
            this.btnCreateNewSale.UseVisualStyleBackColor = false;
            this.btnCreateNewSale.Click += new System.EventHandler(this.btnCreateNewSale_Click);
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabPage1);
            this.tabController.Controls.Add(this.tabPage2);
            this.tabController.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabController.Location = new System.Drawing.Point(0, 0);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(1369, 766);
            this.tabController.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 778);
            this.Controls.Add(this.tabController);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabController.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExportStockExcel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCreateNewSale;
        private System.Windows.Forms.Button btnCreateShippmentTicket;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.TabControl tabController;
    }
}

