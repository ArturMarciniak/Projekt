using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Utwor;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WCFService.svc or WCFService.svc.cs at the Solution Explorer and start debugging.
    public class WCFService : IWCFService
    {
        public void dodajAlbum(int id_albumu, string nazwa_albumu, int wydawnictwo)
        {
        
                Operacje_na_bazie operacja = new Operacje_na_bazie();
                int id = operacja.getAlbumId();
                Album album = new Album(id, nazwa_albumu, wydawnictwo);

                operacja.DodajAlbumDoBazy(album);
                operacja.CloseConnection();


        }

        public void dodajUtwor(int id, string tytul, string wykonawca, float dlugosc, int rok_wydania, int id_albumu)
        {

                 Operacje_na_bazie operacja = new Operacje_na_bazie();
                 int id_utworu = operacja.getUtworId();
                 Utwor utwor = new Utwor(id_utworu, tytul, wykonawca, dlugosc, rok_wydania, id_albumu);

                 operacja.DodajUtworDoBazy(utwor);
                 operacja.CloseConnection();
        }
        public void dodajWydawnictwo(int id, string nazwa, int rok_zal, string wlasciciel, string kraj)
        {

                Operacje_na_bazie operacja = new Operacje_na_bazie();
                int id_wyd = operacja.getWydawnictwoId();
                Wydawnictwo wyd = new Wydawnictwo(id_wyd, nazwa, rok_zal , wlasciciel, kraj);

                operacja.DodajWydawnictwoDoBazy(wyd);
                operacja.CloseConnection();
        }

        public void usunAlbum(int id)
        {
                 Operacje_na_bazie baza = new Operacje_na_bazie();

                 baza.UsunAlbum(id);
        }

        public void usunUtwor(int id)
        {
                Operacje_na_bazie baza = new Operacje_na_bazie();

                baza.UsunUtwor(id);
        }

        public void usunWydawnictwo(int id)
        {
                Operacje_na_bazie baza = new Operacje_na_bazie();

                baza.UsunWydawnictwo(id);
        }

        
    }
}
