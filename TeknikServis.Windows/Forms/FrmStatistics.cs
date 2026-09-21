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
    public partial class FrmStatistics : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            LblTotalProductCount.Text = db.Products.Count().ToString();
            LblTotalCategoryCount.Text = db.Categories.Count().ToString();
            LblTotalStockCount.Text = db.Products.Sum(x => x.Stock).ToString();
            LblCriticalLevel.Text = db.Products.Count(x => x.Stock <= 10).ToString();
           // LblProductSoldTodayCount.Text = db.Sales.Count(x => x.SaleDate.Date == DateTime.Today).ToString();

            LblMaxStockProduct.Text = (from x in db.Products orderby x.Stock descending select x.ProductName).FirstOrDefault();
            LblMinStockProduct.Text = (from x in db.Products orderby x.Stock ascending select x.ProductName).FirstOrDefault();
            LblMaxCategoryProduct.Text = (from x in db.Products group x by x.Categories.CategoryName into g select new { CategoryName = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count).Select(x => x.CategoryName).FirstOrDefault();
            LblMaxPricedProduct.Text = (from x in db.Products orderby x.SalePrice descending select x.ProductName).FirstOrDefault();
            LblMinPricedProduct.Text = (from x in db.Products orderby x.SalePrice ascending select x.ProductName).FirstOrDefault();

            LblTotalBrandCount.Text = db.Products.Select(x => x.ProductBrand).Distinct().Count().ToString();
            LblMaxProductBrand.Text = (from x in db.Products group x by x.ProductBrand into g select new { BrandName = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count).Select(x => x.BrandName).FirstOrDefault();
            LblDefectiveProductCount.Text = db.Products.Count(x => x.Status == false).ToString();
            LblInRepairProductCount.Text = db.Products.Count(x => x.Status == true).ToString();

            LblWhiteGoodsStokQuantity.Text = db.Products.Where(x => x.Categories.CategoryName == "Beyaz Eşya").Sum(x => x.Stock).ToString();
            LbComputerStokQuantity.Text = db.Products.Where(x => x.Categories.CategoryName == "Bilgisayar").Sum(x => x.Stock).ToString();
            LblSmallHomeApplianceStokQuantity.Text = db.Products.Where(x => x.Categories.CategoryName == "Küçük Ev Aletleri").Sum(x => x.Stock).ToString();
        }
    }
}
