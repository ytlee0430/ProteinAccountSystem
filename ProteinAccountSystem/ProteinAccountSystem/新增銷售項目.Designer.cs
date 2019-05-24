namespace ProteinAccountSystem
{
    partial class FromCreateNewSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxBrands = new System.Windows.Forms.ComboBox();
            this.cbxFlavors = new System.Windows.Forms.ComboBox();
            this.cbxPackages = new System.Windows.Forms.ComboBox();
            this.tbxSalePrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCreateSale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCount = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbsSaleWays = new System.Windows.Forms.ComboBox();
            this.tbxReceipyNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxTransferMoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxBrands
            // 
            this.cbxBrands.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxBrands.FormattingEnabled = true;
            this.cbxBrands.Location = new System.Drawing.Point(30, 82);
            this.cbxBrands.Name = "cbxBrands";
            this.cbxBrands.Size = new System.Drawing.Size(302, 48);
            this.cbxBrands.TabIndex = 0;
            // 
            // cbxFlavors
            // 
            this.cbxFlavors.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxFlavors.FormattingEnabled = true;
            this.cbxFlavors.Location = new System.Drawing.Point(384, 82);
            this.cbxFlavors.Name = "cbxFlavors";
            this.cbxFlavors.Size = new System.Drawing.Size(302, 48);
            this.cbxFlavors.TabIndex = 1;
            // 
            // cbxPackages
            // 
            this.cbxPackages.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxPackages.FormattingEnabled = true;
            this.cbxPackages.Location = new System.Drawing.Point(738, 82);
            this.cbxPackages.Name = "cbxPackages";
            this.cbxPackages.Size = new System.Drawing.Size(302, 48);
            this.cbxPackages.TabIndex = 2;
            // 
            // tbxSalePrice
            // 
            this.tbxSalePrice.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxSalePrice.Location = new System.Drawing.Point(1446, 75);
            this.tbxSalePrice.Name = "tbxSalePrice";
            this.tbxSalePrice.Size = new System.Drawing.Size(302, 55);
            this.tbxSalePrice.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddItem.Location = new System.Drawing.Point(1092, 205);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(396, 60);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "新增項目";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnCreateSale
            // 
            this.btnCreateSale.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateSale.Location = new System.Drawing.Point(1399, 924);
            this.btnCreateSale.Name = "btnCreateSale";
            this.btnCreateSale.Size = new System.Drawing.Size(372, 71);
            this.btnCreateSale.TabIndex = 5;
            this.btnCreateSale.Text = "確認訂單";
            this.btnCreateSale.UseVisualStyleBackColor = true;
            this.btnCreateSale.Click += new System.EventHandler(this.btnCreateSale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "品牌 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(377, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "口味 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(731, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "包裝 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(1439, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "金額 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(1085, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = "數量 :";
            // 
            // cbxCount
            // 
            this.cbxCount.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxCount.FormattingEnabled = true;
            this.cbxCount.Location = new System.Drawing.Point(1092, 82);
            this.cbxCount.Name = "cbxCount";
            this.cbxCount.Size = new System.Drawing.Size(302, 48);
            this.cbxCount.TabIndex = 11;
            this.cbxCount.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 342);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(1759, 556);
            this.textBox2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 40);
            this.label6.TabIndex = 13;
            this.label6.Text = "銷售項目清單 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(23, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 40);
            this.label7.TabIndex = 14;
            this.label7.Text = "發票號碼 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(377, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 40);
            this.label8.TabIndex = 16;
            this.label8.Text = "銷售方式 :";
            // 
            // cbsSaleWays
            // 
            this.cbsSaleWays.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbsSaleWays.FormattingEnabled = true;
            this.cbsSaleWays.Location = new System.Drawing.Point(384, 217);
            this.cbsSaleWays.Name = "cbsSaleWays";
            this.cbsSaleWays.Size = new System.Drawing.Size(302, 48);
            this.cbsSaleWays.TabIndex = 17;
            // 
            // tbxReceipyMoney
            // 
            this.tbxReceipyNumber.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxReceipyNumber.Location = new System.Drawing.Point(19, 205);
            this.tbxReceipyNumber.Name = "tbxReceipyMoney";
            this.tbxReceipyNumber.Size = new System.Drawing.Size(313, 55);
            this.tbxReceipyNumber.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(731, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 40);
            this.label9.TabIndex = 19;
            this.label9.Text = "運費 :";
            // 
            // tbxTransferMoney
            // 
            this.tbxTransferMoney.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxTransferMoney.Location = new System.Drawing.Point(738, 212);
            this.tbxTransferMoney.Name = "tbxTransferMoney";
            this.tbxTransferMoney.Size = new System.Drawing.Size(313, 55);
            this.tbxTransferMoney.TabIndex = 20;
            this.tbxTransferMoney.Text = "0";
            // 
            // FromCreateNewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 1007);
            this.Controls.Add(this.tbxTransferMoney);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxReceipyNumber);
            this.Controls.Add(this.cbsSaleWays);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cbxCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateSale);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.tbxSalePrice);
            this.Controls.Add(this.cbxPackages);
            this.Controls.Add(this.cbxFlavors);
            this.Controls.Add(this.cbxBrands);
            this.Name = "FromCreateNewSale";
            this.Text = "新增銷售項目";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxBrands;
        private System.Windows.Forms.ComboBox cbxFlavors;
        private System.Windows.Forms.ComboBox cbxPackages;
        private System.Windows.Forms.TextBox tbxSalePrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCreateSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCount;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbsSaleWays;
        private System.Windows.Forms.TextBox tbxReceipyNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxTransferMoney;
    }
}