using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Dodaj_wydawnictwo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Wydawnictwo_form.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string nazwa = naz.Text;
            int rok_zal = Convert.ToInt32(rok.Text);
            string wlasciciel = wlasc.Text;
            string kraj = kra.Text;

            Polaczenie.WCFServiceClient klient = new Polaczenie.WCFServiceClient();
            klient.Open();
            klient.dodajWydawnictwo(nazwa, rok_zal, wlasciciel, kraj);

            Response.Write("<script LANGUAGE='JavaScript' >alert('Wydawnictwo dodane pomyślnie')</script>");

            Response.Redirect("~/Dodaj_wydawnictwo.aspx");
            klient.Close();
        }
    }
}