using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeknikServis.Web.Entites;

namespace TeknikServis.Web
{
    public partial class Default : System.Web.UI.Page
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            RptAboutTextDataSourceArea.DataSource = db.Abouts.Take(1).ToList();
            RptAboutTextDataSourceArea.DataBind();

            RptProductsDataSourceArea.DataSource = db.Products.Take(6).ToList();
            RptProductsDataSourceArea.DataBind();
        }

        protected void BtnSendMessage_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();
            messages.NameSurname = TxtName.Text;
            messages.Email = TxtEmail.Text;
            messages.Subject = TxtSubject.Text;
            messages.MessageContent = TxtContent.Text;
            db.Messages.Add(messages);
            db.SaveChanges();
        }
    }
}