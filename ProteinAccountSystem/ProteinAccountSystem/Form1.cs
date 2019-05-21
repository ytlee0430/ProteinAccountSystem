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
        ShopeeController shopeeController = new ShopeeController();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 匯入蝦皮excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            var path = openFileDialog1.FileName;
            shopeeController.importShipDataProcess(path);

        }

        private void btnCreateShippmentTicket_Click(object sender, EventArgs e)
        {
            var result = shopeeController.CreateShippmentTickets();
        }
    }
}
