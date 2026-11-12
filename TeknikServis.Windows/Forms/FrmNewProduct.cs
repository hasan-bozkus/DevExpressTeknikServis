using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Windows.Forms
{
    public partial class FrmNewProduct : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmNewProduct()
        {
            InitializeComponent();
        }

        private void FrmNewProduct_Load(object sender, EventArgs e)
        {
            LkUpCategory.Properties.DataSource = (from x in db.Categories
                                                  select new
                                                  {
                                                      x.CategoryId,
                                                      x.CategoryName
                                                  }).ToList();
        }

        private async void SmpBtnSave_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ProductName = TxtProductName.Text;
            products.ProductBrand = TxtBrandName.Text;
            products.PurchasePrice = decimal.Parse(TxtPurchasePrice.Text);
            products.SalePrice = decimal.Parse(TxtSalePrice.Text);
            products.Stock = byte.Parse(TxtStock.Text);
            products.CategoryId = byte.Parse(LkUpCategory.EditValue.ToString());

            db.Products.Add(products);
            await db.SaveChangesAsync();

            MessageBox.Show("Ürün Başarıyla Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void SmpBtnCancel_Click(object sender, EventArgs e)
        {
            FrmNewProduct fr = new FrmNewProduct();
            fr.Close();
        }

        private void TxtProductName_Click(object sender, EventArgs e)
        {
            TxtProductName.Text = "";
            TxtProductName.Focus();
        }

        private void TxtBrandName_Click(object sender, EventArgs e)
        {
            TxtBrandName.Text = "";
            TxtBrandName.Focus();
        }

        private void TxtPurchasePrice_Click(object sender, EventArgs e)
        {
            TxtPurchasePrice.Text = "";
            TxtPurchasePrice.Focus();
        }

        private void TxtSalePrice_Click(object sender, EventArgs e)
        {
            TxtSalePrice.Text = "";
            TxtSalePrice.Focus();
        }

        private void TxtStock_Click(object sender, EventArgs e)
        {
            TxtStock.Text = "";
            TxtStock.Focus();
        }

        private void PcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
