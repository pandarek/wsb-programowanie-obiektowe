using System;
namespace TravelOffice
{
    [Serializable]
    public class Date
    {
        private int _rok;
        private int _miesiac;
        private int _dzien;

        public Date() { }

        public int Rok
        {
            get
            {
                return _rok;
            }

            set
            {
                _rok = value;
            }
        }

        public int Dzien
        {
            get => _dzien;
            set => _dzien = value;
        }

        public int Miesiac
        {
            get => _miesiac;
            set => _miesiac = value;
        }

        public Date(int rok, int miesiac, int dzien)
        {
            this._rok = rok;
            this._miesiac = miesiac;
            this._dzien = dzien;

        }

        public override string ToString()
        {
            return Rok + "-" + Miesiac + "-" + Dzien;
        }

    }
}
