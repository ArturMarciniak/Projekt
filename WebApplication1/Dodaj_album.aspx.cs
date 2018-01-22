using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Dodaj_album : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string nazwa = naz.Text;
            double dlugosc = Convert.ToDouble(dlu.Text);
            int wykonawca = Convert.ToInt32(wyk.Text);


            Polaczenie.WCFServiceClient klient = new Polaczenie.WCFServiceClient();
            klient.Open();
            klient.dodajAlbum(nazwa, dlugosc, wykonawca);

            Response.Write("<script LANGUAGE='JavaScript' >alert('Album dodany pomyślnie')</script>");

            Response.Redirect("~/Dodaj_album.aspx");
            klient.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Album_form.aspx");
        }
    }
}