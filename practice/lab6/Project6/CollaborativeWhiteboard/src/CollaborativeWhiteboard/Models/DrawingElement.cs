using System;
using System.Drawing;

namespace CollaborativeWhiteboard.Models
{
    public class DrawingElement
    {
        public Point Position { get; set; }
        public Color DrawColor { get; set; }
        public float Thickness { get; set; }
        public string Type { get; set; } // e.g., "line", "circle", etc.

        // X and Y properties that the code is trying to access
        public int X { get { return Position.X; } }
        public int Y { get { return Position.Y; } }

        public DrawingElement(Point position, Color color, float thickness, string type)
        {
            Position = position;
            DrawColor = color;
            Thickness = thickness;
            Type = type;
        }
    }
}