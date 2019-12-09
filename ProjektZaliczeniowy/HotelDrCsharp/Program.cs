using System;

namespace HotelDrCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            bool end = false;

            do
            {
                Helper.MainMenu();

                switch (Helper.InputInt("\nWybierz opcję"))
                {
                    case 1:
                        break;
                    default:
                        break;
                }

            } while (!end);
        }
    }
}