using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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
            productTracings.Description = TxtDescription.Text;
            productTracings.Date = DateTime.Parse(DateTime.Now.ToShortDateString());

            db.ProductTracings.Add(productTracings);

            ProductAcceptances productAcceptances = new ProductAcceptances();
            productAcceptances.ProcessId = int.Parse(processId);

            //var StatusDetailObject = db.ProductAcceptances.Where(p => p.ProductSerialNo == serialNumber).Select(p => p.ProcessId).FirstOrDefault();
            var idForUpdate = db.ProductAcceptances.Find(processId);
            idForUpdate.StatusDetail = ComboStatusDetail.Text;

            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Detayı Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void TxtSerialNo_Click(object sender, EventArgs e)
        {
            TxtSerialNo.Text = "";
            TxtSerialNo.Focus();
        }

        private void TxtDate_Click(object sender, EventArgs e)
        {
            TxtDate.Text = DateTime.Parse(DateTime.Now.ToShortDateString()).ToString();
            TxtDate.Focus();
        }

        private void PcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtDescription_Click(object sender, EventArgs e)
        {
            TxtDescription.Text = "";
            TxtDescription.Focus();
        }

        private void ComboStatusDetail_Click(object sender, EventArgs e)
        {
            ComboStatusDetail.Text = "";
            ComboStatusDetail.ShowPopup();
            ComboStatusDetail.Focus();
        }


        public string processId, serialNo;
        private void FrmFaultDetails_Load(object sender, EventArgs e)
        {
            TxtSerialNo.Text = serialNo;
        }
    }
}
