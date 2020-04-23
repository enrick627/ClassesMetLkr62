using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetLkr
{
    class Leerling
    {   //fields:

        private string famillienaam;
        //properties
        public string Voornaam { get; set; }

        public string Familienaam
        {
            get { return famillienaam; }
            set { famillienaam = value; }
        }
        public string Naam { get; set; }

        public string famnaam { get; set; }
        public override string ToString()
        {
            return $"{Voornaam.ToLower()} {famillienaam.ToUpper()} ";
        }
    }
}
