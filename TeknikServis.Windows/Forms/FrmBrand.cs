using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PDF8JNK\SQLEXPRESS;Initial Catalog=DbTeknikServis;integrated Security=True;TrustServerCertificate=True;");
            connection.Open();
            SqlCommand command = new SqlCommand("Select ProductBrand, Count(*) From Products Group By ProductBrand ", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                ChartBrandAndValue.Series["Series 1"].Points.AddPoint(dr[0].ToString(), (int)dr[1]);
            }
            connection.Close();

            connection.Open();
            SqlCommand command2 = new SqlCommand("Select Categories.CategoryName, Count(*) From Products Inner Join Categories On Products.CategoryId = Categories.CategoryId Group By Categories.CategoryName ", connection);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                ChartProductAndValue.Series["Kategoriler"].Points.AddPoint(Convert.ToString(dr2[0]), (int)dr2[1]);
            }
            connection.Close();
        }
    }
}
