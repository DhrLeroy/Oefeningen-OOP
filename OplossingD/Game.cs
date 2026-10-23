using System;
using System.Collections.Generic;
using System.Text;

namespace OplossingD
{
    public class Game
    {
        public string Titel { get; set; }
        public double Prijs { get; set; }
        public int AantalSpelers { get; set; }

        public Game(string titel,
                    double prijs,
                    int aantalSpelers)
        {
            Titel = titel;
            Prijs = prijs;
            AantalSpelers = aantalSpelers;
        }

        public void VoegSpelerToe()
        {
            AantalSpelers++;
        }

        public void VerwijderSpeler()
        {
            if (AantalSpelers > 0)
            {
                AantalSpelers--;
            }
        }

        public double BerekenOmzet()
        {
            return Prijs * AantalSpelers;
        }

        public bool IsPopulair()
        {
            return AantalSpelers >= 100;
        }

        public string GeefInfo()
        {
            return $"{Titel} heeft {AantalSpelers} spelers.";
        }
    }
}
