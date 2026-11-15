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
    public partial class FrmNewProductSales : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmNewProductSales()
        {
            InitializeComponent();
        }

        private void SmpBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SmpSell_Click(object sender, EventArgs e)
        {
            ProductMovements productMovement = new ProductMovements();
            productMovement.Product = int.Parse(LkUpProduct.EditValue.ToString());
            productMovement.Current = int.Parse(LkUpCustomer.EditValue.ToString());
            productMovement.Employee = short.Parse(LkUpEmployee.EditValue.ToString());
            productMovement.Date = DateTime.Parse(TxtSalesDate.Text);
            productMovement.Quantity = short.Parse(TxtQuantity.Text);
            productMovement.Price = decimal.Parse(TxtSalePrice.Text);
            productMovement.ProductSerialNo = TxtSerialNumber.Text;
            db.ProductMovements.Add(productMovement);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmNewProductSales_Load(object sender, EventArgs e)
        {
            LkUpProduct.Properties.DataSource = db.Products.Select(x => new
            {
                x.ProductId,
                x.ProductName
            }).ToList();

            LkUpCustomer.Properties.DataSource = db.Currents.Select(x => new
            {
                x.CurrentId,
                FullName = x.CurrentName + " " + x.CurrentSurname
            }).ToList();

            LkUpEmployee.Properties.DataSource = db.Employees.Select(x => new
            {
                x.EmployeeId,
                FullName = x.EmployeeName + " " + x.EmployeeSurname
            }).ToList();
        }
    }
}
