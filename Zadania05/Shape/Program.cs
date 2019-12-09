using System;
using System.Collections.Generic;

namespace Shape
{
    class Program
    {
        

        static void Main(string[] args)
        {
            PrintResults printResults;

            printResults = DisplayShapes;
            printResults += Helper.Wait;
            
 
            bool end =false;

            do
            {
                Helper.DisplayMenu();
                switch (Helper.InputInt("\nChoose an option: "))
                {
                    case 1:
                        SampleShapes();
                        printResults();
                        break;
                    case 2:
                        list.Sort();
                        printResults();
                        break;
                    case 3:
                        list.Sort(new CompareByCircut());
                        printResults();
                        break;
                    case 4:
                        SearchByType();
                        Helper.Wait();
                        break;
                    case 5:
                        printResults();
                        break;
                    case 0:
                        Console.WriteLine("\nEnd of program");
                        end = true;
                        break;
                    default:
                        break;
                }
            } while (!end);

        }

        public static List<Shapes> list = new List<Shapes>();
        public delegate void PrintResults();

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
            
            Console.WriteLine("\nShapes Generated\n");
        }

        public static void SearchByType() {
            Console.WriteLine("Available shapes: Circle, Triangle, Rectangle, Square");
 
            Console.WriteLine("Enter shape name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            list.FindAll(s => s.GetTypeName() == name).ForEach(Console.WriteLine);
            Console.WriteLine();
        }

        public static void DisplayShapes()
        {
            foreach (var shape in list)
            {
                Console.WriteLine(shape);
            }
        }

    }
}