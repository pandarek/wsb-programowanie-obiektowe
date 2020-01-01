using System;
using System.Collections.Generic;

namespace Zaliczenie
{
    public abstract class Solid : IComparable<Solid>
    {

        public abstract double TotalSurface();
        public abstract double Volume();
        public abstract string GetName();

        public int CompareTo(Solid other)
        {
            //return ToString().CompareTo(other.ToString());
            return Volume().CompareTo(other.Volume());
        }
    }

    class CompareBySurface : IComparer<Solid>
    {
        public int Compare(Solid x, Solid y)
        {
            if (x == null || y == null) return 0;
            return x.TotalSurface().CompareTo(y.TotalSurface());
        }
    }
}