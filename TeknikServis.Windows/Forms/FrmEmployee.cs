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
    public partial class FrmEmployee : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmEmployee()
        {
            InitializeComponent();
        }

        void EmployeeList()
        {
            var values = from i in db.Employees
                         select new
                         {
                             i.EmployeeId,
                             i.EmployeeName,
                             i.EmployeeSurname,
                             i.Email,
                             i.Phone,
                             Department = db.Departments.Where(x => x.DepartmentId == i.Department).Select(y => y.DepartmentName).FirstOrDefault()
                         };

            GrdDepartments.DataSource = values.ToList();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            //personel 1
            LblNameSurname1.Text = db.Employees.First(x => x.EmployeeId == 1).EmployeeName + " " + db.Employees.First(x => x.EmployeeId == 1).EmployeeSurname;
            LblDepartment1.Text = db.Employees.First(x => x.EmployeeId == 1).Departments.DepartmentName;
            LblEmail1.Text = db.Employees.First(x => x.EmployeeId == 1).Email;

            //personel 2
            LblNameSurname2.Text = db.Employees.First(x => x.EmployeeId == 2).EmployeeName + " " + db.Employees.First(x => x.EmployeeId == 2).EmployeeSurname;
            LblDepartment2.Text = db.Employees.First(x => x.EmployeeId == 2).Departments.DepartmentName;
            LblEmail2.Text = db.Employees.First(x => x.EmployeeId == 2).Email;

            //personel 3
            LblNameSurname3.Text = db.Employees.First(x => x.EmployeeId == 3).EmployeeName + " " + db.Employees.First(x => x.EmployeeId == 3).EmployeeSurname;
            LblDepartment3.Text = db.Employees.First(x => x.EmployeeId == 3).Departments.DepartmentName;
            LblEmail3.Text = db.Employees.First(x => x.EmployeeId == 3).Email;

            //personel 4
            LblNameSurname4.Text = db.Employees.First(x => x.EmployeeId == 4).EmployeeName + " " + db.Employees.First(x => x.EmployeeId == 4).EmployeeSurname;
            LblDepartment4.Text = db.Employees.First(x => x.EmployeeId == 4).Departments.DepartmentName;
            LblEmail4.Text = db.Employees.First(x => x.EmployeeId == 4).Email;

            LookUpDepartment.Properties.DataSource = (from x in db.Departments
                                                     select new
                                                     {
                                                         x.DepartmentId,
                                                         x.DepartmentName
                                                     }).ToList();

            EmployeeList();
        }
    }
}
