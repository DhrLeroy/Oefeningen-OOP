using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Pizza
    {

        public Pizza(float diameter_cm, string naam, bool is_vegetarisch, float prijs_euro, params List<string> ingrediënten)
        {
            Diameter_cm = diameter_cm;
            Naam = naam;
            Is_vegetarisch = is_vegetarisch;
            Prijs_euro = prijs_euro;
            Ingrediënten = ingrediënten;
        }

        public float Diameter_cm { get; set; }
        public string Naam { get; set; }
        public bool Is_vegetarisch { get; set; }
        public float Prijs_euro { get; set; }
        public List<string> Ingrediënten { get; set; }

        public string Geef_Naam_Prijs()
        {
            return $"{Naam}: {Prijs_euro} euro";
        }

        public void Print_Naam_Prijs()
        {
            Console.WriteLine(Geef_Naam_Prijs());
        }
    }
}
