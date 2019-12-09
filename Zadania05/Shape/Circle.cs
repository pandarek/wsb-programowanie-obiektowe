using System;

namespace Shape
{
    public class Circle : Shapes
    {

        private string _shapetype;
        private int _radius;

        public Circle(int Radius, string ShapeType = "Circle")
        {
            this._shapetype = ShapeType;
            this._radius = Radius;

        }

        public int Radius { get; set; }

        public override double Area()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
        }

        public override double Circuit()
        {
            return Math.Round((2 * Math.PI *_radius),2);
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