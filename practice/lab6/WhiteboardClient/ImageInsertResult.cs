using System.Drawing;
using System.Text.Json.Serialization;

namespace WhiteboardClient
{
    public class ImageInsertResult
    {
        [JsonIgnore]
        public Point Position { get; set; }

        [JsonIgnore]
        public Size Size { get; set; }

        public ImageInsertResult()
        {
        }

        public ImageInsertResult(Point position, Size size)
        {
            Position = position;
            Size = size;
        }
    }
}