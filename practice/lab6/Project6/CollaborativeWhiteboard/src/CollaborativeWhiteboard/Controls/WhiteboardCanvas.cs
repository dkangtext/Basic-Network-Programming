using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CollaborativeWhiteboard.Models;

namespace CollaborativeWhiteboard.Controls
{
    public class WhiteboardCanvas : Control
    {
        private List<DrawingElement> drawingElements;
        private bool isDrawing;
        private Point lastPoint;

        public WhiteboardCanvas()
        {
            this.drawingElements = new List<DrawingElement>();
            this.DoubleBuffered = true;
            this.MouseDown += WhiteboardCanvas_MouseDown;
            this.MouseMove += WhiteboardCanvas_MouseMove;
            this.MouseUp += WhiteboardCanvas_MouseUp;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var element in drawingElements)
            {
                using (var brush = new SolidBrush(element.Color))
                {
                    e.Graphics.FillEllipse(brush, element.X, element.Y, element.Size, element.Size);
                }
            }
        }

        private void WhiteboardCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }

        private void WhiteboardCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                var currentPoint = e.Location;
                var element = new DrawingElement
                {
                    X = currentPoint.X,
                    Y = currentPoint.Y,
                    Color = Color.Black,
                    Size = 5
                };
                drawingElements.Add(element);
                Invalidate();
                // Here you would also send the drawing update to other clients
            }
        }

        private void WhiteboardCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }

        public void Clear()
        {
            drawingElements.Clear();
            Invalidate();
        }

        public void SaveImage(string filePath)
        {
            using (var bitmap = new Bitmap(Width, Height))
            {
                DrawToBitmap(bitmap, new Rectangle(0, 0, Width, Height));
                bitmap.Save(filePath);
            }
        }
    }
}