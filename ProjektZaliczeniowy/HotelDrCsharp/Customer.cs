﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HotelDrCsharp
{
    public class Customer
    {
        private string _imie;
        private string _nazwisko;
        //private Adres _adres;
        private int _wiek;
        private string _telefon;
        private string _email;

        public string Imie { get => _imie; set => _imie = value; }
        public string Nazwisko { get => _nazwisko; set => _nazwisko = value; }

        //public Adres Adres { get => _adres; set => _adres = value; }

        public string Telefon { get => _telefon; set => _telefon = value; }
        public string Email { get => _email; set => _email = value; }

        
        //private static readonly List<Customer> customerlist = new List<Customer>
        public Customer()
        {
        }
    }
}