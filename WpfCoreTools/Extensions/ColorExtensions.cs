using System.Windows.Media;

namespace WpfCoreTools.Extensions
{
    /// <summary>
    /// Provides a set of <see cref="Color"/> extensions.
    /// </summary>
    public static class ColorExtensions
    {
        /// <summary>
        /// Invert the color by subtracting every value R, G, B from 255.
        /// </summary>
        /// <param name="color">Colore.</param>
        /// <returns>Inverted color.</returns>
        public static Color Invert(this Color color)
            => Color.FromRgb((byte)(255 - color.R), (byte)(255 - color.G), (byte)(255 - color.B));

        /// <summary>
        /// Converts a <see cref="System.Drawing.Color"/> to a <see cref="Color"/>.
        /// </summary>
        /// <param name="color"><see cref="System.Drawing.Color"/> to convert.</param>
        /// <returns><see cref="Color"/>.</returns>
        public static Color FromDrawingColor(System.Drawing.Color color)
            => Color.FromArgb(color.A, color.R, color.G, color.B);

        /// <summary>
        /// Converts a <see cref="Color"/> to a <see cref="System.Drawing.Color"/>.
        /// </summary>
        /// <param name="color"><see cref="System.Drawing.Color"/> to convert.</param>
        /// <returns><see cref="System.Drawing.Color"/>.</returns>
        public static System.Drawing.Color ToDrawingColor(Color color)
            => System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
    }
}
