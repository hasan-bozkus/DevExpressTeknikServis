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
            productMovement.Product = int.Parse(TxtProductId.Text);
            productMovement.Current = int.Parse(TxtCurrent.Text);
            productMovement.Employee = short.Parse(TxtEmployee.Text);
            productMovement.Date = DateTime.Parse(TxtSalesDate.Text);
            productMovement.Quantity = short.Parse(TxtQuantity.Text);
            productMovement.Price = decimal.Parse(TxtSalePrice.Text);
            productMovement.ProductSerialNo = TxtSerialNumber.Text;
            db.ProductMovements.Add(productMovement);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
