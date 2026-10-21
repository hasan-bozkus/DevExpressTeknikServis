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
    public partial class FrmNewCurrent : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmNewCurrent()
        {
            InitializeComponent();
        }

        private void SmpBtnSave_Click(object sender, EventArgs e)
        {
            Currents current = new Currents();
            current.CurrentName = TxtCurrentName.Text;
            current.CurrentSurname = TxtCurrentSurname.Text;
            current.Phone = TxtPhone.Text;
            current.Email = TxtEmail.Text;
            current.City = TxtCurrentCity.Text;
            current.District = TxtDistrict.Text;
            current.FullAddress = TxtAddress.Text;
            db.Currents.Add(current);
            db.SaveChanges();
            MessageBox.Show("Yeni Cari Sisteme Başarıyla Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PicEditCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SmpBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
