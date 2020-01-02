using System;
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
                AdminMenu();
                Console.WriteLine();

                switch (Helper.InputInt("\nWybierz opcję: "))
                {
                    case 1:
                        if (Program.currentuser.IsAdminn())
                        {
                            Console.WriteLine("Utwórz nowego użytkownika:");

                            Console.WriteLine("Podaj login:");
                            string login = Console.ReadLine();

                            Console.WriteLine("Podaj haslo:");
                            string password = Helper.GetConsolePassword();

                            Employee user = new Employee(login, password, "", "", "", "");

                            Program.users.Add(user);

                            //using (StreamWriter sw = new StreamWriter("employees.txt"))
                            //{
                            //    sw.WriteLine(username);
                            //    sw.WriteLine(password);
                            //    sw.Close();
                            //}
                        }
                        else
                        {
                            Console.WriteLine("Nie masz uprawnień");
                            Helper.Wait();
                        }

                        break;
                    case 2:
                        Program.users.ForEach(Console.WriteLine);
                        Helper.Wait();

                        break;
                    case 3:

                        break;

                    case 0:
                        end = true;
                        break;
                    default:
                        break;

                }

            } while (!end);
        }

        public static void AdminMenu()
        {
            Console.BackgroundColor = ConsoleColor.Gray; //kolor tła konsoli
            Console.ForegroundColor = ConsoleColor.Black; //kolor pierwszego planu konsoli

            Console.Clear();
            Console.WriteLine("System rezerwacji HotelDrCsharp\n");
            Console.WriteLine("Wybierz opcje: ");
            Console.WriteLine("1 - Dodaj użytkownika");
            Console.WriteLine("2 - Lista użytkowników");
            Console.WriteLine("0 - Wyjście");
        }

    }
}
