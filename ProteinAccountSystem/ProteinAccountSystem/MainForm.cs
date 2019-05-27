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

namespace ProteinAccountSystem
{
    public partial class Form1 : Form
    {
        ShopeeController _shopeeController = new ShopeeController();
        public Form1()
        {
            InitializeComponent();
           // dgvStorage.ColumnCount = 13;
            //dgvStorage.Columns[0].Name = "Key";
            //dgvStorage.Columns[1].Name = "Storage";
            //dgvStorage.Columns[2].Name = "ItemCode";
            //dgvStorage.Columns[3].Name = "Flavor";
            //dgvStorage.Columns[4].Name = "Brand";
            //dgvStorage.Columns[5].Name = "ProductionType";
            //dgvStorage.Columns[6].Name = "ProductionDetailType";
            //dgvStorage.Columns[7].Name = "Package";
            //dgvStorage.Columns[8].Name = "NetPrice";
            //dgvStorage.Columns[9].Name = "Discount";
            //dgvStorage.Columns[10].Name = "Cost";
            //dgvStorage.Columns[11].Name = "Tax";
            //dgvStorage.Columns[12].Name = "ExpiredDate";
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
            _shopeeController.importShipDataProcess(path);

        }

        private void btnCreateShippmentTicket_Click(object sender, EventArgs e)
        {
            var result = _shopeeController.CreateShippmentTickets();
        }

        private void btnCreateNewSale_Click(object sender, EventArgs e)
        {
            FromCreateNewSale a = new FromCreateNewSale(_shopeeController);
            a.ShowDialog();
        }

        private void btnShowStorage_Click(object sender, EventArgs e)
        {
            var storages = _shopeeController.GetStorage();
            dgvStorage.DataSource = storages;
            dgvStorage.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }
    }
}
