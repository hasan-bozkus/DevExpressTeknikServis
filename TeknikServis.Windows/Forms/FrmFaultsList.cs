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
    public partial class FrmFaultsList : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmFaultsList()
        {
            InitializeComponent();
        }

        void ProductAcceptanceList()
        {
            var values = from x in db.ProductAcceptances
                         select new
                         {
                             x.ProcessId,
                             x.ProductSerialNo,
                             CurrentFullName = x.Currents.CurrentName + " " + x.Currents.CurrentSurname,
                             EmployeeFullName = x.Employees.EmployeeName + " " + x.Employees.EmployeeSurname,
                             x.ReceiveDate,
                             x.ReleaseDate                             
                         };
            GrdFaultsList.DataSource = values.ToList();
        }

        private void FrmFaultsList_Load(object sender, EventArgs e)
        {
            ProductAcceptanceList();

            LblNumberOfCurrentlyFaultyProducts.Text = db.ProductAcceptances.Where(x => x.ProductStatus == false).Count().ToString();
            LblNumberOfItemsWithCompletedRenovations.Text = db.ProductAcceptances.Where(x => x.ProductStatus == true).Count().ToString();
            LblNumberOfProductsAwaitingParts.Text = db.ProductAcceptances.Where(x => x.StatusDetail == "Parça Bekliyor").Count().ToString();
            LblTotalProductCount.Text = db.Products.Count().ToString();
            LblCustomersAwaitingMessage.Text = db.ProductAcceptances.Where(x => x.StatusDetail == "Mesaj Bekliyor").Count().ToString();
            LblCancelledTransactions.Text = db.ProductAcceptances.Where(x => x.StatusDetail == "İptal Bekliyor").Count().ToString();

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PDF8JNK\SQLEXPRESS;Initial Catalog=DbTeknikServis;integrated Security=True;TrustServerCertificate=True;");


            connection.Open();
            //boyut nedeni ile ilgili grafikte tasarımsal değişiklik yapıldı
            SqlCommand command = new SqlCommand("Select StatusDetail, Count(*) From ProductAcceptances Group By StatusDetail ", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                ChartProductFaultStatus.Series["Series 1"].Points.AddPoint(dr[0].ToString(), (int)dr[1]);
            }
            connection.Close();

        }
    }
}
