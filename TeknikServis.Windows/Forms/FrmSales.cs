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
    public partial class FrmSales : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmSales()
        {
            InitializeComponent();
        }

        void SalesList()
        {
            var values = from x in db.ProductMovements
                         select new
                         {
                             x.MovementId,
                             x.Products.ProductName,
                             CurrentFullName = x.Currents.CurrentName + " " + x.Currents.CurrentSurname,
                             EmployeeFullName = x.Employees.EmployeeName + " " + x.Employees.EmployeeSurname,
                             x.Date,
                             x.Quantity,
                             x.Price,
                             x.ProductSerialNo
                         };
            GrdSalesList.DataSource = values.ToList();
        }


        private void FrmSales_Load(object sender, EventArgs e)
        {
            SalesList();
        }
    }
}
