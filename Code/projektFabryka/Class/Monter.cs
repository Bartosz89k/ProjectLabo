using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projektFabryka.Class
{
    class Monter : Pracownik
    {

        public Monter(string nazwisko)
            : base(nazwisko) // ten sam konstruktor, inkrementuje statica w klasie Pracownik
        {
            //... co sie ma tutaj wykonywać w związku z tym, że jest sprzedawcą
        }
    }
}

