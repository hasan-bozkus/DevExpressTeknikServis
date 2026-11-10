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
    public partial class FrmNewCategory : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmNewCategory()
        {
            InitializeComponent();
        }

        private async void SmpBtnSave_Click(object sender, EventArgs e)
        {
            if (TxtCategoryName.Text != null && TxtCategoryName.Text.Length <= 30)
            {
                Categories category = new Categories();
                category.CategoryName = TxtCategoryName.Text;
                db.Categories.Add(category);
                await db.SaveChangesAsync();
                MessageBox.Show("Kategori başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kategori adı boş olamaz veya 30 karakterden uzun olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
