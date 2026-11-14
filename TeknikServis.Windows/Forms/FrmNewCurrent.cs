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
        int selected;

        public FrmNewCurrent()
        {
            InitializeComponent();
        }

        private void SmpBtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Currents current = new Currents();
                current.CurrentName = TxtCurrentName.Text;
                current.CurrentSurname = TxtCurrentSurname.Text;
                current.Phone = TxtPhone.Text;
                current.Email = TxtEmail.Text;
                current.City = LkUpCity.Text;
                current.District = LkUpCity.Text;
                current.FullAddress = TxtAddress.Text;
                db.Currents.Add(current);
                db.SaveChanges();
                MessageBox.Show("Yeni Cari Sisteme Başarıyla Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cari Sisteme Eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void PicEditCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SmpBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LkUpCity_EditValueChanged(object sender, EventArgs e)
        {
            selected = int.Parse(LkUpCity.EditValue.ToString());
            LkUpDistrict.Properties.DataSource = db.ilceler.Where(s => s.sehir == selected).Select(x => new
            {
                x.id,
                x.ilce,
                x.sehir
            }).ToList();
        }

        private void FrmNewCurrent_Load(object sender, EventArgs e)
        {
            LkUpCity.Properties.DataSource = db.iller.Select(x => new
            {
                x.id,
                x.sehir
            }).ToList();

            LkUpDistrict.Properties.DataSource = db.ilceler.Select(x => new
            {
                x.id,
                x.ilce,
                x.sehir
            }).ToList();
        }
    }
}
