using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Windows.Iletişim
{
    public partial class FrmGuide : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmGuide()
        {
            InitializeComponent();
        }

        private void FrmGuide_Load(object sender, EventArgs e)
        {
            GrdGuide.DataSource = db.Currents.Select(x => new
            {
                AdSoyad = x.CurrentName + " " + x.CurrentSurname,
                Posta = x.Email,
                Telefon = x.Phone
            }).ToList();
        }
    }
}
