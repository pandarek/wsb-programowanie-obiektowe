using System;
namespace Zaliczenie
{
    public class Cylinder : Solid
    {

        private string _solidname;
        private int _radius;
        private int _edgelength;


        public Cylinder(int Radius, int EdgeLenght, string SolidName = "Cylinder")
        {
            this._solidname = SolidName;
            this._radius = Radius;
            this._edgelength = EdgeLenght;

        }

        public override double TotalSurface() {

            //2pi r (r+h)
            return Math.Round((2 * (Math.PI * _radius)) * (_radius + _edgelength), 2 );
        }

        public override double Volume() {


            //pi r^2  h
            return Math.Round((Math.PI * Math.Pow(_radius, 2)) * _edgelength, 2);

        }

        public override string GetName()
        {
            return _solidname;
        }

        public override string ToString()
        {
            return $"Type: {_solidname}\t Volume: {Volume()}\t TotalSurface: {TotalSurface()}";
        }

    }
}
