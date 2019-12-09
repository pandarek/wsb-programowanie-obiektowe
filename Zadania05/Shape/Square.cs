using System;
namespace Shape
{
    public class Square : Rectangle
    {

        private string _shapetype;

        public Square(double BokA, string ShapeType = "Square") : base (BokA, BokA, ShapeType) {
            this._shapetype = ShapeType;
        }

        public override string GetTypeName()
        {
            return _shapetype;
        }

    }
}