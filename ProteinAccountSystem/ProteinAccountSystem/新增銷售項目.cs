using CommonUtility.Entity;
using CommonUtility.Enum;
using CommonUtility.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProteinAccountSystem
{
    public partial class FromCreateNewSale : Form
    {
        PhuraseDetailModel model;
        List<PhuraseProductModel> phurases = new List<PhuraseProductModel>();
        List<Item> items = new List<Item>();

        public FromCreateNewSale()
        {
            InitializeComponent();
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var item = new Item();
            Enum.TryParse(cbxBrands.SelectedItem.ToString(), out BrandEnum brand);
            item.Brand = brand;
            Enum.TryParse(cbxFlavors.SelectedItem.ToString(), out FlavorEnum flavor);
            item.Flavor = flavor;
            Enum.TryParse(cbxPackages.SelectedItem.ToString(), out PackageEnum package);
            item.Package = package;
            items.Add(item);
        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            foreach (var item in items)
            {
                phurases.Add(new PhuraseProductModel()
                {
                    ItemCode = ProductUtilities.GetItemCodes(item),
                    Count = Convert.ToInt32(cbxCount.SelectedItem),
                    ProductMoney = Convert.ToInt32(tbxSalePrice),
                    ProductMoneyWithoutTax = Convert.ToInt32(Convert.ToInt32(tbxSalePrice) / 1.05),
                });
            }

            model.Products = phurases;
            model.TotalMoney = phurases.Sum(x => x.ProductMoney) + Convert.ToInt32(tbxTransferMoney);
            model.TransferMoney= Convert.ToInt32(tbxTransferMoney);
            model.TotalTax = Convert.ToInt32((phurases.Sum(x => x.ProductMoney) + Convert.ToInt32(tbxTransferMoney)) * 0.05);
            model.ReceiptNumber = tbxReceipyNumber.Text;

            
        }
    }
}
