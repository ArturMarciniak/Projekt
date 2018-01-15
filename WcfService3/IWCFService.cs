using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Utwor;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFService" in both code and config file together.
    [ServiceContract]
    public interface IWCFService
    {

        //Dodawanie
        [OperationContract]
        void dodajUtwor(string tytul, string wykonawca, double dlugosc, int rok_wydania, int id_albumu);



        [OperationContract]
        void dodajAlbum(string nazwa_albumu, double dlugosc_albumu, int wydawnictwo);



        [OperationContract]
        void dodajWydawnictwo(string nazwa, int rok_zal, string wlasciciel, string kraj);



        //Usuwanie
        [OperationContract]
        void usunWydawnictwo(int id);


         
        [OperationContract]
        void usunUtwor(int id);



        [OperationContract]
        void usunAlbum(int id);



    }
}
