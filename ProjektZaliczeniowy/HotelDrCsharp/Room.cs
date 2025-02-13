﻿using System;
namespace HotelDrCsharp
{
    public class Room
    {
        private bool _status;
        private int _roomnumber;
        private int _roomsize;

        public Room() { }

        public Room(int _roomnumber, int _roomsize, bool _status = false)
        {
            this._status = Status;
            this._roomnumber = Roomnumber;
            this._roomsize = Roomsize;

        }

        public int Roomnumber { get; set; }
        public int Roomsize { get; set; }
        public bool Status { get; set; }      

      //public void book()
      //  {
      //      if (Status)
      //      {
                
      //          Console.WriteLine("\nPokój już zarezerwowany");
      //          Helper.Wait();
                
      //      }
      //      else
      //      {
      //          Customer = Helper.AddCustomer();

      //          StartDate = Helper.AddStartDate();
                
      //          EndDate = Helper.AddEndDate(StartDate);

      //          Status = true;
                
      //          Console.WriteLine($"\nPokój {Roomnumber} Rezerwacja dokonana");
      //          Helper.Wait();
      //      }
      //  }

        //public void cancelreservation()
        //{
        //    if (!Status)
        //    {
        //        Console.WriteLine("\nPokój nie jest zarezerwowany");
        //        Helper.Wait();
        //    }
        //    else
        //    {
        //        Status = false;
        //        Customer = null;
        //        StartDate = new DateTime();
        //        EndDate = new DateTime();
        //        Console.WriteLine($"\nRezerwacja {Roomnumber} anulowana");
        //        Helper.Wait();
        //    }
        //}


        public override string ToString()
        {
            string status = (Status) ? "rezerwcja" : "wolne";

            return $"Pokój: {Roomnumber}, Status: {status}";
        }
    }
}