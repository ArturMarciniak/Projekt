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
        public void dodajAlbum(int id_albumu, string nazwa_albumu, float dlugosc_albumu, int wydawnictwo, int iterator)
        {
            
        }

        public void dodajUtwor(int id, string tytul, string wykonawca, float dlugosc, int rok_wydania, int id_albumu)
        {
            throw new NotImplementedException();
        }

        public void dodajWydawnictwo(int id, string nazwa, int rok_zal, string wlasciciel, string kraj)
        {
            throw new NotImplementedException();
        }

        public void usunAlbum(int id)
        {
            throw new NotImplementedException();
        }

        public void usunUtwor(int id)
        {
            throw new NotImplementedException();
        }

        public void usunWydawnictwo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
