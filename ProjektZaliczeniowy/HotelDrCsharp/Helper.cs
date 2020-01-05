using System;
using System.Security;
using System.Text;

namespace HotelDrCsharp
{
    public class Helper
    {
        public static void MainMenu()
        {

            Console.Title = "DrCsharp - System Rezerwacji Hotelowej"; //nazwa konsoli
            Console.BackgroundColor = ConsoleColor.Black; //kolor tła konsoli
            Console.ForegroundColor = ConsoleColor.Green; //kolor pierwszego planu konsoli

            Console.Clear();
            Console.WriteLine("System rezerwacji HotelDrCsharp\n");
            Console.WriteLine("Login: " + Program.currentuser.Login);
            Console.WriteLine("Czy admin: " + Program.currentuser.IsAdminn());
            Console.WriteLine("Zmina hasła: " + Program.currentuser.ChangePassword);
            Console.WriteLine("Wybierz opcje: ");


            Console.WriteLine("\nRezerwacje -----------------------------");
            Console.WriteLine("1 - Dodaj rezerwacje");
            Console.WriteLine("2 - Usun rezerwacje");
            Console.WriteLine("3 - Wyświetl rezerwacje");
            Console.WriteLine("\nPokoje ---------------------------------");
            Console.WriteLine("4 - Wyswietl wszystkie pokoje");
            Console.WriteLine("5 - Wyswietl wolne pokoje");
            Console.WriteLine("6 - Wyswietl zarezerwowane pokoje");
            Console.WriteLine("\nInne -------------------------------------");
            Console.WriteLine("9 - Ustawienia");
            Console.WriteLine("0 - Zamknij system");
        }

        public static int InputInt(string msg)
        {

            bool udalosoe = false;
            int result = 0;

            while ((!udalosoe) || (result < 0))
            {
                Console.Write(msg);
                udalosoe = int.TryParse(Console.ReadLine(), out result);

            }
            return result;

        }

        public static int InputIntRange(string msg, int from, int to)
        {

            bool udalosoe;
            int result;

            do
            {
                Console.Write(msg);
                udalosoe = int.TryParse(Console.ReadLine(), out result);

            } while ((!udalosoe) || (result < from) || (result > to));

            return result;
        }

        public static void Wait()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }


        public static string GetConsolePassword()
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (cki.Key == ConsoleKey.Backspace)
                {
                    if (sb.Length > 0)
                    {
                        Console.Write("\b\0\b");
                        sb.Length--;
                    }

                    continue;
                }

                Console.Write('*');
                sb.Append(cki.KeyChar);
            }

            return sb.ToString();
        }

        public static bool PasswordTheSame(string password1, string password2)
        {
            if (password1 == password2) return true;
            return false;

        }

        //wprowadzanie hasla ze sprawdzaniem
        public static string EnterPassword()
        {
            string password, password2;
            do
            {
                do
                {
                    Console.WriteLine("Podaj haslo:");
                    password = Helper.GetConsolePassword();

                } while (String.IsNullOrEmpty(password)); 

                Console.WriteLine("Powtórz haslo:");
                password2 = Helper.GetConsolePassword();

                if (!PasswordTheSame(password, password2))
                {
                    Console.WriteLine("Hasła się różnią");
                }

            } while (!PasswordTheSame(password, password2));

            return password;
        }


        //rezerwacje
        public static Customer AddCustomer()
        {
            Console.WriteLine("------------------------------------------");
            Console.Write("Podaj imię:\t\t\t");
            var imie = Console.ReadLine();
            Console.Write("Podaj Nazwisko:\t\t\t");
            var nazwisko = Console.ReadLine();


            Customer customer = new Customer(imie, nazwisko);

            return customer;
        }

        public static DateTime AddStartDate()
        {
            DateTime startdate;
            DateTime ToDay = DateTime.Today.ToLocalTime();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Wprowadź datę przyjazdu format (RRRR-MM-DD)");

            string date;
            bool dataok;

            do
            {
                date = Console.ReadLine();
                dataok = DateTime.TryParseExact(date, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out startdate);

                if (!dataok) { Console.WriteLine("Bład daty: wprowadź ponownie"); }
                if (startdate < ToDay) { Console.WriteLine("Bład daty: data przeszła, wprowadź ponownie"); }

            } while (!dataok || (startdate < ToDay));

            return startdate;

        }

        public static DateTime AddEndDate(DateTime startdate)
        {

            DateTime enddate;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Wprowadź datę wyjazdu format (RRRR-MM-DD)");

            string date;
            bool dataok;

            do
            {
                date = Console.ReadLine();
                dataok = DateTime.TryParseExact(date, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out enddate);

                if (!dataok) { Console.WriteLine("Bład daty: wprowadź ponownie"); }
                if (startdate >= enddate) { Console.WriteLine("Błąd daty: Data wyjazdu nie móże być wcześniej niż data przyjazdu, wprowadź ponownie"); }

            } while (!dataok || startdate >= enddate);

            return enddate;
        }

    }
}