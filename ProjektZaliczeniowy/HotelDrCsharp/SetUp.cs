using System;
using System.Linq;

namespace HotelDrCsharp
{
    public class Setup
    {

        public static void Run()
        {
            SerializeXML HotelSerializer = new SerializeXML();
            SerializeBIN serializeBIN = new SerializeBIN();
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
                        break;

                    case 2:
                        Program.users.ForEach(Console.WriteLine);
                        Helper.Wait();
                        break;

                    case 6:
                        serializeBIN.savebin(Program.users);
                        Helper.Wait();
                        break;

                    case 7:
                        serializeBIN.loadbin();
                        Helper.Wait();
                        break;

                    case 8:
                        HotelSerializer.savexml(Hotel.hotellist);
                        Helper.Wait();
                        break;

                    case 9:
                        HotelSerializer.deserialize();
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
        public static bool PasswordTheSame(string password1, string password2)
        {
            if (password1 == password2) return true;
            return false;

        }
        private static void AddUser()
        {
            if (Program.currentuser.IsAdminn())
            {
                Console.WriteLine("Utwórz nowego użytkownika:");

                string login, password, password2;

                do
                {
                    Console.WriteLine("Podaj login:");
                    login = Console.ReadLine();

                    if (UserExist(login))
                    {
                        Console.WriteLine("Podany użytkownik istnieje");

                    }

                } while (UserExist(login));

                do
                {
                    Console.WriteLine("Podaj haslo:");
                    password = Helper.GetConsolePassword();

                    Console.WriteLine("Powtórz haslo:");
                    password2 = Helper.GetConsolePassword();

                    if (!PasswordTheSame(password, password2))
                    {
                        Console.WriteLine("Hasła się różnią");
                    }

                } while (!PasswordTheSame(password, password2));

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
