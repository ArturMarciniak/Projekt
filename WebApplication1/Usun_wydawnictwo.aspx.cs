using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Usun_wydawnictwo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Wydawnictwo_form.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdWydawnictwa.Text);
            Polaczenie.WCFServiceClient klient = new Polaczenie.WCFServiceClient();
            klient.Open();
            klient.usunWydawnictwo(id);
            klient.Close();
            Response.Redirect("~/Usun_wydawnictwo.aspx");
        }
    }
}