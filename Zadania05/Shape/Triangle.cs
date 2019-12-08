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

        public override double Area()
        {
            double p = (_sideA + _sideB + _sideC)/2;
            return Math.Round(Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC)), 2);
        }

        public override double Circuit()
        {
            return Math.Round(_sideA + _sideB + _sideC, 2);
        }

        public override string GetTypeName()
        {
            return _typek;
        }

        public override string ToString()
        {
            return $"Typ: {_typek}, Pole: {Area()}, obwód: {Circuit()}";
        }
    }
}