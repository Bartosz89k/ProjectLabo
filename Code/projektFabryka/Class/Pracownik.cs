using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projektFabryka.Class
{
    class Pracownik
    {
        public string Nazwisko { get; set; }
        public int ID { get; set; }

        static int PracownikCount = 0;      //  liczba wszystkich pracowników

        public Pracownik(string nazwisko)
            {
                this.Nazwisko = nazwisko;
                PracownikCount++;           // inkrementuje liczbę pracowników
                this.ID = PracownikCount;   // i nadaje pracownikowi numer na podstawie liczby pracowników.
            }
    }
}
