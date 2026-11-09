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
    public partial class FrmHomePage : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmHomePage()
        {
            InitializeComponent();
        }

        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            GrdCriticalLevel.DataSource = db.Products.Where(x => x.Stock <= 30).Select(y => new
            {
                y.ProductName,
                y.Stock
            }).ToList();

            GrdFhrist.DataSource = db.Currents.Select(y => new
            {
                FullName = y.CurrentName + " " + y.CurrentSurname,
                y.City
            }).ToList();
        }
    }
}
