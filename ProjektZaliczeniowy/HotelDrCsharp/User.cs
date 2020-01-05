using System;
namespace HotelDrCsharp
{
    [Serializable]
    public class User
    {
        private string _imie;
        private string _nazwisko;
        private string _stanowisko;
        private string _telefon;
        private string _email;
        private string _login;
        private string _password;
        private bool _changepassword;

        public string Imie { get => _imie; set => _imie = value; }
        public string Nazwisko { get => _nazwisko; set => _nazwisko = value; }
        public string Stanowisko { get => _stanowisko; set => _stanowisko = value; }
        public string Telefon { get => _telefon; set => _telefon = value; }
        public string Email { get => _email; set => _email = value; }

        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }

        public bool ChangePassword { get => _changepassword; set => _changepassword = value; }

        public User(string Login, string Password, string Imie, string Nazwisko, string Telefon, string Email, string Stanowisko = "recepcja", bool ChangePassword = true)
        {
            this._login = Login;
            this._password = Password;
            this._imie = Imie;
            this._nazwisko = Nazwisko;
            this._stanowisko = Stanowisko;
            this._email = Email;
            this._telefon = Telefon;
            this._changepassword = true;
        }
        public virtual bool IsAdminn()
        {
            return false;
        }
        public virtual bool IsUser()
        {
            return false;
        }
        public override string ToString()
        {
            return $"Login: {_login}, {_stanowisko}";
        }
    }
}
