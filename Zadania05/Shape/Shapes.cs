using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Shape
{
    public abstract class Shapes : IComparable<Shapes>
    {
        private string _typek;
        public abstract double Area();
        public abstract double Circuit();

        public string Typek { get => _typek; set => _typek = value; }

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