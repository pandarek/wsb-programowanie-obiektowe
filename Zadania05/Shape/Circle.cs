using System;
using System.Diagnostics.CodeAnalysis;

namespace Shape
{
    public class Circle : Shapes
    {

        private string _typek;
        private int _radius;

        public Circle(int Radius, string Typek = "Circle")
        {
            this._typek = Typek;
            this._radius = Radius;

        }

        public string Typek { get; set; }
        public int Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
           
        }
        public override double Circuit()
        {
            return 2 * Math.PI *_radius;
        }

        public override string ToString()
        {
            return $"Typ: {_typek}, Pole: {Area()}, obwód: {Circuit()}";
        }
    }
}