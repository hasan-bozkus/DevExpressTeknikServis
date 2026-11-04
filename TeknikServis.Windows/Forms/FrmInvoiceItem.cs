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
    public partial class FrmInvoiceItem : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmInvoiceItem()
        {
            InitializeComponent();
        }

        void InvoiceItemList()
        {
            var values = db.InvoiceDetails.Select(x => new
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

        private void FrmInvoiceItem_Load(object sender, EventArgs e)
        {
            InvoiceItemList();
        }

        private void SmpBtnSave_Click(object sender, EventArgs e)
        {
            InvoiceDetails invoiceDetail = new InvoiceDetails();
            invoiceDetail.ProductName = TxtProduct.Text;
            invoiceDetail.Quantity = short.Parse(TxtQuantity.Text);
            invoiceDetail.Price = decimal.Parse(TxtPrice.Text);
            invoiceDetail.Amount = decimal.Parse(TxtAmount.Text);
            invoiceDetail.InvoiceInformationId = int.Parse(TxtInvoice.Text);
            db.InvoiceDetails.Add(invoiceDetail);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalem Başarıyla Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InvoiceItemList();
        }

        private void SmpBtnList_Click(object sender, EventArgs e)
        {
            InvoiceItemList();
        }
    }
}
