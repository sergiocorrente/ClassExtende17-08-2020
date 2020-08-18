using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExtende17_08_2020
{
    class Prepark
    {
        public string Naam { get; set; }
        public List <Werknemer> WerknemersLijst { get; set; }
        public List<Attractie> AttractieLijst { get; set; }
         public Prepark(string naam)
        {
            Naam = naam;
        }
            public override string ToString()
        {
            return Naam;
        }


    }


 }

