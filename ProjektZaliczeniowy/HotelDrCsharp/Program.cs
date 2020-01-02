﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HotelDrCsharp
{
    class Program
    {
        //DONE sprawdzić i poprawić kod, szczególlnie pętle
        //TODO właściwa serializacja zapis użytkowników i haseł
        //DONE nadanie tylko adminowi uprawnien do nadawania haseł


        //--------------------------------------------------------------------
        public static Employee currentuser;
        public static List<Employee> users;
        public static bool isadmin;
        //---------------------------------------------------------------------
        static void Main(string[] args)
        //---------------------------------------------------------------------
        {

            ProgramStart();

        }

        public static void ProgramStart()
        {
            bool startup = true;

            //default admin
            Employee admin = new Admin("admin", "admin2020", "", "", "", "");

            //default user
            Employee user = new Employee("user", "user2020", "", "", "", "");

            users = new List<Employee>();

            users.Add(admin);
            users.Add(user);

            do
            {

                Console.Title = "DrCsharp - System Rezerwacji Hotelowej"; //nazwa konsoli
                Console.BackgroundColor = ConsoleColor.Gray; //kolor tła konsoli
                Console.ForegroundColor = ConsoleColor.Black; //kolor pierwszego planu konsoli

                Console.Clear();

                Console.WriteLine("\nSystem rezerwacji HotelDrCsharp\n");
                Console.WriteLine("Podaj login:");
                string username = Console.ReadLine();

                Console.WriteLine("Podaj haslo:");
                string password = Helper.GetConsolePassword();


                bool logincorrect = users.Any(item => item.Login == username && item.Password == password);


                if (logincorrect)
                {
                    currentuser = users.Find(item => item.Login == username);
                    startup = false;
                    Run(); ///działa wychodzi z pętli i przechodzi do właściwego programu :)

                }
                else
                {
                    Console.WriteLine("Nieprawidlowy uzytkownik!");
                    Helper.Wait();
                }
                Console.Clear();



            } while (startup == true);

        }



        public static void Run()
        {

            //---------------------------------------------------------------------
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
                Console.WriteLine();

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
                    case 3:
                        roomnumber = (Helper.InputInt("\nPodaj numer pokoju: ") - 1);
                        Console.WriteLine(Hotel.hotellist[roomnumber].ToString());
                        Helper.Wait();
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
                    case 9:
                        if (currentuser.IsAdminn())
                        {
                            Setup.Run();
                        }
                        else
                        {
                            Console.WriteLine("Nie masz uprawnień");
                            Helper.Wait();
                        }

                        break;
                    case 0:
                        end = true;
                        break;
                    default:
                        break;

                }

            } while (!end);
        }
    }
}