using System;
using System.Collections.Generic;

namespace Zaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintResults printResults;

            printResults = DisplaySolids;
            printResults += Helper.Wait;
              

                bool end = false;

            do
            {
                Helper.DisplayMenu();
                switch (Helper.InputInt("\nChoose an option: "))
                {
                    case 1:
                        SampleSolids();
                        printResults();
                        break;
                    case 2:
                        printResults();
                        break;
                    case 3:
                        list.Sort();
                        printResults();
                        break;
                    case 4:
                        list.Sort(new CompareBySurface());
                        printResults();
                        break;
                    case 5:
                        SearchByName();
                        Helper.Wait();
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

        public delegate void PrintResults();

        public static List<Solid> list = new List<Solid>();

        public static void SampleSolids()
        {
            Cylinder cylinder = new Cylinder(23, 12);
            Cuboid cuboid = new Cuboid(45, 45, 12);
            Cube cube = new Cube(56);

            list.Add(cylinder);
            list.Add(cuboid);
            list.Add(cube);

            Console.WriteLine("\nShapes Generated\n");
        }

        public static void DisplaySolids()
        {
            if (list.Count > 0)
            {
                foreach (var solid in list)
                {
                    Console.WriteLine(solid);
                }
            }
            else
            {
                Console.WriteLine("Data not found");
            }
        }

        public static void SearchByName()
        {
            Console.WriteLine("Available shapes: Cylinder, Cuboid, Cube");
            Console.WriteLine("Enter shape name: ");

            string name = Console.ReadLine();

            Console.WriteLine();
            //list.FindAll(s => s.GetName() == name).ForEach(Console.WriteLine);

            List<Solid> result;

            result = list.FindAll(s => s.GetName() == name);

            if (result.Count > 0 )
            {
                result.ForEach(Console.WriteLine);

            }
            else
            {
                Console.WriteLine("Data not found");
            }

            Console.WriteLine();
        }
    }
}
