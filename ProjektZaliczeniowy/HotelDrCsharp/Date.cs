//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace HotelDrCsharp
//{
//    public class Date
//    {
//  ---------------------------------------------------------------        
//    //static void Date(string[] args)
//    //{
//    //    DateTime date = DateTime.Now;
//    //    Console.WriteLine(date.ToShortDateString());
//    //    Console.ReadLine();
//    //}

//    //TODO wstępna wersja do poprawki

//--------------------------------------------------------
//        private int _rok;
//        private int _miesiac;
//        private int _dzien;

//        public int Rok
//        {
//            get => _rok;
//            set
//            {
//                if ((value > 2019))
//                {
//                    _rok = value;
//                }
//            }

//        }

//        public int Miesiac
//        {
//            get => _miesiac;
//            set
//            {
//                if ((value > 0) && (value < 13))
//                {
//                    _miesiac = value;
//                }

//            }
//        }

//        public int Dzien
//        {
//            get => _dzien;
//            set
//            {
//                if ((value > 0) && (value < 32))
//                {
//                    _dzien = value;
//                }

//            }
//        }

//        public Date(int _rok, int _miesiac, int _dzien)
//        {
//            this.rok = _rok;
//            this.miesiac = _miesiac;
//            this.dzien = _dzien;
//        }

//        public string getInfo()
//        {
//            return ToString();
//        }

//        public override string ToString()
//        {
//            return { _rok: { 0:ffff} }+ { _miesiac: { 0:MM} }+ { _dzien: { 0:dd} };
//      
//            
//        }



//    }
//}
