using System;
namespace Shape
{
    public class Rectangle : Shapes
    {
        private double _sideA;
        private double _sideB;
        private string _shapetype;

        public Rectangle(double SideA, double SideB, string ShapeType = "Rectangle")
        {
            this._sideA = SideA;
            this._sideB = SideB;
            this._shapetype = ShapeType;

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
            return _shapetype;
        }

        public override string ToString()
        {
            return $"Type: {_shapetype}\t Area: {Area()}\t Circuit: {Circuit()}";
        }
    }
}
