using System;
using System.Collections.Generic;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Helper.DisplayMenu();
            
            bool end =false;
            do
            {

                switch (Helper.GetInt("Wybierz opcję: "))
                {
                    case 1:
                        SampleShapes();
                        break;
                    case 2:
                        list.Sort();
                        break;

                    case 3:
                        list.Sort(new CompareByCircut());
                        break;
                    case 4:
                       //list.FindAll(s => s.Circuit >= 23).ForEach(Console.WriteLine);

                        break;
                    case 5:
                        foreach (var shape in list)
                        {
                            Console.WriteLine(shape);
                        }
       
                        break;
                    case 0:
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
