using System;
namespace Zaliczenie
{
    public class Cube : Cuboid
    {

        private string _solidname;

        public Cube(int EdgeA, string SolidName = "Cube") : base(EdgeA, EdgeA, EdgeA, SolidName)
        {
            this._solidname = SolidName;
        }
    }
}