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
    public partial class FrmBrand : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        public FrmBrand()
        {
            InitializeComponent();
        }

        private void FrmBrand_Load(object sender, EventArgs e)
        {
            var values = db.Products.OrderBy(x => x.ProductBrand).GroupBy(y => y.ProductBrand).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            }).ToList();
            GrdBrands.DataSource = values;

            LblTotalProductCount.Text = db.Products.Count().ToString();
            LblTotalBrandCount.Text = db.Products.Select(x => x.ProductBrand).Distinct().Count().ToString();
            LblMaxProductCountByBrand.Text = db.Products.OrderByDescending(x => x.SalePrice).Select(y => y.ProductName).FirstOrDefault();
            LblMaxPricedBrand.Text = (from x in db.Products group x by x.ProductBrand into g select new { BrandName = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count).Select(x => x.BrandName).FirstOrDefault();

            ChartBrandAndValue.Series["Series 1"].Points.AddPoint("Siemens", 4);
            ChartBrandAndValue.Series["Series 1"].Points.AddPoint("Arçelik", 6);
            ChartBrandAndValue.Series["Series 1"].Points.AddPoint("Beko", 2);
            ChartBrandAndValue.Series["Series 1"].Points.AddPoint("Toshiba", 1);
            ChartBrandAndValue.Series["Series 1"].Points.AddPoint("Asus", 10);

            ChartProductAndValue.Series["Kategoriler"].Points.AddPoint("Beyaz Eşya", 4);
            ChartProductAndValue.Series["Kategoriler"].Points.AddPoint("Bilgisayar", 3);
            ChartProductAndValue.Series["Kategoriler"].Points.AddPoint("Küçük Ev aletleri", 6);
            ChartProductAndValue.Series["Kategoriler"].Points.AddPoint("Televizyon", 2);
            ChartProductAndValue.Series["Kategoriler"].Points.AddPoint("Telefon", 1);
            ChartProductAndValue.Series["Kategoriler"].Points.AddPoint("Diğer", 2);
        }
    }
}
