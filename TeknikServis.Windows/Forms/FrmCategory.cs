using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
            if (TxtCategoryName.Text != "" && TxtCategoryName.Text.Length <= 30)
            {
                Categories category = new Categories();
                category.CategoryName = TxtCategoryName.Text;
                db.Categories.Add(category);
                await db.SaveChangesAsync();

                MessageBox.Show("Kategori başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori adı boş geçilemez ve 30 karakterden uzun olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

            // ID kontrolü
            if (!int.TryParse(TxtCategoryId.Text, out int id))
            {
                MessageBox.Show(
                    "Geçersiz kategori ID.",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Silme onayı
            DialogResult result = MessageBox.Show(
                "Bu kategoriyi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            // Silme denemesi (SQL karar versin)
            try
            {
                var category = db.Categories.Find(id);

                if (category == null)
                {
                    MessageBox.Show(
                        "Silinecek kategori bulunamadı.",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }

                db.Categories.Remove(category);
                db.SaveChanges();

                MessageBox.Show(
                    "Kategori başarıyla silindi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CategoryList();
            }
            catch (DbUpdateException)
            {
                // FK'ya takıldıysa buraya düşer
                MessageBox.Show(
                    "Bu kategori sistemde kullanıldığı için silinemez.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                // Beklenmeyen bir hata
                MessageBox.Show(
                    "Beklenmeyen bir hata oluştu.\n\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private async void SmpBtnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtCategoryId.Text);
            var value = await db.Categories.FindAsync(id);
            value.CategoryName = TxtCategoryName.Text;
            await db.SaveChangesAsync();
            MessageBox.Show("Kategori Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SmpBtnClear_Click(object sender, EventArgs e)
        {
            TxtCategoryId.Text = "";
            TxtCategoryName.Text = "";
        }
    }
}
