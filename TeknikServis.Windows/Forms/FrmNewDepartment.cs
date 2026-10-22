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
    public partial class FrmNewDepartment : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmNewDepartment()
        {
            InitializeComponent();
        }

        private void SmpBtnSave_Click(object sender, EventArgs e)
        {
            Departments department = new Departments();
            department.DepartmentName = TxtDepartmentName.Text;
            db.Departments.Add(department);
            db.SaveChanges();
            MessageBox.Show("Yeni Departman Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
