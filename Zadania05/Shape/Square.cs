using System;
namespace Shape
{
    public class Square : Rectangle
    {
        //private double _bokA;
        //private double _bokB;
        //private string _typek;

        //public Square(double BokA, double BokB, string Typek = "Square" ) : base (BokA, BokB, Typek)
        //{
        //    this._bokA = BokA;
        //    this._bokB = BokB;
        //    this._typek = Typek;
        //}
        public Square(double BokA) : base (BokA, BokA, Typek: "Sqare") { }

        public new string Typek { get => Typek; set => Typek = value; }

        //public override double Area()
        //{
        //    return _bokA * _bokB;
        //}

        //public override double Circuit()
        //{
        //    return (_bokA + _bokB) * 2;
        //}
        //public override string ToString()
        //{
        //    return $"Typ: {_typek}, Pole: {Area()}, obwód: {Circuit()}";
        //}
    }
}