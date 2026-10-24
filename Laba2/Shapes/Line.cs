using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2_oop.Shapes
{
    public class Line : Shape
    {
        public override void Show(Graphics g)
        {
            using (Pen pen = new Pen(Color.Black, 2))
                g.DrawLine(pen, p1, p2);
        }

        public override void ShowTrace(Graphics g, Pen pen)
        {
            g.DrawLine(pen, p1, p2);
        }
    }
}
