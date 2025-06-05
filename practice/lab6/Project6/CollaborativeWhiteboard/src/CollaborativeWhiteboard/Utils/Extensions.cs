using System.Drawing;

namespace CollaborativeWhiteboard.Utils
{
    public static class Extensions
    {
        public static Color ToColor(this string hex)
        {
            if (string.IsNullOrEmpty(hex) || hex.Length != 7 || hex[0] != '#')
                throw new ArgumentException("Invalid hex color format.");

            return ColorTranslator.FromHtml(hex);
        }

        public static string ToHex(this Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}