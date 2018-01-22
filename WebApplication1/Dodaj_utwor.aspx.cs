using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Dodaj_utwor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu_form.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string tyt = Tytul.Text;
            string wyk = Wykonawca.Text;
            double dlu = Convert.ToDouble(Dlugosc.Text);
            int rok = Convert.ToInt32(Rok.Text);
            int alb = Convert.ToInt32(Id_albumu.Text);


            Polaczenie.WCFServiceClient klient = new Polaczenie.WCFServiceClient();
            klient.Open();
            klient.dodajUtwor(tyt, wyk, dlu, rok, alb);
           
            Response.Write("<script LANGUAGE='JavaScript' >alert('Utwor dodany pomyślnie')</script>");

            Response.Redirect("~/Dodaj_utwor.aspx");
            klient.Close();
        }

        
    }
}