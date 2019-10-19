using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Engine
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

        public void work(double _fuel, int distance, int _enginecapacity)
        {

            _fuel = (_enginecapacity * 4)/100;

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
    }
}
