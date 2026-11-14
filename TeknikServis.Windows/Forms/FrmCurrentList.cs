using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Windows.Forms
{
    public partial class FrmCurrentList : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int selected;

        public FrmCurrentList()
        {
            InitializeComponent();
        }

        void CurrentsList()
        {
            GrdCurrents.DataSource = db.Currents.Select(x => new
            {
                x.CurrentId,
                FullName = x.CurrentName + " " + x.CurrentSurname,
                x.Email,
                x.City,
                x.District
            }).ToList();
        }

        private void FrmCurrentList_Load(object sender, EventArgs e)
        {
            CurrentsList();

            LblTotalCurrentCount.Text = db.Currents.Count().ToString();
            LblTotalCityCount.Text = db.Currents.Select(x => x.City).Distinct().Count().ToString();
            LblTotalDistrictCount.Text = db.Currents.Select(x => x.District).Distinct().Count().ToString();
            LblCentralBranch.Text = db.Currents.Where(x => x.Status == "1").GroupBy(y => y.City).Select(z => new
            {
                Key = z.Key.ToString(),
                Count = z.Count()
            }).OrderByDescending(x => x.Count).FirstOrDefault().Key.ToString();

            LkUpCity.Properties.DataSource = db.iller.Select(x => new
            {
                x.id,
                x.sehir
            }).ToList();

            LkUpDistrict.Properties.DataSource = db.ilceler.Select(x => new
            {
                x.id,
                x.ilce
            }).ToList();
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

        private void SmpBtnSave_Click(object sender, EventArgs e)
        {
            if (TxtCurrentName.Text != "" & TxtCurrentSurname.Text != "" & TxtCurrentName.Text.Length <= 20)
            {
                Currents currents = new Currents();
                currents.CurrentName = TxtCurrentName.Text;
                currents.CurrentSurname = TxtCurrentSurname.Text;
                currents.Phone = TxtPhoneNumber.Text;
                currents.Bank = TxtBankName.Text;
                currents.TaxOffice = TxtTaxOffice.Text;
                currents.TaxNo = TxtTaxNumber.Text;
                currents.FullAddress = TxtAddress.Text;
                currents.City = LkUpCity.Text;
                currents.District = LkUpDistrict.Text;
                db.Currents.Add(currents);
                db.SaveChanges();
                MessageBox.Show("Cari sisteme eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CurrentsList();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yendine Deneyin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SmpBtnList_Click(object sender, EventArgs e)
        {
            CurrentsList();
        }
    }
}
