using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projektFabryka.Class
{
    class Klient
    {
        int Pieniadze {set; get; }
        string Nazwisko { set; get; }
        public int ID { get; set; }

        static int KlientCount = 0;      //  liczba wszystkich klientow

        public Klient(string nazwisko, int pieniadze)
        {
            this.Pieniadze = pieniadze;
            this.Nazwisko = nazwisko;

            KlientCount++;           // inkrementuje liczbę klientow
            this.ID = KlientCount;   // i nadaje klientowi numer na podstawie liczby klientow.
        }

    }
}
