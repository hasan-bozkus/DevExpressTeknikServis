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
    }
}
