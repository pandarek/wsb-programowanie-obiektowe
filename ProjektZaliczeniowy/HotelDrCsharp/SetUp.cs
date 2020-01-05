using System;
using System.Linq;

namespace HotelDrCsharp
{
    public class Setup
    {

        public static void Run()
        {

            //---------------------------------------------------------------------
            bool end = false;

            do
            {
                SetupMenu();
                Console.WriteLine();

                switch (Helper.InputInt("\nWybierz opcję: "))
                {
                    case 1:
                        AddUser();
                        SerializeBIN.SaveUsers();
                        break;

                    case 2:
                        Program.users.ForEach(Console.WriteLine);
                        Helper.Wait();
                        break;

                    case 6:
                        SerializeBIN.SaveUsers();
                        Helper.Wait();
                        break;

                    case 7:
                        SerializeBIN.LoadUsers();
                        Helper.Wait();
                        break;

                    case 8:
                        SerializeXML.SaveRoomData();
                        SerializeXML.SaveReservationData();
                        Helper.Wait();
                        break;

                    case 9:
                        SerializeXML.LoadRoomData();
                        SerializeXML.LoadReservationData();
                        Helper.Wait();
                        break;

                    case 0:
                        
                        end = true;
                        break;

                    default:
                        break;

                }

            } while (!end);
        }

        public static void SetupMenu()
        {
            Console.BackgroundColor = ConsoleColor.Gray; //kolor tła konsoli
            Console.ForegroundColor = ConsoleColor.Black; //kolor pierwszego planu konsoli

            Console.Clear();
            Console.WriteLine("System rezerwacji HotelDrCsharp - ustawienia\n");
            Console.WriteLine("Wybierz opcje: ");
            Console.WriteLine("1 - Dodaj użytkownika");
            Console.WriteLine("2 - Lista użytkowników");
            Console.WriteLine("----------------------");
            Console.WriteLine("6 - Zapisz użytkowników");
            Console.WriteLine("7 - Wczytaj użytkowników");
            Console.WriteLine("----------------------");
            Console.WriteLine("8 - Zapis danych");
            Console.WriteLine("9 - Wczytanie danych");
            Console.WriteLine("0 - Wyjście");
        }

        public static bool UserExist(string userlogin)
        {
            return Program.users.Any(item => item.Login == userlogin);
        }
        
        private static void AddUser()
        {
            if (Program.currentuser.IsAdminn())
            {
                Console.WriteLine("Utwórz nowego użytkownika:");

                string login, password;

                do
                {
                    Console.WriteLine("Podaj login:");
                    login = Console.ReadLine();

                    if (UserExist(login))
                    {
                        Console.WriteLine("Podany użytkownik istnieje");

                    }

                } while (UserExist(login));

                password = Helper.EnterPassword();

                Employee user = new Employee(login, password, "", "", "", "");

                Program.users.Add(user);

            }
            else
            {
                Console.WriteLine("Nie masz uprawnień");
                Helper.Wait();
            }
        }

    }
}
