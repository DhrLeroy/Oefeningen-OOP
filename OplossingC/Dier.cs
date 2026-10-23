using System;
using System.Collections.Generic;
using System.Text;

namespace OplossingC
{
    public class Dier
    {
        public string Naam { get; set; }
        public string Soort { get; set; }
        public int Leeftijd { get; set; }
        public bool IsGezond { get; set; }

        public Dier(string naam,
                    string soort,
                    int leeftijd,
                    bool isGezond)
        {
            Naam = naam;
            Soort = soort;
            Leeftijd = leeftijd;
            IsGezond = isGezond;
        }

        public void Verjaar()
        {
            Leeftijd++;
        }

        public void WordtZiek()
        {
            IsGezond = false;
        }

        public void Genees()
        {
            IsGezond = true;
        }

        public bool HeeftSeniorLeeftijd()
        {
            return Leeftijd >= 10;
        }

        public string GeefStatus()
        {
            string gezondheid = IsGezond ? "Gezond" : "Ziek";

            return $"{Naam} ({Soort}) - {Leeftijd} jaar - {gezondheid}";
        }
    }
}
