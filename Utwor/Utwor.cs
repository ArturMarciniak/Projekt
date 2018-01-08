using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utwor
{
    public class Utwor
    {
        private int id;
        private string tytul;
        private string wykonawca;
        private float dlugosc;
        private int rok_wydania;
        private int id_albumu;

        public Utwor(int id_albumu, int id, string tytul, string wykonawca, float dlugosc, int rok_wydania, )
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

        public void setDlugosc(float dlugosc)
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
            return dlugosc;
        }
  
        public int getRok_wydania()
        {
            return rok_wydania;
        }
    }
}
