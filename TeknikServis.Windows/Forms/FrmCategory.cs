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
    public partial class FrmCategory : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmCategory()
        {
            InitializeComponent();
        }

        private async Task CategoryList()
        {
            var values = await db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName
            }).ToListAsync();
            GrdCategories.DataSource = values;
        }

        private async void FrmCategory_Load(object sender, EventArgs e)
        {
            await CategoryList();
        }

        private async void SmpBtnSave_Click(object sender, EventArgs e)
        {
            Categories category = new Categories();
            category.CategoryName = TxtCategoryName.Text;
            db.Categories.Add(category);
            await db.SaveChangesAsync();

            MessageBox.Show("Kategori başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void SmpBtnList_Click(object sender, EventArgs e)
        {
            await CategoryList();
        }

        private void GrdViewItems_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtCategoryId.Text = GrdViewItems.GetFocusedRowCellValue("CategoryId").ToString();
            TxtCategoryName.Text = GrdViewItems.GetFocusedRowCellValue("CategoryName").ToString();
        }

        private async void SmpBtnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtCategoryId.Text);
            var value = await db.Categories.FindAsync(id);
            db.Categories.Remove(value);
            MessageBox.Show("Kategori Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private async void SmpBtnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtCategoryId.Text);
            var value = await db.Categories.FindAsync(id);
            value.CategoryName = TxtCategoryName.Text;
            await db.SaveChangesAsync();
            MessageBox.Show("Kategori Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
