using System.Drawing;
using WhiteboardCommon;

namespace WhiteboardClient
{
    public static class Extensions
    {
        public static PointData ToPointData(this Point point)
        {
            return new PointData(point.X, point.Y);
        }

        public static Point ToPoint(this PointData pointData)
        {
            return new Point(pointData.X, pointData.Y);
        }

        public static ColorData ToColorData(this Color color)
        {
            return new ColorData(color.A, color.R, color.G, color.B);
        }

        public static Color ToColor(this ColorData colorData)
        {
            return Color.FromArgb(colorData.A, colorData.R, colorData.G, colorData.B);
        }

        public static SizeData ToSizeData(this Size size)
        {
            return new SizeData(size.Width, size.Height);
        }

        public static Size ToSize(this SizeData sizeData)
        {
            return new Size(sizeData.Width, sizeData.Height);
        }
    }
}