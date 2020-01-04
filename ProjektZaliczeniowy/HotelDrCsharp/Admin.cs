using System;
namespace HotelDrCsharp
{
    [Serializable]
    public class Admin : User
    {
        private bool _isadmin;

        public Admin(string Login, string Password, string Imie, string Nazwisko, string Telefon, string Email, string Stanowisko = "admin", bool ChangePassword = true) : base(Login, Password, Imie, Nazwisko, Telefon, Email, Stanowisko, ChangePassword)
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