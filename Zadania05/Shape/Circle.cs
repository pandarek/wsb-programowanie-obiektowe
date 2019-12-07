using System;
namespace Shape
{
    public class Circle : Shapes
    {

        public string _typek;
        public int _radius;

        public Circle(int Radius, string Typek = "Circle")
        {
            this._typek = Typek;
            this._radius = Radius;

        }

        public string Typek { get; set; }
        public int Radius { get; set; }

        public override double Area()
        {
            return 3.14 * (_radius * _radius);
           
        }
        public override double Circuit()
        {
            return 2 * 3.14 * _radius;
        }

        public override string ToString()
        {
            return $"Typ: {_typek}, Pole: {Area()}, obwód: {Circuit()}";
        }
    }
}