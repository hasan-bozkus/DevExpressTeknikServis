using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServis.Windows.Forms;

namespace TeknikServis.Windows
{
    public partial class FrmLogin : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var query = from x in db.Admin where x.UserName == TxtUserName.Text && x.Password == TxtPassword.Text select x;

            if(query.Any())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
