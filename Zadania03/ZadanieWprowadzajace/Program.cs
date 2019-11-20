using System;

namespace ZadanieWprowadzajace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Osoba osoba = new Osoba("Darek", "Krzysztofiak");
            Osoba student1 = new Student(100,"Adam","Eret");
            Student student2 = new Student(200,"Ola","Nowak");

            Osoba[] osoby = new Osoba[3];

            osoby[0] = osoba;
            osoby[1] = student1;
            osoby[2] = student2;

            foreach (var item in osoby)
            {
                Console.WriteLine(item.ToString());

            }
        }
    }
}
