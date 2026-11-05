using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeknikServis.Web.Entites;

namespace TeknikServis.Web
{
    public partial class UrunTakip : System.Web.UI.Page
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnSearchProduct_Click(object sender, EventArgs e)
        {
            var values = db.ProductTracings.Where(x=> x.ProductSerialNo == TxtSerialNo.Text).ToList();
            RptProductTrackingResult.DataSource = values;
            RptProductTrackingResult.DataBind();
        }
    }
}