using System.Collections.Generic;
using CollaborativeWhiteboard.Models;

namespace CollaborativeWhiteboard.Services
{
    public class DrawingService
    {
        private List<DrawingElement> drawingElements;

        public DrawingService()
        {
            drawingElements = new List<DrawingElement>();
        }

        public void AddDrawingElement(DrawingElement element)
        {
            drawingElements.Add(element);
            // Notify clients about the new drawing element
        }

        public void ClearDrawing()
        {
            drawingElements.Clear();
            // Notify clients to clear their whiteboards
        }

        public List<DrawingElement> GetDrawingElements()
        {
            return drawingElements;
        }

        public void UpdateDrawingElement(DrawingElement element)
        {
            // Update the specific drawing element and notify clients
        }
    }
}