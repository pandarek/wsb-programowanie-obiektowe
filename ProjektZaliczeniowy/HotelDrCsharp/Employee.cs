using System;

namespace HotelDrCsharp
{
    [Serializable]
    public class Employee : User
    {
        private bool _isuser;

        public Employee(string Login, string Password, string Imie, string Nazwisko, string Telefon, string Email, string Stanowisko = "recepcja") : base(Login, Password, Imie, Nazwisko, Telefon, Email, Stanowisko)
        {
            this._isuser = true;
        }

        public override bool IsUser()
        {
            return _isuser;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}