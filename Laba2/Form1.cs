using Laba2_oop.Shapes;

namespace Laba2_oop
{
    public partial class Form1 : Form
    {
        private const int N = 117;
        private Shape[] pcshape = new Shape[N];
        private int count = 0;

        private Shape current;
        private bool isDrawing = false;
        private string selectedType = "Крапка";


        public Form1()
        {
            InitializeComponent();
            UpdateTitle();
            panelCanvas.MouseDown += panelCanvas_MouseDown;
            panelCanvas.MouseMove += panelCanvas_MouseMove;
            panelCanvas.MouseUp += panelCanvas_MouseUp;
            panelCanvas.Paint += panelCanvas_Paint;
        }

        private void menuShape_Click(object sender, EventArgs e)
        {
            selectedType = ((ToolStripMenuItem)sender).Text;
            UpdateTitle();
        }
        private void UpdateTitle()
        {
            Text = "Lab2 - " + selectedType;
        }

        private Shape CreateShape()
        {
            switch (selectedType)
            {
                case "Крапка": return new Dot();
                case "Лінія": return new Line();
                case "Прямокутник": return new Rect();
                case "Еліпс": return new Ellipse();
                default: return null;
            }
        }



        private Point downPoint;

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (count >= N) { MessageBox.Show("масив заповнений"); return; }
            current = CreateShape();
            if (current == null) return;
            downPoint = e.Location;
            current.Set(e.Location, e.Location);
            isDrawing = true;
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            current.Set(downPoint, e.Location);
            panelCanvas.Invalidate();
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            isDrawing = false;
            current.Set(downPoint, e.Location);
            pcshape[count++] = current;
            current = null;
            panelCanvas.Invalidate();
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < count; i++)
                pcshape[i].Show(e.Graphics);

            if (isDrawing && current != null)
                using (Pen trace = new Pen(Color.Red, 1))
                    current.ShowTrace(e.Graphics, trace);
        }

        private void DotShape_Click(object sender, EventArgs e) { menuShape_Click(sender, e); }
        private void LineShape_Click(object sender, EventArgs e) { menuShape_Click(sender, e); }
        private void RectangleShape_Click(object sender, EventArgs e) { menuShape_Click(sender, e); }
        private void ElipseShape_Click(object sender, EventArgs e) { menuShape_Click(sender, e); }
        private void MenuShape_Click(object sender, EventArgs e) { }
    }
}
