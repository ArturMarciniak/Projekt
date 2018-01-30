using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utwor;

namespace TestyJednostkowe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Create_album_test()
        {
            Album album = new Album(19, "KKK", 2, 2);
            Assert.IsNotNull(album);
        }

        [TestMethod]
        public void Create_album_test2()
        {
            Baza_muzyczna_wcf.WCFServiceClient client = new Baza_muzyczna_wcf.WCFServiceClient();

            string nazwa_albumu = "NAZWA";
            float dlugosc_albumu = 90;
            int wydawnictwo = 1;
            Operacje_na_bazie operacja = new Operacje_na_bazie();
            int id = operacja.getAlbumId();
            Album album = new Album(id, nazwa_albumu, dlugosc_albumu, wydawnictwo);

            Assert.IsNotNull(album);

        }

        [TestMethod]
        public void Create_Uworek_Test()
        {
            Utworek utworek = new Utworek(19, "KKK", "wpw", 2, 2001, 1);
            Assert.IsNotNull(utworek);
        }

        [TestMethod]
        public void Create_Uworek_Test2()
        {
            Baza_muzyczna_wcf.WCFServiceClient client = new Baza_muzyczna_wcf.WCFServiceClient();

            string tytul = "Beee";
            string wykonawca = "Freesh";
            double dlugosc = 2;
            int rok_wydania = 2005;
            int id_albumu = 1;
            Operacje_na_bazie operacja = new Operacje_na_bazie();
            int id = operacja.getUtworekId();
            Utworek utworek = new Utworek(id, tytul, wykonawca, dlugosc, rok_wydania, id_albumu);

            Assert.IsNotNull(utworek);

        }

        [TestMethod]
        public void Create_Wydawnictwo_Test()
        {
            Wydawnictwo wydawnictwo = new Wydawnictwo(19, "KKK", 2005, "Jan Kowalski", "Polska");
            Assert.IsNotNull(wydawnictwo);
        }

        [TestMethod]
        public void Create_Wydawnictwo_Test2()
        {
            Baza_muzyczna_wcf.WCFServiceClient client = new Baza_muzyczna_wcf.WCFServiceClient();

            string nazwa = "Beee";
            int rok = 2015;
            string wlasciciel = "Przemek";
            string kraj = "Polska";
            Operacje_na_bazie operacja = new Operacje_na_bazie();
            int id = operacja.getWydawnictwoId();
            Wydawnictwo wydawnictwo = new Wydawnictwo(id, nazwa, rok, wlasciciel, kraj);

            Assert.IsNotNull(wydawnictwo);

        }
    }
}
