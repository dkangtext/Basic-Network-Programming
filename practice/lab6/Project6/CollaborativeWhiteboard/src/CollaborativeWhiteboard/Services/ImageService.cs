using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CollaborativeWhiteboard.Services
{
    public class ImageService
    {
        public void SaveWhiteboardAsImage(Bitmap whiteboardBitmap, string filePath, ImageFormat format)
        {
            if (whiteboardBitmap == null)
            {
                throw new ArgumentNullException(nameof(whiteboardBitmap), "The whiteboard bitmap cannot be null.");
            }

            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
            }

            try
            {
                whiteboardBitmap.Save(filePath, format);
            }
            catch (Exception ex)
            {
                throw new IOException("An error occurred while saving the image.", ex);
            }
        }
    }
}