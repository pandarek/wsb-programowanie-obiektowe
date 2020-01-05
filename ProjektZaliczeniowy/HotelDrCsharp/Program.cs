using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace HotelDrCsharp
{


    class Program
    {


        //INFO zmieniona logika klass na klasę głowną przechowująca rezerwację (Reservation)

        //DONE sprawdzić i poprawić kod, szczególlnie pętle
        //DONE nadanie tylko adminowi uprawnien do nadawania haseł
        //DONE dodawanie daty rezerwacji
        //DONE sprawdzanie daty rezerwacji czy start nie jest cześniej niż koniec
        //DONE właściwa serializacja zapis użytkowników i haseł oraz danych hotelu
        //DONE zniana hasła domyślnego dla admina i usera przy pierwszym uruchomieniu

        //TODO wyświetalnie rezerwacji (tabelka?)
        //TODO wyliczenia kosztów rezerwacji

        //TODO dodanie szegółów klienta (obecnie jest imie i nazwisko)
        //TODO dodawanie admina (obecnie tylko user)
        //TODO ujednolicenie sztaty graficznej


        //--------------------------------------------------------------------
        public static User currentuser;
        public static List<User> users;
        public static bool isadmin;
        public static Hotel hotel = new Hotel();
        //---------------------------------------------------------------------
        static void Main(string[] args)
        //---------------------------------------------------------------------

        {

            DefaultUser();
            Login();
            Start();


        }


        //ustawienie domyślnego użytkownika przy pierwszym uruchomieniu
        public static void DefaultUser()
        {
            users = new List<User>();

            if (!File.Exists(@"./users.bin"))
            {

                //default admin
                User admin = new Admin("admin", "admin2020", "", "", "", "");

                //default user
                User user = new Employee("user", "user2020", "", "", "", "");

                users.Add(admin);
                users.Add(user);
            }
            else
            {
                SerializeBIN.LoadUsers();
            }

        }


        //procedura logowania
        public static void Login()
        {
            bool startup = false;
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

                //sprawdzenie czy user i hasło istnieje i jest poprawne
                bool logincorrect = users.Any(item => item.Login == username && item.Password == password);


                if (logincorrect)
                {
                    //przypisanie bieżacego usera
                    currentuser = users.Find(item => item.Login == username);

                    //wymagana zmina hasła przy pierwszym logowaniu
                    if (currentuser.ChangePassword)
                    {
                        Console.WriteLine("Wymagana zamina hasła");
                        currentuser.Password = Helper.EnterPassword();
                        currentuser.ChangePassword = false;

                        SerializeBIN.SaveUsers();
                        Helper.Wait();

                    }

                    startup = true;

                }
                else
                {
                    Console.WriteLine("Nieprawidlowy uzytkownik!");
                    Helper.Wait();
                }
                Console.Clear();

            } while (!startup);

        }

        enum MainMenu
        {
            Exit, AddReservation, CancelReservation, ShowRezervations, ShowRooms, ShowFreeRooms, ShowReservedRooms, SetUp = 9,
        }

        public static void Start()
        {

            //---------------------------------------------------------------------
            bool end = false;



            do
            {
                Helper.MainMenu();
                Console.WriteLine();

                switch (Helper.InputInt("\nWybierz opcję: "))
                {
                    case (int)MainMenu.AddReservation:
                        hotel.AddReservation();
                        //hotel.ReservationsList.ForEach(Console.WriteLine);
                        Helper.Wait();

                        break;

                    case (int)MainMenu.CancelReservation:

                        hotel.RemoveReservation();
                        Helper.Wait();
                        hotel.ReservationsList.ForEach(Console.WriteLine);
                        break;

                    case (int)MainMenu.ShowRezervations:

                        hotel.ReservationsList.ForEach(Console.WriteLine);
                        Helper.Wait();
                        break;

                    case (int)MainMenu.ShowRooms:

                        Hotel.hotellist.ForEach(Console.WriteLine);
                        Helper.Wait();
                        break;

                    case (int)MainMenu.ShowFreeRooms:

                        Hotel.hotellist.FindAll(s => s.Status == false).ForEach(Console.WriteLine);
                        Helper.Wait();
                        break;

                    case (int)MainMenu.ShowReservedRooms:

                        Hotel.hotellist.FindAll(s => s.Status != false).ForEach(Console.WriteLine);
                        Helper.Wait();
                        break;

                    case (int)MainMenu.SetUp:

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

                    case (int)MainMenu.Exit:

                        end = true;

                        SerializeBIN.SaveUsers();
                        SerializeXML.SaveRoomData();
                        SerializeXML.SaveReservationData();
                        break;

                    default:
                        break;
                }

            } while (!end);
        }
    }
}