using System;

namespace ContactManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ZapisXML zapis = new ZapisXML();
            Kontakty kontakty = new Kontakty();
            
            Console.WriteLine("\n- Książka Adresowa -\n");

            bool wczytac = Dodatki.CzyKontynuowac("Czy wczytać dane? [t/n]");

            if (wczytac)
            {
                zapis.wczytaj(kontakty);
            }

            bool wyjscie = false;

            while (!wyjscie)
            {
                Console.Clear();
                
                Console.WriteLine("- Książka Adresowa Menu -\n");
                Console.WriteLine($"Kontaktów w bazie: {kontakty.KontaktyLista.Count}\n");
                Dodatki.Menu();

                switch (Dodatki.PodajLiczbe("Wybierz: "))
                {
                    case 1:
                        Console.WriteLine();
                        kontakty.DodajKontakt();
                        Dodatki.Czekaj();
                        break;
                    case 2:
                        Console.WriteLine();
                        kontakty.PokazKontakty();
                        Dodatki.Czekaj();
                        break;
                    case 3:
                        kontakty.PokazKontakty();
                        kontakty.PokazDaneOsoby();
                        Dodatki.Czekaj();
                        break;
                    case 4:
                        kontakty.SostowanieNazwisko();
                        kontakty.PokazKontakty();
                        Dodatki.Czekaj();
                        break;
                    case 5:
                        zapis.zapisz(kontakty.KontaktyLista);
                        Dodatki.Czekaj();
                        break;
                    case 6:
                        zapis.wczytaj(kontakty);
                        Dodatki.Czekaj();
                        break;
                    case 9:
                        wyjscie = true;
                        break;
                }

            }
        }
    }
}
