using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utwor
{
    public class Utworek
    {
        private int id;
        private string tytul;
        private string wykonawca;
        private double dlugosc;
        private int rok_wydania;
        private int id_albumu;

        public Utworek(int id, string tytul, string wykonawca, double dlugosc, int rok_wydania, int id_albumu)
        {
            this.id = id;
            this.tytul = tytul;
            this.wykonawca = wykonawca;
            this.dlugosc = dlugosc;
            this.rok_wydania = rok_wydania;
            this.id_albumu = id_albumu;
        }


        public void setId_albumu(int id_albumu)
        {
            this.id_albumu = id_albumu;
        }

        public int getId_albumu()
        {
            return id_albumu;
        }


        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public void setTytul(string tytul)
        {
            this.tytul = tytul;
        }

        public void setWykonawca(string wykonawca)
        {
            this.wykonawca = wykonawca;
        }

        public void setDlugosc(double dlugosc)
        {   
            this.dlugosc = dlugosc;
        }

    

        public void setRok_wydania(int rok_wydania)
        {
            this.rok_wydania = rok_wydania;
        }

        public string getTytul()
        {
            return tytul;
        }

        public string getWykonawca()
        {
            return wykonawca;
        }
        public float getDlugosc()
        {
            float wynik= Convert.ToSingle(dlugosc);

            return wynik;
        }
  
        public int getRok_wydania()
        {
            return rok_wydania;
        }
    }
}
