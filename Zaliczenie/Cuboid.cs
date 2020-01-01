using System;
namespace Zaliczenie
{
    public class Cuboid : Solid
    {

        private string _solidname;
        private int _edgeA;
        private int _edgeB;
        private int _edgeC;


        public Cuboid(int EdgeA, int EdgeB, int EdgeC, string SolidName = "Cuboid")
        {
            this._solidname = SolidName;
            this._edgeA = EdgeA;
            this._edgeB = EdgeB;
            this._edgeC = EdgeC;
        }

        public override double TotalSurface()
        {

            //{S}=2(ab+bc+ac)
            return 2 * ((_edgeA * _edgeB) + (_edgeB *_edgeC) + (_edgeA * _edgeC));

        }

        public override double Volume()
        {

            //V=abc
            return _edgeA * _edgeB * _edgeC;

        }

        public override string GetName()
        {
            return _solidname;
        }

        public override string ToString()
        {
            return $"Type: {_solidname}\t Volume: {Volume()}\t\t TotalSurface: {TotalSurface()}";
        }

    }
}
