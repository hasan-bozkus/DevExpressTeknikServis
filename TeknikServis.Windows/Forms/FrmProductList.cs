using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Windows.Forms
{
    public partial class FrmProductList : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmProductList()
        {
            InitializeComponent();
        }

        private async Task ProductList()
        {
            var values = await db.Products.Include(c => c.Categories).Select(x => new
            {
                x.ProductId,
                x.ProductName,
                x.ProductBrand,
                x.Stock,
                x.PurchasePrice,
                x.SalePrice,
                x.Categories.CategoryName
            }).ToListAsync();
            GrdProducts.DataSource = values.ToList();

        }


        private async void FrmProductList_Load(object sender, EventArgs e)
        {
            await ProductList();
            LkUpCategory.Properties.DataSource = await db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName
            }).ToListAsync();
        }

        private async void SmpBtnSave_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ProductName = TxtProductName.Text;
            products.ProductBrand = TxtBrand.Text;
            products.PurchasePrice = decimal.Parse(TxtPurchasePrice.Text);
            products.SalePrice = decimal.Parse(TxtSalePrice.Text);
            products.Stock = short.Parse(TxtStock.Text);
            products.Status = false;
            products.CategoryId = byte.Parse(LkUpCategory.EditValue.ToString());
            db.Products.Add(products);

            await db.SaveChangesAsync();

            MessageBox.Show("Ürün Başarıyla Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void SmpBtnList_Click(object sender, EventArgs e)
        {
            await ProductList();
        }

        private void GrdViewItems_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtProductId.Text = GrdViewItems.GetFocusedRowCellValue("ProductId").ToString();
                TxtProductName.Text = GrdViewItems.GetFocusedRowCellValue("ProductName").ToString();
                TxtBrand.Text = GrdViewItems.GetFocusedRowCellValue("ProductBrand").ToString();
                TxtPurchasePrice.Text = GrdViewItems.GetFocusedRowCellValue("PurchasePrice").ToString();
                TxtSalePrice.Text = GrdViewItems.GetFocusedRowCellValue("SalePrice").ToString();
                TxtStock.Text = GrdViewItems.GetFocusedRowCellValue("Stock").ToString();
                LkUpCategory.EditValue = GrdViewItems.GetFocusedRowCellValue("CategoryId").ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Bir Satır Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private async void SmpBtnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtProductId.Text);

            var value = await db.Products.FindAsync(id);
            db.Products.Remove(value);
            await db.SaveChangesAsync();

            MessageBox.Show("Ürün Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private async void SmpBtnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtProductId.Text);
            var value = await db.Products.FindAsync(id);

            value.ProductName = TxtProductName.Text;
            value.Stock = short.Parse(TxtStock.Text);
            value.ProductBrand = TxtBrand.Text;
            value.PurchasePrice = decimal.Parse(TxtPurchasePrice.Text);
            value.SalePrice = decimal.Parse(TxtSalePrice.Text);
            value.CategoryId = byte.Parse(LkUpCategory.EditValue.ToString());

            await db.SaveChangesAsync();

            MessageBox.Show("Ürün Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SmpBtnClear_Click(object sender, EventArgs e)
        {
            TxtProductId.Text = "";
            TxtProductName.Text = "";
            TxtBrand.Text = "";
            TxtPurchasePrice.Text = "";
            TxtSalePrice.Text = "";
            TxtStock.Text = "";
        }
    }
}
