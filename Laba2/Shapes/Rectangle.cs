using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2_oop.Shapes
{
    public class Rect : Shape
    {
        private Rectangle GetRect()
        {
            Point P1 = new Point(2 * p1.X - p2.X, 2 * p1.Y - p2.Y);
            return MakeRect(P1, p2);
        }

        public override void Show(Graphics g)
        {
            Rectangle r = GetRect();
            g.FillRectangle(Brushes.Gray, r);
            using (Pen pen = new Pen(Color.Black, 2))
                g.DrawRectangle(pen, r);
        }

        public override void ShowTrace(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, GetRect());
        }
    }
}
