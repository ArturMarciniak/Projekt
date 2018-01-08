﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utwor
{
    class Wydawnictwo
    {
        private int id;
        private string nazwa;
        private int rok_zal;
        private string wlasciciel;
        private string kraj;


        public Wydawnictwo(int id, string nazwa, int rok_zal, string wlasciciel, string kraj)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.rok_zal = rok_zal;
            this.wlasciciel = wlasciciel;
            this.kraj = kraj;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }
    }

}