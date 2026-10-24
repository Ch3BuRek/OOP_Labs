using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2_oop.Shapes
{
    public class Dot : Shape
    {
        public override void Show(Graphics g)
        {
            g.FillEllipse(Brushes.Black, p1.X - 2, p1.Y - 2, 4, 4);
        }
        public override void ShowTrace(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, p1.X - 2, p1.Y - 2, 4, 4);
        }
    }
    
}
