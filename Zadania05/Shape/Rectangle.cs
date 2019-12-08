using System;
namespace Shape
{
    public class Rectangle : Shapes
    {
        private double _sideA;
        private double _sideB;
        private string _typek;

        public Rectangle(double SideA, double SideB, string Typek = "Rectangle")
        {
            this._sideA = SideA;
            this._sideB = SideB;
            this._typek = Typek;

        }

        public override double Area()
        {
            return Math.Round(_sideA * _sideB, 2);
        }

        public override double Circuit()
        {
            return Math.Round((_sideA * 2) + (_sideB * 2), 2);
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