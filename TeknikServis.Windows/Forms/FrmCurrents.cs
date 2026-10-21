using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Windows.Forms
{
    public partial class FrmCurrents : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PDF8JNK\SQLEXPRESS;Initial Catalog=DbTeknikServis;Integrated Security=True;TrustServerCertificate=True");

        public FrmCurrents()
        {
            InitializeComponent();
        }

        private void FrmCurrents_Load(object sender, EventArgs e)
        {
           GrdCurrents.DataSource = db.Currents.OrderBy(x => x.City).GroupBy(y => y.City).Select(g => new { City = g.Key, Count = g.Count() }).ToList();

            connection.Open();
            SqlCommand command = new SqlCommand("SELECT City, COUNT(*) AS Count FROM Currents GROUP BY City", connection);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                ChartCtrlCurrentStatistics.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            connection.Close();
        }
    }
}
