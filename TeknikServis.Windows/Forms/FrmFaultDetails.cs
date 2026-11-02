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
    public partial class FrmFaultDetails : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmFaultDetails()
        {
            InitializeComponent();
        }

        private void SmpBtnUpdate_Click(object sender, EventArgs e)
        {
            ProductTracings productTracings = new ProductTracings();
            var serialNumber = TxtSerialNo.Text;
            productTracings.ProductSerialNo = serialNumber;
            productTracings.Description = RichTxtDescription.Text;
            productTracings.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.ProductTracings.Add(productTracings);
            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Detayı Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmFaultDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
