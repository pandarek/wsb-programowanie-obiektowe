using System;
namespace Shape
{
    public class Square : Rectangle
    {

        private string _typek;

        public Square(double BokA, string Typek = "Square") : base (BokA, BokA, Typek) {
            this._typek = Typek;
        }

        public override string GetTypeName()
        {
            return _typek;
        }

    }
}