using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BarBtnProductList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmProductList fr = new Forms.FrmProductList();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BarBtnNewProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewProduct fr = new Forms.FrmNewProduct();
            fr.Show();
        }

        private void BarBtnCategoryList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCategory fr = new Forms.FrmCategory();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BarBtnNewCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewCategory fr = new Forms.FrmNewCategory();
            fr.Show();
        }

        private void BarBtnProductStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmStatistics fr = new Forms.FrmStatistics();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BarBtnBrandStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmBrand fr = new Forms.FrmBrand();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BarBtnCurrentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCurrentList fr = new Forms.FrmCurrentList();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BarBtnCityStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCurrents fr = new Forms.FrmCurrents();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BarBtnNewCurrent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewCurrent fr = new Forms.FrmNewCurrent();
            fr.Show();
        }

        private void BarBtnDepartmentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmDepartment fr = new Forms.FrmDepartment();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BarBtnNewDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewDepartment fr = new Forms.FrmNewDepartment();
            fr.Show();
        }

        private void BarBtnEmployeeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmEmployee fr = new Forms.FrmEmployee();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BarBtnCalculator_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void BarBtnExchangeRates_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmExchangeRates fr = new Forms.FrmExchangeRates();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BarBtnOfficeWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BarBtnOfficeExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void BarBtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmYoutube fr = new Forms.FrmYoutube();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BarBtnNoteList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNotes fr = new Forms.FrmNotes();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BarBtnFaultProductList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmFaultsList fr = new Forms.FrmFaultsList();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BarBtnNewProductSales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewProductSales fr = new Forms.FrmNewProductSales();
            fr.Show();
        }

        private void BarBtnSalesList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmSales fr = new Forms.FrmSales();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BarBtnNewFaultProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmFaultProductRegistration fr = new Forms.FrmFaultProductRegistration();
            fr.Show();
        }

        private void BarBtnFaultProductDescription_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmFaultDetails fr = new Forms.FrmFaultDetails();
            fr.Show();
        }

        private void BarBtnFaultProductDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmFaultProductDetails fr = new Forms.FrmFaultProductDetails();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
