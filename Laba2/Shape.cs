using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2_oop
{
    public abstract class Shape
    {
        protected Point p1, p2;

        public void Set(Point a, Point b) { p1 = a; p2 = b; }

        public abstract void Show(Graphics g);

        public abstract void ShowTrace(Graphics g, Pen pen);

        protected static Rectangle MakeRect(Point a, Point b)
        {
            return new Rectangle(Math.Min(a.X, b.X), Math.Min(a.Y, b.Y),
                                 Math.Abs(a.X - b.X), Math.Abs(a.Y - b.Y));
        }

    }
}
