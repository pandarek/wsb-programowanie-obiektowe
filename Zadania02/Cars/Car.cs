using System;
using System.Xml.Serialization;

namespace Cars
{
    [Serializable]
    public class Car
    {
        private string _brand;
        private string _model;
        private Engine _engine;
        private int _todal_distance;

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

        public Car() {
            Console.WriteLine("Auto domyślne");
        }

        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }
        public Engine Engine { get => _engine; set => _engine = value; }

        [XmlIgnore]
        public double Fuel
        {
            get => _engine.Fuel;
            set => _engine.Fuel = value;
        }

        public int Total_distance
        {
            get => _todal_distance;
            set => _todal_distance = value;
        }


        public string CarInfo()
        {
            try
            {
                return $"\nMarka:\t\t\t{_brand}\nModel:\t\t\t{_model}\nPojemność:\t\t{_engine.Enginecapacity} cm³\nZbiornik paliwa:\t{_engine.Tankcapacity}\nIlość paliwa:\t\t{_engine.Fuel}\nCałkowity przebieg:\t\t{_todal_distance}\n";

            }
            catch (Exception ex)
            {
               return ex.Message;
            }

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

                Helper.distanceAnim(distance);

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
            _todal_distance += distance;
            

        }
        public void refueling()
        {
            double tank_station;
            bool succes = false;

            while (!succes)
            {

                tank_station = Helper.PodajLiczbeDouble("Ile zatankować: ");

                if ((_engine.Fuel + tank_station) > _engine.Tankcapacity)
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