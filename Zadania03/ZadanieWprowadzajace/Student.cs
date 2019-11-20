using System;
namespace ZadanieWprowadzajace
{
    public class Student : Osoba
    {
        
        private int _nrindeksu = 100;
        private string _imie;
        private string _nazwisko;

       // public int NrIndeksu { get; set; }
        

        public Student(int NrIndeksu, string Imie, string Nazwisko) : base(Imie, Nazwisko)
        {
            this._nrindeksu = NrIndeksu;
            this._imie = Imie;
            this._nazwisko = Nazwisko;
           
        }

        public override string ToString()
        {
            return $"Imie: {_imie}, Nazwisko: {_nazwisko}, Nr indeksu: {_nrindeksu}";
        }
    }
}