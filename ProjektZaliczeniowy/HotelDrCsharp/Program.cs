using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HotelDrCsharp
{
    class Program
    {
        //TODO sprawdzić i poprawić kod, szczególlnie pętle
        //TODO właściwa serializacja zapis użytkowników i haseł
        //TODO nadanie tylko adminowi uprawnien do nadawania haseł

        //--------------------------------------------------------------------
        public static List<string> login = new List<string>();
        public static List<string> password = new List<string>();
        public static bool startup = true;
        public static bool logged = false;
        //---------------------------------------------------------------------
        static void Main(string[] args)
        //---------------------------------------------------------------------
        {
            ProgramStart();
        }
        
        private static void ProgramStart()
        {  
     
                while (startup == true)
                {
                    Console.BackgroundColor = ConsoleColor.Gray; //kolor tła konsoli
                    Console.ForegroundColor = ConsoleColor.Black; //kolor pierwszego planu konsoli

                    Console.Clear();
                    Console.WriteLine("\nSystem rezerwacji HotelDrCsharp\n");
                    Console.WriteLine("Wybierz literę: ");
                    
                    Console.WriteLine("L - Logowanie");
                    Console.WriteLine("R - Rejestracja przez Administratora");

                    ConsoleKeyInfo klawisz = Console.ReadKey();

                    switch (klawisz.Key)
                    {
                            case ConsoleKey.L:
                            Console.Clear();
                            Console.WriteLine("Podaj login:");
                            string username = Console.ReadLine();

                            if (username == ("admin"))
                            {
                                Console.Clear();
                            }
                            //else
                            //{
                            //    Console.WriteLine("Nieprawidlowy uzytkownik!");
                            //}

                            Console.WriteLine("Podaj haslo:");
                            string password = Console.ReadLine();

                            
                             Run(); ///działa wychodzi z pętli i przechodzi do właściwego programu :)
                            
                             break;


                            case ConsoleKey.R:
                            Console.Clear();
                            Console.WriteLine("Utwórz nowego użytkownika:");

                            Console.WriteLine("Podaj login:");
                            username = Console.ReadLine();
                            Console.WriteLine("Podaj haslo:");
                            password = Console.ReadLine();

                            using (StreamWriter sw = new StreamWriter("employees.txt"))
                            {
                                sw.WriteLine(username);
                                sw.WriteLine(password);
                                sw.Close();
                            }           

                            //Console.Read();

                            break;
                   
                    }

                }

        }
        public static void Run()
        {

            if (logged == true)
            {
                Helper.MainMenu();
            }
            


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