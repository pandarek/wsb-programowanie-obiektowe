using System;
namespace Zadania01
{
    public class Adres
    {
        private string _ulica;
        private string _numer_domu;
        private string _numer_mieszkania;
        private string _kod_pocztowy;
        private string _miasto;
        private string _panstwo;



        public void UstawAders(string ulica, string numer_domu, string numer_mieszkania, string kod_pocztowy, string miasto, string panstwo)
        {
            this._ulica = ulica;
            this._numer_domu = numer_domu;
            this._numer_mieszkania = numer_mieszkania;
            this._kod_pocztowy = kod_pocztowy;
            this._miasto = miasto;
            this._panstwo = panstwo;

        }



        public override string ToString()
        {
            return $"ul. {_ulica} {_numer_domu}/{_numer_mieszkania}\n{_kod_pocztowy} {_miasto} \n{_panstwo}";


        }
    }
}