using System;
namespace ContactManager
{
    [Serializable]
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

        public string Ulica { get => _ulica; set => _ulica = value; }
        public string NumerDomu { get => _numer_domu; set => _numer_domu = value; }
        public string NumerMieszkania { get => _numer_mieszkania; set => _numer_mieszkania = value; }
        public string KodPocztowy { get => _kod_pocztowy; set => _kod_pocztowy = value; }
        public string Miasto { get => _miasto; set => _miasto = value; }
        public string Panstwo { get => _panstwo; set => _panstwo = value; }


        public override string ToString()
        {
            return $"ul. {_ulica} {_numer_domu}/{_numer_mieszkania}\n{_kod_pocztowy} {_miasto} \n{_panstwo}";


        }
    }
}
