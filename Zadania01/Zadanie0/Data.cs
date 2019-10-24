using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProgemObiektowy
{
    class Data
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
        public Data(int rok, int miesiac, int dzien)
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
