using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingApplication
{
    public partial class Form1 : Form
    {
        private Point startPoint;
        private Pen drawingPen;

        public Form1()
        {
            InitializeComponent();
            InitializeDrawing();
        }

        private void InitializeDrawing()
        {
            // Initialize drawing setup
            drawingPen = new Pen(Color.Black, 2);
            startPoint = new Point();

            // Subscribe to mouse events
            MouseDown += DrawingForm_MouseDown;
            MouseMove += DrawingForm_MouseMove;
            MouseUp += DrawingForm_MouseUp;

            this.Resize += new EventHandler(DrawingForm_Resize);
            CenterControls();
        }

        private void DrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
            }
        }

        private void DrawingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = CreateGraphics())
                {
                    g.DrawLine(drawingPen, startPoint, e.Location);
                    startPoint = e.Location;
                }
            }
        }

        private void DrawingForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = Point.Empty;
            }
        }

        private void DrawingForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            // This form doesn't have specific controls to center, but you can add any UI elements and center them similarly
        }
    }
}
