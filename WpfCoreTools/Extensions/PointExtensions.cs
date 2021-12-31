using System.Windows;

namespace WpfCoreTools.Extensions
{
    /// <summary>
    /// Provides a set of <see cref="Point"/> extensions.
    /// </summary>
    public static class PointExtensions
    {
        /// <summary>
        /// Converts the <see cref="System.Drawing.Point"/> to a <see cref="Point"/>.
        /// </summary>
        /// <param name="point"><see cref="System.Drawing.Point"/> to convert.</param>
        /// <returns><see cref="Point"/>.</returns>
        public static Point ToWindowsPoint(this System.Drawing.Point point)
            => new(point.X, point.Y);

        /// <summary>
        /// Converts the <see cref="Point"/> to a <see cref="System.Drawing.Point"/>.
        /// </summary>
        /// <param name="point"><see cref="System.Drawing.Point"/> to convert.</param>
        /// <returns><see cref="System.Drawing.Point"/>.</returns>
        public static System.Drawing.Point ToDrawingPoint(this Point point)
            => new((int)point.X, (int)point.Y);
    }
}
