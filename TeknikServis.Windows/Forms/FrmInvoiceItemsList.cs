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
    public partial class FrmInvoiceItemsList : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmInvoiceItemsList()
        {
            InitializeComponent();
        }

        private void SmpBtnSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtInvoiceId.Text);


            var values = db.InvoiceDetails.Where(x => x.InvoiceInformationId == id || x.InvoiceInformations.SerialNo == TxtSerialNo.Text || x.InvoiceInformations.Serial == TxtOrder.Text).Select(x => new
            {
                x.InvoiceDetailId,
                x.ProductName,
                x.Quantity,
                x.Price,
                x.Amount,
                x.InvoiceInformationId
            }).ToList();

            GrdInvoiceItems.DataSource = values;
        }
    }
}
