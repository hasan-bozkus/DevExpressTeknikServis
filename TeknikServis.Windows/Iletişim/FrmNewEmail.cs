using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TeknikServis.Windows.Iletişim
{
    public partial class FrmNewEmail : Form
    {
        public FrmNewEmail()
        {
            InitializeComponent();
        }

        private void SmpBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SmpBtnSend_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            string from = "deneme@gmail.com";
            string password = "******";
            string receiver = TxtReceiverEmail.Text;
            string subject = TxtSubject.Text;
            string content = TxtMessageContent.Text;

            mail.From = new MailAddress(from);
            mail.To.Add(receiver);
            mail.Subject = subject;
            mail.Body = content;
            mail.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient("smtp-gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential(from, password);
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);
            MessageBox.Show("E-Posta Gönderildi!");
            this.Close();
        }
    }
}
