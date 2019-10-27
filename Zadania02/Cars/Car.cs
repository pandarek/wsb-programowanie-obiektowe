using System;
using System.Threading;
namespace Cars
{
    public class Car
    {
        private string _brand;
        private string _model;
       

        private Engine _engine;

        public Car(string _brand, string _model, int _enginecapacity, int _fuel, int _tankcapacity)
        {
            this._brand = _brand;
            this._model = _model;
            this._engine = new Engine(_enginecapacity, _fuel, _tankcapacity);

        }

        public Car(string _brand, string _model, int _enginecapacity, int _fuel)
        {
            this._brand = _brand;
            this._model = _model;
            this._engine = new Engine(_enginecapacity, _fuel);

        }

    
        public Car(string _brand, string _model, Engine _engine)
        {
            this._brand = _brand;
            this._model = _model;
            this._engine = _engine;
        }

        public static int distance;
        
        public void go(int distance)
        {
            Console.WriteLine($"{_brand}, {_model},\nPojemniść silnika: {_engine.Enginecapacity} cm³");
            Console.WriteLine($"Pojemniść zbiornika paliwa: {_engine.Tankcapacity}");
            Console.WriteLine($"Ilość paliwa na starcie: {_engine.Fuel}");
            Console.WriteLine("Jadę...");
            _engine.work(distance);
            Thread.Sleep(distance*100);
            Console.WriteLine($"Ilość paliwa na mecie: {_engine.Fuel}");
            Console.WriteLine("Jestem");
            Console.WriteLine();

        }
        public void tankuj()
        {
            int tank_station;

            do
            {
                tank_station = Helper.PodajLiczbe("Ile zatankować: ");
                Console.WriteLine($"Maksymalnie możesz zatankować {_engine.Tankcapacity - _engine.Fuel}");

            } while (_engine.Fuel + tank_station >= _engine.Tankcapacity);

            _engine.Fuel += tank_station;
        }
            
    }
}