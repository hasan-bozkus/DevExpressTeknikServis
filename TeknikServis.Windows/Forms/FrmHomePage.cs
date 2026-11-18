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
    public partial class FrmHomePage : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmHomePage()
        {
            InitializeComponent();
        }

        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            GrdCriticalLevel.DataSource = db.Products.Where(x => x.Stock <= 30).Select(y => new
            {
                y.ProductName,
                y.Stock
            }).ToList();

            GrdFhrist.DataSource = db.Currents.Select(y => new
            {
                FullName = y.CurrentName + " " + y.CurrentSurname,
                y.City
            }).ToList();

            GrdProductListWithCategory.DataSource = db.ProductWithCategory().Select(y => new
            {
                y.Adet,
                y.Kategori_Adı
            }).ToList();

            DateTime today = DateTime.Today;

            GrdNotes.DataSource = db.Notes.OrderBy(y => y.NoteId).Where(y => y.Date == today).Select(y => new
            {
                y.Title,
                y.Content
            }).ToList();

            labelControl1.Text = db.Messages?.First(z => z.MessageId == 1).NameSurname + " - " + db.Messages?.First(z => z.MessageId == 1).Subject;
            labelControl2.Text = db.Messages?.First(z => z.MessageId == 2).NameSurname + " - " + db.Messages?.First(z => z.MessageId == 2).Subject;
            labelControl3.Text = db.Messages?.First(z => z.MessageId == 3).NameSurname + " - " + db.Messages?.First(z => z.MessageId == 3).Subject;
            labelControl4.Text = db.Messages?.First(z => z.MessageId == 2).NameSurname + " - " + db.Messages?.First(z => z.MessageId == 2).Subject;
            labelControl5.Text = db.Messages?.First(z => z.MessageId == 2).NameSurname + " - " + db.Messages?.First(z => z.MessageId == 2).Subject;
            labelControl6.Text = db.Messages?.First(z => z.MessageId == 2).NameSurname + " - " + db.Messages?.First(z => z.MessageId == 2).Subject;
            labelControl7.Text = db.Messages?.First(z => z.MessageId == 2).NameSurname + " - " + db.Messages?.First(z => z.MessageId == 2).Subject;
            labelControl8.Text = db.Messages?.First(z => z.MessageId == 2).NameSurname + " - " + db.Messages?.First(z => z.MessageId == 2).Subject;
            labelControl9.Text = db.Messages?.First(z => z.MessageId == 2).NameSurname + " - " + db.Messages?.First(z => z.MessageId == 2).Subject;
            labelControl10.Text = db.Messages?.First(z => z.MessageId == 2).NameSurname + " - " + db.Messages?.First(z => z.MessageId == 2).Subject;
        }
    }
}
