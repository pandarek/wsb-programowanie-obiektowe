using System;
using System.Collections.Generic;

namespace Shape
{
    public abstract class Shapes : IComparable<Shapes>
    {
        public abstract double TotalSurface();
        public abstract double Volume();
        public abstract string GetName();


        public int CompareTo(Shapes other)
        {
            return ToString().CompareTo(other.ToString());
        }

    }

    class CompareByCircut : IComparer<Shapes>
    {
        public int Compare(Shapes x, Shapes y)
        {
            if (x == null || y == null) return 0;
            return x.Circuit().CompareTo(y.Circuit());
        }
    }
}
