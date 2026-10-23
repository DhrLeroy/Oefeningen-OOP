using System;
using System.Collections.Generic;
using System.Text;

namespace OplossingB
{
    public class Boek
    {
        public string Titel { get; set; }
        public string Auteur { get; set; }
        public bool Uitgeleend { get; set; }

        public Boek(string titel,
                    string auteur,
                    bool uitgeleend)
        {
            Titel = titel;
            Auteur = auteur;
            Uitgeleend = uitgeleend;
        }

        public bool KanUitlenen()
        {
            return !Uitgeleend;
        }

        public void LeenUit()
        {
            Uitgeleend = true;
        }

        public void BrengTerug()
        {
            Uitgeleend = false;
        }

        public string GeefStatus()
        {
            return Uitgeleend
                ? $"{Titel} - Uitgeleend"
                : $"{Titel} - Beschikbaar";
        }
    }
}
