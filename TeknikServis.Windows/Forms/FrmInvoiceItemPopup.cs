using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Windows.Forms
{
    public partial class FrmInvoiceItemPopup : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmInvoiceItemPopup()
        {
            InitializeComponent();
        }

        public string id;
        private void FrmInvoiceItemPopup_Load(object sender, EventArgs e)
        {
            GrdInvoice.DataSource = db.InvoiceInformations.Where(x => x.InvoiceInformationId == int.Parse(id)).ToList();
            GrdInvoiceDetail.DataSource = db.InvoiceDetails.Where(x => x.InvoiceInformationId == int.Parse(id)).ToList();
        }

        private void PictureBtnPdf_Click(object sender, EventArgs e)
        {
            string path = "\\Raporlar\\Invoice.pdf";
            GrdInvoiceDetail.ExportToPdf(path);
            //Process.Start(path);
        }

        private void PictureBtnXlsx_Click(object sender, EventArgs e)
        {
            string path = "\\Raporlar\\Invoice.xlsx";
            GrdInvoiceDetail.ExportToXlsx(path);
            //Process.Start(path);
        }

        private void PictureBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
