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
    public partial class FrmReceivedMail : Form
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public FrmReceivedMail()
        {
            InitializeComponent();
        }

        private void FrmReceivedMail_Load(object sender, EventArgs e)
        {
            LblTotalMessageCount.Text = db.Messages.Count().ToString();
            LblTotalThanksOfMessageCount.Text = db.Messages.Where(x => x.Subject == "Teşekkür").Count().ToString();
            LblTotalRequsetOfMessageCount.Text = db.Messages.Where(x => x.Subject == "Rica").Count().ToString();
            LblTotalComplaintOfMessageCount.Text = db.Messages.Where(x => x.Subject == "Şikayet").Count().ToString();
            LblTotalEmployeeCount.Text = db.Employees.Count().ToString();
            LblTotalCurrentCount.Text = db.Currents.Count().ToString();
            LblTotalCategoryCount.Text = db.Categories.Count().ToString();
            LblTotalProductCount.Text = db.Products.Count().ToString();

            GrdReceivedMail.DataSource = db.Messages.Select(x=> new
            {
               x.MessageId,
               x.NameSurname,
               x.Subject,
               x.Email,
               x.MessageContent
            }).ToList();
        }
    }
}
