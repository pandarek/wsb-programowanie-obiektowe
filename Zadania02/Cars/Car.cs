using System;
using System.Threading;
namespace Cars
{
    public class Car
    {
        private string _brand;
        private string _model;
        private Engine _engine;

        public Car(string _brand, string _model, int _enginecapacity, double _fuel, int _tankcapacity)
        {
            this._brand = _brand;
            this._model = _model;
            this._engine = new Engine(_enginecapacity, _fuel, _tankcapacity);

        }

        public Car(string _brand, string _model, int _enginecapacity, double _fuel)
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
        public double Fuel
        {
            get => (int)_engine.Fuel;
            set => _engine.Fuel = value;
        }


        public string CarInfo()
        {

            return $"\nMarka:\t\t\t{_brand}\nModel:\t\t\t{_model}\nPojemność:\t\t{_engine.Enginecapacity} cm³\nZbiornik paliwa:\t{_engine.Tankcapacity}\nIlość paliwa:\t\t{_engine.Fuel}\n";
        }


        public static int distance;

        public void go(int distance)
        {
            if (_engine.Fuel < 8)
            {
                Console.WriteLine("UWAGA: Masz mniej niż 8L paliwa...");
            }
            Console.WriteLine($"\nIlość paliwa na starcie: {_engine.Fuel}\n");
            Console.WriteLine("Jadę...");

            _engine.work(distance);

            Thread.Sleep(distance * 100);

            if (_engine.Fuel <= 0)
            {
                Console.WriteLine("Koniec Paliwa...");
                _engine.Fuel = 0;
            }
            else
            {
                Console.WriteLine($"\nIlość paliwa na mecie: {_engine.Fuel}\n");
                Console.WriteLine("Jestem");
                Console.WriteLine();
            }


        }
        public void tankuj()
        {
            double tank_station;
            bool succes = false;

            while (!succes)
            {
                               
                tank_station = Helper.PodajLiczbeDouble("Ile zatankować: ");

                if ((_engine.Fuel + tank_station) >= _engine.Tankcapacity)
                {
                    Console.WriteLine($"Maksymalnie możesz zatankować {_engine.Tankcapacity - _engine.Fuel}");
                }
                else
                {
                    _engine.Fuel += tank_station;
                    succes = true;
                }
            }
            
        }

    }
}