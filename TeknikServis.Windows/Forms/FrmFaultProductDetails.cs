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
    public partial class FrmFaultProductDetails : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmFaultProductDetails()
        {
            InitializeComponent();
        }

        private void FrmFaultProductDetails_Load(object sender, EventArgs e)
        {
            GrdFaultProductList.DataSource = (from x in db.ProductTracings
                                              select new
                                              {
                                                  x.TracingId,
                                                  x.ProductSerialNo,
                                                  x.Description,
                                                  x.Date
                                              }).ToList();
        }
    }
}
