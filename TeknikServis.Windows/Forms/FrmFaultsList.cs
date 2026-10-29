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
        }
    }
}
