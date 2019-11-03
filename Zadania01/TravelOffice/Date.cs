using System;
namespace TravelOffice
{
    public class Date
    {
        private int rok;
        private int miesiac;
        private int dzien;

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

        public int Dzien { get; set; }

        public Date(int rok, int miesiac, int dzien)
        {
            this.rok = rok;
            this.miesiac = miesiac;
            this.Dzien = dzien;

        }

        public override string ToString()
        {
            return rok + "-" + miesiac + "-" + Dzien;
        }

    }
}
