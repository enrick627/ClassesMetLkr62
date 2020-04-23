using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetLkr
{
    class Program
    {
        static void Main(string[] args)
        {
            Leerling leerling;
            leerling = new Leerling();
            string Naam, famnaam;
            Console.WriteLine("geef een voornaam");
            Naam = Console.ReadLine();

            Console.WriteLine("geef een famillienaam");
            famnaam = Console.ReadLine();

            leerling.Voornaam = "emma";
            leerling.Familienaam = "thomson";
            leerling.Naam = Naam;
            leerling.famnaam = famnaam;
            Console.WriteLine($"{leerling.Voornaam} {leerling.Familienaam}");
            Console.WriteLine($"{leerling.Naam} {leerling.famnaam}");
            Console.WriteLine(leerling);

            //wachten 
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();

        }
    }
}
