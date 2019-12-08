using System;
namespace Shape
{
    public class Triangle : Shapes
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private string _typek;

        public Triangle(double SideA, double SideB, double SideC, string Typek = "Triangle")
        {
            this._sideA = SideA;
            this._sideB = SideB;
            this._sideC = SideC;
            this._typek = Typek;
        }

        public new string Typek { get => _typek; set => _typek = value; }

        public override double Area()
        {
            double p = (_sideA + _sideB + _sideC)/2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        public override double Circuit()
        {
            return _sideA + _sideB + _sideC;
        }
        public override string ToString()
        {
            return $"Typ: {_typek}, Pole: {Area()}, obwód: {Circuit()}";
        }
    }
}