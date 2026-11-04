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
    public partial class FrmInvoiceList : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmInvoiceList()
        {
            InitializeComponent();
        }

        void InvoiceList()
        {
            GrdInvoices.DataSource = db.InvoiceInformations.Select(x => new
            {
                x.InvoiceInformationId,
                x.Serial,
                x.SerialNo,
                x.Date,
                x.Hour,
                x.TaxOffice,
                CurrentFullName = x.Currents.CurrentName + " " + x.Currents.CurrentSurname,
                EmployeeFullName = x.Employees.EmployeeName + " " + x.Employees.EmployeeSurname,
            }).ToList();

            LkUpCurrent.Properties.DataSource = db.Currents.Select(x => new
            {
                x.CurrentId,
                CurrentFullName = x.CurrentName + " " + x.CurrentSurname
            }).ToList();

            LkUpEmployee.Properties.DataSource = db.Employees.Select(x => new
            {
                x.EmployeeId,
                EmployeeFullName = x.EmployeeName + " " + x.EmployeeSurname
            }).ToList();
        }

        private void FrmInvoiceList_Load(object sender, EventArgs e)
        {
            InvoiceList();
        }

        private void SmpBtnSave_Click(object sender, EventArgs e)
        {
            InvoiceInformations invoice = new InvoiceInformations();
            invoice.SerialNo = TxtSeriesNumber.Text;
            invoice.Serial = TxtOrderNumber.Text;
            invoice.Date = DateTime.Parse(TxtInvoiceDate.Text);
            invoice.Hour = TxtInvoiceTime.Text;
            invoice.TaxOffice = TxtTaxOffice.Text;
            invoice.Current = int.Parse(LkUpCurrent.EditValue.ToString());
            invoice.Employee = short.Parse(LkUpEmployee.EditValue.ToString());

            db.InvoiceInformations.Add(invoice);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InvoiceList();
        }
    }
}
