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
    public partial class FrmDepartment : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmDepartment()
        {
            InitializeComponent();
        }

        void DepartmentList()
        {
            var values = from x in db.Departments
                         select new
                         {
                             x.DepartmentId,
                             x.DepartmentName,
                             x.Description
                         };
            GrdDepartments.DataSource = values.ToList();
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {

            DepartmentList();

            LblTotalDepartmentCount.Text = db.Departments.Count().ToString();
            LblTotalEmployeeCount.Text = db.Employees.Count().ToString();
        }

        private void SmpBtnSave_Click(object sender, EventArgs e)
        {
            Departments department = new Departments();

            if (TxtDepartmentName.Text.Length <= 50 && TxtDepartmentName.Text != "" && RchTxtDepartmentDescription.Text != "")
            {

                department.DepartmentName = TxtDepartmentName.Text;
                department.Description = RchTxtDepartmentDescription.Text;

                db.Departments.Add(department);
                db.SaveChanges();
                DepartmentList();

                MessageBox.Show("Departman başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen departman adını ve açıklamasını eksiksiz ve doğru bir şekilde giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SmpBtnList_Click(object sender, EventArgs e)
        {
            DepartmentList();
        }

        private void SmpBtnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtDepartmentId.Text);
            var value = db.Departments.Find(id);
            db.Departments.Remove(value);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DepartmentList();
        }

        private void GrdViewItems_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtDepartmentId.Text = GrdViewItems.GetFocusedRowCellValue("DepartmentId").ToString();
            TxtDepartmentName.Text = GrdViewItems.GetFocusedRowCellValue("DepartmentName").ToString();
            RchTxtDepartmentDescription.Text = GrdViewItems.GetFocusedRowCellValue("Description")?.ToString();
        }

        private void SmpBtnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtDepartmentId.Text);
            var value = db.Departments.Find(id);

            value.DepartmentName = TxtDepartmentName.Text;
            value.Description = RchTxtDepartmentDescription.Text;

            db.SaveChanges();

            DepartmentList();

            MessageBox.Show("Departman Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
