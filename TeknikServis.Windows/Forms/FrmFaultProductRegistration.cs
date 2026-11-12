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
    public partial class FrmFaultProductRegistration : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmFaultProductRegistration()
        {
            InitializeComponent();
        }

        private void SmpBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SmpBtnFindCurrentAndEmployee_Click(object sender, EventArgs e)
        {
            var values = db.ProductMovements.Where(x => x.ProductSerialNo == TxtSerialNumber.Text).FirstOrDefault();

            if (values != null)
            {

                TxtCurrentId.Text = values.Currents.CurrentName + " " + values.Currents.CurrentSurname;
                TxtEmployeeId.Text = values.Employees.EmployeeName + " " + values.Employees.EmployeeSurname;
            }
            else
            {
                MessageBox.Show("Cari Bulunamadı!", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void SmpSell_Click(object sender, EventArgs e)
        {
            ProductAcceptances productAcceptances = new ProductAcceptances();
            productAcceptances.Current = db.Currents.Where(x => x.CurrentName + " " + x.CurrentSurname == TxtCurrentId.Text).Select(y => y.CurrentId).FirstOrDefault();
            productAcceptances.Employee = db.Employees.Where(x => x.EmployeeName + " " + x.EmployeeSurname == TxtEmployeeId.Text).Select(y => y.EmployeeId).FirstOrDefault();
            productAcceptances.ProductSerialNo = TxtSerialNumber.Text;
            productAcceptances.ReceiveDate = DateTime.Parse(TxtDate.Text);
            productAcceptances.StatusDetail = "Ürün Kaydoldu";
            productAcceptances.ProductStatus = false;

            db.ProductAcceptances.Add(productAcceptances);
            db.SaveChanges();
            MessageBox.Show("Arızalı Ürün Kaydı Yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmFaultProductRegistration_Load(object sender, EventArgs e)
        {
            //LkUpCurrent.Properties.DataSource = (from x in db.Currents
            //                                     select new
            //                                     {
            //                                         x.CurrentId,
            //                                         AdSoyad = x.CurrentName + " " + x.CurrentSurname
            //                                     }).ToList();
        }

        private void TxtSerialNumber_Click(object sender, EventArgs e)
        {
            TxtSerialNumber.Text = "";
            TxtSerialNumber.Focus();

        }

        private void TxtCurrentId_Click(object sender, EventArgs e)
        {
            TxtSerialNumber.Text = "";
            TxtSerialNumber.Focus();
        }

        private void TxtEmployeeId_Click(object sender, EventArgs e)
        {
            TxtEmployeeId.Text = "";
            TxtEmployeeId.Focus();
        }

        private void TxtDate_Click(object sender, EventArgs e)
        {
            TxtDate.Text = "";
            TxtDate.Focus();
        }

        private void PcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
