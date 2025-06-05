using System.Collections.Generic;

namespace CollaborativeWhiteboard.Models
{
    public class WhiteboardState
    {
        public List<DrawingElement> DrawingElements { get; set; }
        public List<User> ConnectedUsers { get; set; }

        public WhiteboardState()
        {
            DrawingElements = new List<DrawingElement>();
            ConnectedUsers = new List<User>();
        }

        public void AddDrawingElement(DrawingElement element)
        {
            DrawingElements.Add(element);
        }

        public void RemoveDrawingElement(DrawingElement element)
        {
            DrawingElements.Remove(element);
        }

        public void AddUser(User user)
        {
            ConnectedUsers.Add(user);
        }

        public void RemoveUser(User user)
        {
            ConnectedUsers.Remove(user);
        }
    }
}