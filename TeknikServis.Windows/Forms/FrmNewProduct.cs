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

        }

        private async void SmpBtnSave_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ProductName = TxtProductName.Text;
            products.ProductBrand = TxtBrandName.Text;
            products.PurchasePrice = decimal.Parse(TxtPurchasePrice.Text);
            products.SalePrice = decimal.Parse(TxtSalePrice.Text);
            products.Stock = byte.Parse(TxtStock.Text);
            products.CategoryId = byte.Parse(TxtCategory.Text);

            db.Products.Add(products);
            await db.SaveChangesAsync();

            MessageBox.Show("Ürün Başarıyla Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void SmpBtnCancel_Click(object sender, EventArgs e)
        {
            FrmNewProduct fr = new FrmNewProduct();
            fr.Close();
        }
    }
}
