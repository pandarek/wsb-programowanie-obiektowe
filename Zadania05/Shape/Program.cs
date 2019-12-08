using System;
using System.Collections.Generic;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool end =false;

            do
            {
                Helper.DisplayMenu();
                switch (Helper.PodajLiczbe("Wybierz opcję: "))
                {
                    case 1:
                        SampleShapes();
                        Helper.Czekaj();
                        break;
                    case 2:
                        list.Sort();
                        Helper.Czekaj();
                        break;
                    case 3:
                        list.Sort(new CompareByCircut());
                        Helper.Czekaj();
                        break;
                    case 4:
                        list.FindAll(s => s.Typek == "Circle").ForEach(Console.WriteLine);
                        list.FindAll(s => s.Area() == 1849).ForEach(Console.WriteLine);
                        Helper.Czekaj();
                        break;
                    case 5:
                        foreach (var shape in list)
                        {
                            Console.WriteLine(shape);
                        }
                        Helper.Czekaj();
                        break;
                    case 0:
                        Console.WriteLine("\nKoniec programu");
                        end = true;
                        break;
                    default:
                        break;
                }
            } while (!end);

        }
        public static List<Shapes> list = new List<Shapes>();

        public static void SampleShapes()
        {
            Circle circle = new Circle(23);
            Triangle triangle = new Triangle(45, 45, 12);
            Rectangle rectangle = new Rectangle(56, 32);
            Square square = new Square(43);

            list.Add(square);
            list.Add(circle);
            list.Add(triangle);
            list.Add(rectangle);
            
            Console.WriteLine("\nKształty wygenerowane\n");

        }

    }
}
