using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExtende17_08_2020
{
    class Werknemer
    {
        private string Naam;
        private DateTime GeborteDatum;
        private string Geslacht;


        public Werknemer(string naam,DateTime gebortedatum,string geslacht)
        {
            Naam = naam;
           GeborteDatum = gebortedatum;
            Geslacht = geslacht;
        }
    }
}
