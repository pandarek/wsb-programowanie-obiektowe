using System;
namespace TravelOffice
{
    public class Date
    {
        //punkt 1
        private int rok;
        private int miesiac;
        private int dzien;

        //punkt f
        public int Rok
        {
            get
            {
                return rok;
            }

            set
            {
                rok = value;
            }
        }

        //punkt f (druga wersja)
        public int Dzien { get; set; }

        //punkt 2,3
        public Date(int rok, int miesiac, int dzien)
        {
            this.rok = rok;
            this.miesiac = miesiac;
            this.Dzien = dzien;

        }

        //punkt c
        public override string ToString()
        {
            return rok + "-" + miesiac + "-" + Dzien;
        }

    }
}
