using System;
using System.Collections.Generic;
using System.Text;

namespace OplossingA
{
    public class Bankrekening
    {
        public string RekeningNummer { get; set; }
        public string Eigenaar { get; set; }
        public double Saldo { get; private set; }

        public Bankrekening(string rekeningNummer,
                            string eigenaar,
                            double saldo)
        {
            RekeningNummer = rekeningNummer;
            Eigenaar = eigenaar;
            Saldo = saldo;
        }

        public void Stort(double bedrag)
        {
            Saldo += bedrag;
        }

        public bool KanAfhalen(double bedrag)
        {
            return Saldo >= bedrag;
        }

        public void Afhalen(double bedrag)
        {
            if (KanAfhalen(bedrag))
            {
                Saldo -= bedrag;
            }
        }

        public string GeefOverzicht()
        {
            return $"{Eigenaar} ({RekeningNummer}) heeft {Saldo} euro op zijn rekening.";
        }
    }
}
