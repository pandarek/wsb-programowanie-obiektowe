using System;
namespace Cars
{
    public class Engine
    {
        private int _enginecapacity;
        private double _fuel;
        private int _tankcapacity;
        private const int _defaultcapacity = 55;

        public Engine(int _enginecapacity, int _fuel)
        {
            this._enginecapacity = _enginecapacity;
            this._fuel = _fuel;
            this._tankcapacity = _defaultcapacity;

        }
        public Engine(int _enginecapacity, int _fuel, int _tankcapacity) : this(_enginecapacity, _fuel)
        {

            this._tankcapacity = _tankcapacity;

        }

        public int Enginecapacity
        {
            get
            {
                return _enginecapacity;
            }

            set
            {
                _enginecapacity = value;
            }
        }

        public double Fuel
        {
            get
            {
                return _fuel;
            }

            set
            {
                _fuel = value;
            }
        }
        public int Tankcapacity
        {
            get
            {
                return _tankcapacity;
            }

            set
            {
                _tankcapacity = value;
            }
        }

        public void work(int distance)
        {
            _fuel -= ((((double)_enginecapacity / 1000) * 4) / 100) * distance;


        }

    }
}
