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

        public new string Typek { get => _typek; set => _typek = value; }

        public override double Area()
        {
            return _sideA * _sideB;
        }

        public override double Circuit()
        {
            return (_sideA * 2) + (_sideB * 2);
        }
        public override string ToString()
        {
            return $"Typ: {_typek}, Pole: {Area()}, obwód: {Circuit()}";
        }
    }
}