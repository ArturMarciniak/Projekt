using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utwor
{
    public class Album
    {
        private int id_albumu;
        private string nazwa_albumu;
        private double dlugosc_albumu;
        private int wydawnictwo;

        public Album(int id_albumu, string nazwa_albumu, double dlugosc_albumu, int wydawnictwo)
        {
            this.id_albumu = id_albumu;
            this.nazwa_albumu = nazwa_albumu;
            this.dlugosc_albumu = dlugosc_albumu;
            this.wydawnictwo = wydawnictwo;
        }

        public void setWydawnictwo(int wydawnictwo)
        {
            this.wydawnictwo = wydawnictwo;
        }

        public int getWydawnictwo()
        {
            return wydawnictwo;
        }

        public void setId_albumu(int id_albumu)
        {
            this.id_albumu = id_albumu;
        }

        public int getId_albumu()
        {
            return id_albumu;
        }

        public void setNazwa(string nazwa_albumu)
        {
            this.nazwa_albumu = nazwa_albumu;
        }

        public void setDlugosc(double dlugosc_albumu)
        {
            this.dlugosc_albumu = dlugosc_albumu;

        }

        public string getNazwa()
        {
            return nazwa_albumu;
        }

        public double getDlugosc()
        {
            return dlugosc_albumu;
        }

      

    }
}
    