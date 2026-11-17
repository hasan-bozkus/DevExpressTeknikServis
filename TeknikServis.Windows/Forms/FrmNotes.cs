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
    public partial class FrmNotes : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmNotes()
        {
            InitializeComponent();
        }

        void UnreadNotes()
        {
            var values = from x in db.Notes
                         where x.Status == false
                         select new
                         {
                             x.NoteId,
                             x.Title,
                             x.Content,
                             x.Status
                         };
            GrdUnreadNotes.DataSource = values.ToList();
        }

        void ReadNotes()
        {
            var values = from x in db.Notes
                         where x.Status == true
                         select new
                         {
                             x.NoteId,
                             x.Title,
                             x.Content,
                             x.Status
                         };
            GrdReadNotes.DataSource = values.ToList();
        }

        private void FrmNotes_Load(object sender, EventArgs e)
        {
            UnreadNotes();
            ReadNotes();
        }

        private void SmpBtnSave_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes();
            notes.Title = TxtNoteTitle.Text;
            notes.Content = TxtNoteContent.Text;
            notes.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            notes.Status = false;
            db.Notes.Add(notes);
            db.SaveChanges();

            MessageBox.Show("Not Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UnreadNotes();
            ReadNotes();
        }

        private void SmpBtnList_Click(object sender, EventArgs e)
        {
            UnreadNotes();
            ReadNotes();
        }

        private void SmpBtnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckMarkAsRead.Checked == true)
            {
                int id = Convert.ToInt32(TxtNoteId.Text);
                var value = db.Notes.Find(id);
                value.Status = true;
                db.SaveChanges();
                MessageBox.Show("Not Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UnreadNotes();
                ReadNotes();

            }
        }

        private void GrdViewItems_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtNoteId.Text = GrdViewItems.GetFocusedRowCellValue("NoteId").ToString();
            TxtNoteTitle.Text = GrdViewItems.GetFocusedRowCellValue("Title").ToString();
            TxtNoteContent.Text = GrdViewItems.GetFocusedRowCellValue("Content").ToString();
        }
    }
}
