using System;
namespace HotelDrCsharp
{
    [Serializable]
    public class Admin : Employee
    {
        private bool _isadmin;

        public Admin(string Login, string Password, string Imie, string Nazwisko, string Telefon, string Email, string Stanowisko = "admin") : base(Login, Password, Imie, Nazwisko, Telefon, Email, Stanowisko)
        {
            this._isadmin = true;
        }
        public override bool IsAdminn()
        {
            return _isadmin;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}