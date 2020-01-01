using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HotelDrCsharp
{
    class Employee
    {
        private string _imie;
        private string _nazwisko;
        private string _stanowisko;
        private string _telefon;
        private string _email;
        private string _login;

        public string Imie { get => _imie; set => _imie = value; }
        public string Nazwisko { get => _nazwisko; set => _nazwisko = value; }
        public string Stanowisko { get => _stanowisko; set => _stanowisko = value; }
        public string Telefon { get => _telefon; set => _telefon = value; }
        public string Email { get => _email; set => _email = value; }

        public string login { get => _login; set => _login = value; }
        
        public Employee()
        {
        }
    }
}
