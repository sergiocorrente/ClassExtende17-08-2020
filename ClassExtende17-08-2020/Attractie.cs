using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExtende17_08_2020
{
    class Attractie
    {
        public string Naam;
        public string Kleur;
        public int Minimumleeftijd;
        public int AantalPersonen;

        public Attractie(string naam,string kleur, int minimumLeeftijd, int aantalPersonen)
        {
            Naam = naam;
            Kleur = kleur;
            Minimumleeftijd = minimumLeeftijd;
            AantalPersonen = aantalPersonen;
        }
    }
}
