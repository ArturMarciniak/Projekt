using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Utwor;

namespace WcfService3
{


    public class WCFService : IWCFService
    {
        public void dodajAlbum(string nazwa_albumu, double dlugosc_albumu, int wydawnictwo)
        {
        
                Operacje_na_bazie operacja = new Operacje_na_bazie();
                int id = operacja.getAlbumId();
                Album album = new Album(id, nazwa_albumu, dlugosc_albumu, wydawnictwo);

                operacja.DodajAlbumDoBazy(album);
                operacja.CloseConnection();


        }

        public void dodajUtwor(string tytul, string wykonawca, double dlugosc, int rok_wydania, int id_albumu)
        {

                 Operacje_na_bazie operacja = new Operacje_na_bazie();
                 int id_utworu = operacja.getUtworekId();
                 Utworek utworek = new Utworek(id_utworu, tytul, wykonawca, dlugosc, rok_wydania, id_albumu);

                 operacja.DodajUtworekDoBazy(utworek);
                 operacja.CloseConnection();
        }
        public void dodajWydawnictwo(string nazwa, int rok_zal, string wlasciciel, string kraj)
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

                baza.UsunUtworek(id);
        }

        public void usunWydawnictwo(int id)
        {
                Operacje_na_bazie baza = new Operacje_na_bazie();

                baza.UsunWydawnictwo(id);
        }

        
    }
}
