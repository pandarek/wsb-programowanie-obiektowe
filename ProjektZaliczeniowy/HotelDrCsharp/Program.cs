using System;

namespace HotelDrCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            bool end = false;
            int roomnumber;

            Hotel hotel = new Hotel();

           // Hotel.hotellist[0].book();
            //hotel.ToString();
            //Hotel.hotellist[4].book();
            //Hotel.hotellist[3].Roomsize = 2;
            //hotel.ToString();

           
                        

            do
            {
                Helper.MainMenu();

                switch (Helper.InputInt("\nWybierz opcję: "))
                {
                    case 1:
                        Hotel.hotellist.FindAll(s => s.Status == false).ForEach(Console.WriteLine);
                        roomnumber = (Helper.InputInt("\nPodaj numer pokoju: ") - 1);
                        Hotel.hotellist[roomnumber].book();
                        break;
                    case 2:
                        Hotel.hotellist.FindAll(s => s.Status != false).ForEach(Console.WriteLine);
                        roomnumber = (Helper.InputInt("\nPodaj numer pokoju: ") - 1);
                        Hotel.hotellist[roomnumber].cancelreservation();
                        break;
                    case 4:
                        hotel.ToString();
                        Helper.Wait();
                        break;
                    case 5:
                        Hotel.hotellist.FindAll(s => s.Status == false).ForEach(Console.WriteLine);
                        Helper.Wait();
                        break;
                    case 6:
                        Hotel.hotellist.FindAll(s => s.Status != false).ForEach(Console.WriteLine);
                        Helper.Wait();
                        break;
                    case 7:
                        end = true;
                        break;
                    default:
                        break;
                }

            } while (!end);
        }
    }
}