using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utwor;

namespace TestyJednostkowe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Album album = new Album(1, "KKK", 2, 2);
            Assert.IsNotNull(album);
        }
        [TestMethod]

        public void TestMethod2()
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

    }
}
